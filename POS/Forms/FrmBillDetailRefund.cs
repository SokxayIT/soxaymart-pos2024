using POS.ClassControl;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using System;
using POS.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forms
{
    public partial class FrmBillDetailRefund : Form
    {
        public int saleseqdetail = 0;
        public decimal SaleQty;
        public int SaleID { get; set; }
        public int itemid { get; set; }
        //public int SaleNO { get; set; }
        public FrmMain frm;
        public FrmBillDetailRefund fdr;
        SaleService saleService = new SaleService();
        RMSDataSet ds = new RMSDataSet();
        ospos_sale_refundTableAdapter tbSaleRefund = new ospos_sale_refundTableAdapter();
        ListRefundTableAdapter listrefund = new ListRefundTableAdapter();
        ospos_temp_sale_refund_detailTableAdapter tbSaleRefundDetail = new ospos_temp_sale_refund_detailTableAdapter();
        SellListTableAdapter tbSellList = new SellListTableAdapter();
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

        public FrmBillDetailRefund()
        {
            InitializeComponent();

        }
        public FrmBillDetailRefund(FrmMain frms)
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
            //RMSDataSet md = new RMSDataSet();
            //md.EnforceConstraints = false;
            ds.EnforceConstraints = false;
            this.tbGetPayment.Fill(ds.GetPayment, SaleID);
            this.tbSale.FillBySaleID(ds.ospos_sale, SaleID);
            this.listrefund.Fill(ds.ListRefund,SaleID,itemid);
            //this.tbSaledetail.GenDetailSeq(SaleID, itemid);
            //decimal total = 0, discount = 0;

            //foreach (DataGridViewRow row in gridItem.Rows)
            //{
            //    if (row.Cells[sortbyDataGridViewTextBoxColumn.Name].Value.ToString() == "1")
            //    {
            //        total += decimal.Parse(row.Cells[totalDataGridViewTextBoxColumn.Name].Value.ToString());
            //        discount += decimal.Parse(row.Cells[itemdiscountDataGridViewTextBoxColumn.Name].Value.ToString());
            //    }
            //}
            //Total = total;
            //SubTotal = total + discount;
            //SaleNO = (int)ds.ospos_sale.Rows[0][ds.ospos_sale.sale_noColumn];
            SaleQty = (int)ds.ListRefund[0].item_qty;
            saleseqdetail = (int)ds.ListRefund[0].sale_detailseq;
            lbBil.Text = SaleID.ToString();
            //lbCheckNo.Text = SaleNO.ToString("N0");
            lbSubtotal.Text = ds.ListRefund[0].item_netprice.ToString("N0");
            lbDiscount.Text = ds.ListRefund[0].item_discount.ToString("N0").Replace("-", string.Empty);
            lbVat.Text = ds.ListRefund[0].item_vat.ToString("N0");
            lbAmount.Text = ds.ListRefund[0].item_netprice.ToString("N0");
            lbPaymentType.Text = ds.GetPayment[0].name + ":";
            //lbPay.Text = ds.GetPayment[0].payment_receive.ToString("N0");
            //lbChange.Text = ds.GetPayment[0].payment_change.ToString("N0");
            lbReceivePoints.Text = ds.ListRefund[0].points.ToString("N0");
            lbEmp.Text = ds.ospos_sale.Rows[0][ds.ospos_sale.fk_user_idColumn].ToString() + " " + tbUser.GetName(ds.ospos_sale.Rows[0][ds.ospos_sale.fk_user_idColumn].ToString());
            lbMember.Text = this.tbMember.GetPhone((int)ds.ospos_sale.Rows[0][ds.ospos_sale.fk_member_idColumn]);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //LoadList();
            FrmEditQty frmeditqty = new FrmEditQty();
            frmeditqty.SaleID = SaleID;
            frmeditqty.SaleSeqDetail = saleseqdetail;
            frmeditqty.itemid = itemid;
            frmeditqty.SaleQty = SaleQty;
            frmeditqty.ShowDialog();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            saleService.DeleteTempSaleRefund(SaleID);
            saleService.DeleteTempSaleRefundDetail(SaleID);
            Close();
        }

        private void btnCancleBill_Click(object sender, EventArgs e)
        {
            int Salerefundseq = (int)tbSaleRefund.GenSaleRefundSeq();
            saleService.InsertselectSaleRefundDetail(Salerefundseq.ToString(),frm.TerminalID.ToString(), "ReFundDetail", frm.Maker, frm.EmpID, SaleID);

        }

        private void gridItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void FrmBillDetailRefund_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'rMS_NEWDataSet.ospos_sale_refund_details' table. You can move, or remove it, as needed.
            this.ospos_sale_refund_detailsTableAdapter.Fill(this.rMS_NEWDataSet.ospos_sale_refund_details);
            LoadList();
            label7.Text = ("ອມພ " + saleService.GeTax() + "%"); 

        }

        private void lbSubtotal_Click(object sender, EventArgs e)
        {

        }
    }
}
