using POS.ClassControl;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace POS
{
    public partial class FrmProduct : Form
    {
        FrmMain frm;
        RMSDataSet ds = new RMSDataSet();
        SaleService saleService = new SaleService();

        ProductsTableAdapter tbProducts = new ProductsTableAdapter();
        ospos_freeitemconditionTableAdapter tbFreeCond = new ospos_freeitemconditionTableAdapter();

        string Barcode;
        public FrmProduct()
        {
            InitializeComponent();
        }
        public FrmProduct(FrmMain frmMain)
        {
            InitializeComponent();
            frm = frmMain;
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'rMSDataSet.Products' table. You can move, or remove it, as needed.
                this.productsTableAdapter.Fill(this.rMSDataSet.Products);
                this.tbProducts.Fill(ds.Products);
                Task.Run(() => loaddata());

                txtSearch.Focus();
            }
            catch (Exception ex)
            { }
    
        }
        private void loaddata()
        {
            this.tbProducts.Fill(ds.Products);
            if (Grids.InvokeRequired)
            {
                Grids.Invoke(new MethodInvoker(delegate
                {
                    Grids.DataSource = this.ds.Products;
                }));
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ds.Dispose();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.TextLength == 0)
            {
                this.ds.Products.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' or [{2}] LIKE '%{3}%'", this.ds.Products.nameColumn, txtSearch.Text, this.ds.Products.barcodeColumn, txtSearch.Text);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (frm.isOpenBill)
            {
                if (Grids.Rows.Count > 0)
                {
                    insertDetail();
                    frm.LoadList();
                }
            }
            //Insert Check
            else
            {
                if (Grids.Rows.Count > 0)
                {
                    frm.SaleNO = saleService.GetSaleNO();
                    frm.SaleID = saleService.GetSaleID();
                    SaleModel sale = new SaleModel
                    {
                        sale_id = frm.SaleID,
                        sale_no = frm.SaleNO,
                        fk_sale_channel_id = 1,
                        receipt_no = DateTime.Now.ToString("yyMMddhhmmss"),
                        fk_terminal_id = frm.TerminalID,
                        fk_user_id = frm.EmpID,
                        sale_status = "O",
                        opendate = DateTime.Now,
                        closedate = null,
                        subtotal_amount = frm.SubTotal,
                        discount_amount = frm.Discount,
                        vat_amount = saleService.CalVat(frm.SubTotal),
                        netprice_amount = frm.Total,
                        cost_amount = saleService.CalCostPrice(frm.SaleID),
                        remark = " ",
                        lastupdate = null,
                        close_terminal_id = null,
                        close_user_id = null,
                        fk_member_id = 0,
                        points = 0,
                        total_points = 0,
                        margin_points = frm.Margin_Point,
                        interfacestatus = "T",
                    };
                    saleService.InsertSale(sale);
                    Properties.Settings.Default.SaleID = frm.SaleID;
                    Properties.Settings.Default.Save();
                    frm.isOpenBill = true;
                    insertDetail();
                    frm.LoadList();
                }
            }

            frm.txtsearch.Clear();
            frm.txtsearch.Focus();
            ds.Dispose();
            this.Close();
        }
        private void insertDetail()
        {
            string barcode = Grids.CurrentRow.Cells[barcodeDataGridViewTextBoxColumn.Name].Value.ToString();
            this.tbFreeCond.FillBy(ds.ospos_freeitemcondition, barcode);
            if (ds.ospos_freeitemcondition.Rows.Count > 0)
            {
                FrmDialogOK.Show("Cannot add this items", "");
                return;
            }
            int prodId = int.Parse(Grids.CurrentRow.Cells[idDataGridViewTextBoxColumn.Name].Value.ToString());
            int unittype = int.Parse(Grids.CurrentRow.Cells[fkunittypeidDataGridViewTextBoxColumn.Name].Value.ToString());
            string prodName = Grids.CurrentRow.Cells[nameDataGridViewTextBoxColumn.Name].Value.ToString();
            decimal price = decimal.Parse(Grids.CurrentRow.Cells[priceDataGridViewTextBoxColumn.Name].Value.ToString());
            decimal quantity = decimal.Parse(Grids.CurrentRow.Cells[quantityDataGridViewTextBoxColumn.Name].Value.ToString());
            decimal costPrice = decimal.Parse(Grids.CurrentRow.Cells[customcostDataGridViewTextBoxColumn.Name].Value.ToString());
            decimal vat = saleService.CalVat(price);
            decimal point = saleService.Points(price, costPrice, 0);
            int detailSeq = saleService.GetDetailSeq(prodId, frm.SaleID);
            int qty = 0;
            if(unittype == Properties.Settings.Default.weight_id)
            {
                qty = 1000;
                quantity = 1;
            }
            else
            {
                qty = 1;
            }

            if (detailSeq > 0 && unittype != Properties.Settings.Default.weight_id)
            {
                saleService.UpdateAddQty(frm.SaleID, detailSeq, 1, vat, point);
            }
            else
            {
                SaleDetailModel detail = new SaleDetailModel
                {
                    sale_id = frm.SaleID,
                    sale_detailseq = saleService.CreateDetailSeq(frm.SaleID),
                    sale_datetime = DateTime.Now,
                    fk_product_item_id = prodId,
                    product_item_name = prodName,
                    item_qty = qty,
                    qty_peice = quantity,
                    item_price = price,
                    item_vat = vat,
                    item_discount = 0,
                    item_netprice = price,
                    item_costprice = costPrice,
                    item_priceorigin = price,
                    item_status = "O",
                    promo_type = " ",
                    points = point,
                    interfacestatus = "T",
                };
                saleService.InsertSaleDetail(detail);
            }
            frm.PromotionService(prodId);
            frm.CheckQuantity(prodId);
        }

        private void Grids_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOK_Click(sender, e);
        }

        private async void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            await Task.Delay(300);
            if (txtSearch.Text.StartsWith(Properties.Settings.Default.prefix_weight_barcode))
            {
                txtSearch.Text = txtSearch.Text.Substring(2, 5);
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.ds.Products.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' or [{2}] LIKE '%{3}%'", this.ds.Products.nameColumn, txtSearch.Text, this.ds.Products.barcodeColumn, txtSearch.Text);
            }
        }

        private void Grids_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
