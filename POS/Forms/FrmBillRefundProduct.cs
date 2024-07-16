using POS.ClassControl;
using POS.Models.RMSDataSetTableAdapters;
using POS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using POS.Report;
using System.Drawing.Printing;
using POS.Services;

namespace POS.Forms
{
    public partial class FrmBillRefundProduct : Form
    {
        public int saleseqdetail = 0;
        public decimal SaleQty;
        int CheckDiscountProduct;
        public int SaleID { get; set; }
        public int itemid { get; set; }


        public FrmMain frm;
        SaleService saleService = new SaleService();
        SyncData sync = new SyncData();
        RMSDataSet ds = new RMSDataSet();
        // ospos_sale_refundTableAdapter tbSaleRefunds = new ospos_sale_refundTableAdapter();
        ListRefundTableAdapter listrefund = new ListRefundTableAdapter();
        ospos_temp_sale_refund_detailTableAdapter tbSaleRefundDetail = new ospos_temp_sale_refund_detailTableAdapter();
        ospos_temp_sale_refundTableAdapter tbsalerefund = new ospos_temp_sale_refundTableAdapter();
        ospos_sale_refundTableAdapter tbsalerefunds = new ospos_sale_refundTableAdapter();
        SellListTableAdapter tbSellList = new SellListTableAdapter();
        ospos_taxTableAdapter tbTax = new ospos_taxTableAdapter();
        GetPaymentTableAdapter tbGetPayment = new GetPaymentTableAdapter();
        ospos_saleTableAdapter tbSale = new ospos_saleTableAdapter();
        ospos_sale_detailsTableAdapter tbSaledetail = new ospos_sale_detailsTableAdapter();
        ospos_memberTableAdapter tbMember = new ospos_memberTableAdapter();
        ospos_storeTableAdapter tbStore = new ospos_storeTableAdapter();
        ListForInvoiceTableAdapter tbListInvoice = new ListForInvoiceTableAdapter();
        InvoiceDetailTableAdapter tbInvoice = new InvoiceDetailTableAdapter();
        TerminalTableAdapter tbTerminal = new TerminalTableAdapter();
        POSCashDrawerTableAdapter tbCashDrawer = new POSCashDrawerTableAdapter();
        ospos_usersTableAdapter tbUser = new ospos_usersTableAdapter();
        ospos_companyTableAdapter tbCompany = new ospos_companyTableAdapter();
        ospos_temp_sale_refund_detailTableAdapter tbTempSaleRefundDetail = new ospos_temp_sale_refund_detailTableAdapter();
        PrintRefundProductItemTableAdapter tbPrintRefund = new PrintRefundProductItemTableAdapter();
        public FrmBillRefundProduct(FrmMain frms)
        {
            InitializeComponent();
            frm = frms;
        }
        public void LoadList()
        {

            if (this.SaleID != 0)
            {
                gridItem.DataSource = listrefund.GetData(SaleID, itemid);
                gridItem.Refresh();
            }
            else
            {
                //gridItem.DataSource = listrefund.GetData(SaleID, itemid);
                gridItem.DataSource = null;
            }
            //gridItem.ClearSelection();
            GrandTotal();
            if (gridItem.Rows.Count > 0)
            {
                gridItem.FirstDisplayedScrollingRowIndex = gridItem.RowCount - 1;
            }
        }
        public void GrandTotal()
        {
            ds.EnforceConstraints = false;
            this.tbGetPayment.Fill(ds.GetPayment, SaleID);
            this.tbSale.FillBySaleID(ds.ospos_sale, SaleID);
            this.listrefund.Fill(ds.ListRefund, SaleID, itemid);

            SaleQty = (int)ds.ListRefund[0].item_qty;
            saleseqdetail = (int)ds.ListRefund[0].sale_detailseq;
            lbBil.Text = SaleID.ToString();
            //lbCheckNo.Text = SaleNO.ToString("N0");
            //lbSubtotal.Text = ds.ListRefund[0].item_netprice.ToString("N0");
            lbDiscount.Text = ds.ListRefund[0].item_discount.ToString("N0").Replace("-", string.Empty);
            lbVat.Text = ds.ListRefund[0].item_vat.ToString("N0");
            lbAmount.Text = ds.ListRefund[0].item_netprice.ToString("N0");
            //lbPaymentType.Text = ds.GetPayment[0].name + ":";
            //lbPay.Text = ds.GetPayment[0].payment_receive.ToString("N0");
            //lbChange.Text = ds.GetPayment[0].payment_change.ToString("N0");
            lbReceivePoints.Text = ds.ListRefund[0].points.ToString("N0");
            lbEmp.Text = ds.ospos_sale.Rows[0][ds.ospos_sale.fk_user_idColumn].ToString() + " " + tbUser.GetName(ds.ospos_sale.Rows[0][ds.ospos_sale.fk_user_idColumn].ToString());
            lbMember.Text = this.tbMember.GetPhone((int)ds.ospos_sale.Rows[0][ds.ospos_sale.fk_member_idColumn]);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBillRefundProduct_Load(object sender, EventArgs e)
        {
            LoadList();
            txtQty.Focus();
            label7.Text = ("ອມພ " + saleService.GeTax() + "%");
        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtQty.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            string s = txtQty.Text;
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                txtQty.Text = s;
            }
        }
        private void EnterNumber(object e)
        {
            Button b = (Button)e;
            txtQty.Text += b.Text;
        }
        private void Number_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        public void button2_Click(object sender, EventArgs e)
        {
            decimal netprice = (decimal)ds.ListRefund.Rows[0][ds.ListRefund.item_netpriceColumn];
            decimal qty = (decimal)ds.ListRefund.Rows[0][ds.ListRefund.item_qtyColumn];
            decimal price = (decimal)ds.ListRefund.Rows[0][ds.ListRefund.item_priceColumn];
            decimal costPrice = (decimal)ds.ListRefund.Rows[0][ds.ListRefund.item_costpriceColumn];
            decimal point = saleService.Points(price, costPrice, 0) * qty;
            decimal vat = saleService.CalVat(price) * qty;
            decimal netprice2 = price * qty;
            this.tbsalerefund.UpdateTempSaleRefund(price, vat, netprice2, point, SaleID);
            if (FrmDialogYesNo.Show("Do you Want To Cancle This Check?", "Confirm") == DialogResult.Yes)
            {
                int Salerefundseq = (int)tbsalerefunds.GenSaleRefundSeq();
                this.tbsalerefunds.InsertTempForSaleRefund(Salerefundseq.ToString(),frm.Maker, frm.EmpID, frm.EmpID, SaleID);
                saleService.InsertRefundProduct(Salerefundseq.ToString(), frm.TerminalID.ToString(), "ReFundDetail", frm.Maker, frm.EmpID, SaleID, itemid); ;
                RMSDataSet md = new RMSDataSet();
                CRRefundProduct invoice = new CRRefundProduct();
                PrinterSettings ps = new PrinterSettings();
                md.EnforceConstraints = false;
                tbPrintRefund.Fill(md.PrintRefundProductItem, SaleID, itemid);
                tbListInvoice.FillBySaleID(md.ListForInvoice, SaleID);
                tbInvoice.FillBySaleID(md.InvoiceDetail, SaleID);
                tbGetPayment.Fill(md.GetPayment, SaleID);
                tbTerminal.FillByTerminalID(md.Terminal, ds.ospos_sale.Rows[0][ds.ospos_sale.fk_terminal_idColumn].ToString());
                tbStore.Fill(md.ospos_store);
                tbCompany.FillBy(md.ospos_company);
                tbTax.Fill(md.ospos_tax);
                try
                {
                    invoice.SetDataSource(md);
                    invoice.PrintOptions.PrinterName = ps.PrinterName;
                    invoice.Refresh();
                    invoice.PrintToPrinter(1, false, 0, 0);
                    this.tbCashDrawer.InsertQuery(DateTime.Now.Date, DateTime.Now, frm.TerminalID.ToString(), frm.EmpID, 1, "6", "RefundProduct", netprice, "F", DateTime.Now, "F");
                    frm.OpenCashDrawer();
                }
                catch (Exception)
                {
                    FrmDialogOK.Show("Connot Connect Printer", "Error");
                }
                md.Dispose();
                invoice.Dispose();
                saleService.DeleteTempSaleRefund(SaleID);
                saleService.DeleteTempSaleRefundDetail(SaleID);
                sync.syncAllData(frm.BaseURL, frm.StoreID, frm.Token);
                frm.txtsearch.Focus();
                frm.Maker = " ";
                Close();
            }
            ds.Dispose();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            txtQty.MaxLength = 3;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            saleService.DeleteTempSaleRefund(SaleID);
            saleService.DeleteTempSaleRefundDetail(SaleID);
            Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (txtQty.Text == null || txtQty.Text == "" || txtQty.Text == " ")
            {
                FrmDialogOK.Show("ກະລຸນາປ້ອນຈຳນວນ!!!", "Warnning");
                txtQty.Clear();
                txtQty.Focus();
            }
            else
            {
                CheckDiscountProduct = (int)tbTempSaleRefundDetail.ScalarDiscountProduct(SaleID, itemid);
                if(CheckDiscountProduct==0)
                {
                    decimal qty = decimal.Parse(txtQty.Text);
                    if (SaleQty < qty)
                    {
                        FrmDialogOK.Show("ຈຳນວນທີ່ຕ້ອງການຍົກເລີກຫຼາຍກ່ອນໃນລະບົບ!!!", "Warnning");
                        txtQty.Clear();
                        txtQty.Focus();
                    }
                    else if (qty <= 0)
                    {
                        FrmDialogOK.Show("ກະລຸນາປ້ອນຈຳນວນ!!!", "Warnning");
                        txtQty.Clear();
                        txtQty.Focus();
                    }
                    else
                    {
                        ds.EnforceConstraints = false;

                        decimal price = (decimal)ds.ListRefund.Rows[0][ds.ListRefund.item_priceColumn];
                        decimal costPrice = (decimal)ds.ListRefund.Rows[0][ds.ListRefund.item_costpriceColumn];
                        decimal point = saleService.Points(price, costPrice, 0) * qty;
                        decimal vat = saleService.CalVat(price) * qty;
                        decimal netprice = price * qty;
                        this.tbsalerefund.UpdateTempSaleRefund(price, vat, netprice, point, SaleID);
                        this.tbTempSaleRefundDetail.UpdateTempSaleRefundDetailQty(qty, vat, point, netprice, SaleID, saleseqdetail, itemid);
                        LoadList();
                        txtQty.Clear();
                    }
                }
                else
                {
                    FrmDialogOK.Show("ລາຍການສິນຄ້າມີໂປຣໂມຊັນ ກະລຸນາກວດບິນລູກຄ້າ ແລະ ຄືນສິນຄ້າຕາມເງື່ອນໄຂໂປຣໂມຊັນ!!!", "Warnning");
                    txtQty.Clear();
                    txtQty.Enabled = false;
                }
                
            }
            
        }
    }
}
