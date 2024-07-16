using POS.ClassControl;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using POS.Report;
using POS.Services;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmBillDetail : Form
    {
        public FrmMain frm;
        private decimal Total = 0, SubTotal = 0, Discount = 0;
        public int SaleID { get; set; }
        public int SaleNO { get; set; }
        public string Emp { get; set; }
        public string CTime { set { lbTime.Text = value; } }
        public bool prints { get { return btnPrint.Visible; } set { btnPrint.Visible = value; } }
        public bool CancleBill { get { return btnCancleBill.Visible; } set { btnCancleBill.Visible = value; } }
        public string SalesTypeID { get; set; }

        RMSDataSet ds = new RMSDataSet();

        SaleService saleService = new SaleService();
        RedeemService redeemService = new RedeemService();
        SyncData sync = new SyncData();

        SellListTableAdapter tbSellList = new SellListTableAdapter();
        GetPaymentTableAdapter tbGetPayment = new GetPaymentTableAdapter();
        ospos_saleTableAdapter tbSale = new ospos_saleTableAdapter();
        ospos_sale_refundTableAdapter tbSaleRefund = new ospos_sale_refundTableAdapter();
        ospos_memberTableAdapter tbMember = new ospos_memberTableAdapter();
        ospos_storeTableAdapter tbStore = new ospos_storeTableAdapter();
        ListForInvoiceTableAdapter tbListInvoice = new ListForInvoiceTableAdapter();
        InvoiceDetailTableAdapter tbInvoice = new InvoiceDetailTableAdapter();
        TerminalTableAdapter tbTerminal = new TerminalTableAdapter();
        POSCashDrawerTableAdapter tbCashDrawer = new POSCashDrawerTableAdapter();
        ospos_usersTableAdapter tbUser = new ospos_usersTableAdapter();
        ospos_companyTableAdapter tbCompany = new ospos_companyTableAdapter();
        public FrmBillDetail(FrmMain frms)
        {
            InitializeComponent();
            frm = frms;
        }

        public void LoadList()
        {
            if (this.SaleID != 0)
            {
                gridItem.DataSource = tbSellList.GetData(SaleID);
            }
            else
            {
                gridItem.DataSource = null;
            }
            gridItem.ClearSelection();
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
            decimal total = 0, discount = 0;

            foreach (DataGridViewRow row in gridItem.Rows)
            {
                if (row.Cells[sortbyDataGridViewTextBoxColumn.Name].Value.ToString() == "1")
                {
                    total += decimal.Parse(row.Cells[totalDataGridViewTextBoxColumn.Name].Value.ToString());
                    discount += decimal.Parse(row.Cells[itemdiscountDataGridViewTextBoxColumn.Name].Value.ToString());
                }
            }
            Total = total;
            SubTotal = total + discount;
            SaleNO = (int)ds.ospos_sale.Rows[0][ds.ospos_sale.sale_noColumn];

            lbBil.Text = SaleID.ToString();
            lbCheckNo.Text = SaleNO.ToString("N0");
            lbSubtotal.Text = (SubTotal).ToString("N0");
            lbDiscount.Text = Discount.ToString("N0").Replace("-", string.Empty);
            lbVat.Text = (saleService.CalVat(SubTotal)).ToString("N0");
            lbAmount.Text = (total).ToString("N0");
            lbPaymentType.Text = ds.GetPayment[0].name + ":";
            lbPay.Text = ds.GetPayment[0].payment_receive.ToString("N0");
            lbChange.Text = ds.GetPayment[0].payment_change.ToString("N0");
            lbReceivePoints.Text = ds.ospos_sale.Rows[0][ds.ospos_sale.pointsColumn].ToString();
            lbEmp.Text = ds.ospos_sale.Rows[0][ds.ospos_sale.fk_user_idColumn].ToString() + " " + tbUser.GetName(ds.ospos_sale.Rows[0][ds.ospos_sale.fk_user_idColumn].ToString());
            lbMember.Text = this.tbMember.GetPhone((int)ds.ospos_sale.Rows[0][ds.ospos_sale.fk_member_idColumn]);
        }

        private void FrmBillDetail_Load(object sender, EventArgs e)
        {
            LoadList();
            label7.Text = ("ອມພ " + saleService.GeTax() + "%");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ds.Dispose();
            this.Close();
        }

        private void gridItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbBil_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lbCheckNo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbMember_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbDiscount_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbVat_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lbAmount_Click(object sender, EventArgs e)
        {

        }

        private void lbPaymentType_Click(object sender, EventArgs e)
        {

        }

        private void lbPay_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lbChange_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lbReceivePoints_Click(object sender, EventArgs e)
        {

        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void lbEmp_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sellListBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RMSDataSet md = new RMSDataSet();

            CRRePrintInv invoice = new CRRePrintInv();

            PrinterSettings ps = new PrinterSettings();
            md.EnforceConstraints = false;
            tbListInvoice.FillBySaleID(md.ListForInvoice, SaleID);
            tbInvoice.FillBySaleID(md.InvoiceDetail, SaleID);
            tbGetPayment.Fill(md.GetPayment, SaleID);
            tbTerminal.FillByTerminalID(md.Terminal, ds.ospos_sale.Rows[0][ds.ospos_sale.fk_terminal_idColumn].ToString());
            tbStore.Fill(md.ospos_store);
            tbCompany.FillBy(md.ospos_company);

            try
            {
                invoice.SetDataSource(md);
                invoice.PrintOptions.PrinterName = ps.PrinterName;
                invoice.Refresh();
                invoice.PrintToPrinter(1, false, 0, 0);
            }
            catch (Exception)
            {
                FrmDialogOK.Show("Connot Connect Printer", "Error");
            }
            md.Dispose();
            invoice.Dispose();
        }

        private void btnCancleBill_Click(object sender, EventArgs e)
        {
            if (FrmDialogYesNo.Show("Do you Want To Cancle This Check?", "Confirm") == DialogResult.Yes)
            {
                int Salerefundseq = (int)tbSaleRefund.GenSaleRefundSeq();
                saleService.InsertselectSaleRefund(Salerefundseq.ToString(), frm.TerminalID.ToString(), frm.Maker, frm.EmpID, SaleID);
                saleService.InsertselectSaleRefundDetail(Salerefundseq.ToString(),frm.TerminalID.ToString()," ", frm.Maker, frm.EmpID, SaleID);

                redeemService.UpdateFreeItemStatus(SaleID, "V", "T");
                saleService.UpdateMemberPointStatus(SaleID, "V", "T");
                //saleService.UpdateSaleStatus(SaleID, "V", frm.Maker, "T");
                //saleService.UpdateSaleDetailStatus(SaleID, "V", "T");
                sync.syncAllData(frm.BaseURL, frm.StoreID, frm.Token);


                RMSDataSet md = new RMSDataSet();
                CRVoidInv invoice = new CRVoidInv();
                PrinterSettings ps = new PrinterSettings();
                md.EnforceConstraints = false;
                tbListInvoice.FillBySaleID(md.ListForInvoice, SaleID);
                tbInvoice.FillBySaleID(md.InvoiceDetail, SaleID);
                tbGetPayment.Fill(md.GetPayment, SaleID);
                tbTerminal.FillByTerminalID(md.Terminal, ds.ospos_sale.Rows[0][ds.ospos_sale.fk_terminal_idColumn].ToString());
                tbStore.Fill(md.ospos_store);
                tbCompany.FillBy(md.ospos_company);

                try
                {
                    invoice.SetDataSource(md);
                    invoice.PrintOptions.PrinterName = ps.PrinterName;
                    invoice.Refresh();
                    invoice.PrintToPrinter(1, false, 0, 0);
                    this.tbCashDrawer.InsertQuery(DateTime.Now.Date, DateTime.Now, frm.TerminalID.ToString(), frm.EmpID, 1, "5", "cancel bill", Total, "F", DateTime.Now, "F");
                    frm.OpenCashDrawer();
                }
                catch (Exception)
                {
                    FrmDialogOK.Show("Connot Connect Printer", "Error");
                }
                md.Dispose();
                invoice.Dispose();
                frm.Maker = "";
                Close();              
            }           
            ds.Dispose();
        }
    }
}
