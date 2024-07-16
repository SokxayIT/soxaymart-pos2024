using Microsoft.Reporting.WinForms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;
using POS.Report;
using POS.Models.RMSDataSetTableAdapters;
using POS.Models;

namespace POS
{
    public partial class testreport : Form
    {
        ospos_saleTableAdapter tbSale = new ospos_saleTableAdapter();
        ospos_sale_detailsTableAdapter tbSaleDetail = new ospos_sale_detailsTableAdapter();
        ospos_sale_paymentsTableAdapter tbSalePayment = new ospos_sale_paymentsTableAdapter();
        ospos_member_pointsTableAdapter tbMemberPoints = new ospos_member_pointsTableAdapter();
        ospos_payment_methodTableAdapter tbPaymentMethod = new ospos_payment_methodTableAdapter();
        ospos_freeitemTableAdapter tbFreeItem = new ospos_freeitemTableAdapter();
        SellListTableAdapter tbSellList = new SellListTableAdapter();
        POSCashDrawerTableAdapter tbCashDrawer = new POSCashDrawerTableAdapter();
        PromotionsTableAdapter tbPromotion = new PromotionsTableAdapter();
        ospos_usersTableAdapter tbUser = new ospos_usersTableAdapter();
        TerminalTableAdapter tbTerminal = new TerminalTableAdapter();
        GetPaymentTableAdapter tbGetPayment = new GetPaymentTableAdapter();
        ospos_storeTableAdapter tbStore = new ospos_storeTableAdapter();
        ospos_product_itemTableAdapter tbProductItem = new ospos_product_itemTableAdapter();
        ListForInvoiceTableAdapter tbListInvoice = new ListForInvoiceTableAdapter();
        InvoiceDetailTableAdapter tbInvoice = new InvoiceDetailTableAdapter();
        public testreport()
        {
            InitializeComponent();
        }

        private void testreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'model.CheckDetails' table. You can move, or remove it, as needed.
            //CheckDetailsTableAdapter.FillByCheckSeq(this.model.CheckDetails, 123877);
            // TODO: This line of code loads data into the 'model.CheckDetails' table. You can move, or remove it, as needed.
            //this.CheckDetailsTableAdapter.Fill(this.model.CheckDetails);
            //// TODO: This line of code loads data into the 'model.CheckDetails' table. You can move, or remove it, as needed.
            //this.CheckDetailsTableAdapter.Fill(this.model.CheckDetails);
            PageSettings ps = new PageSettings();
            PaperSize p = new PaperSize();
            PrinterSettings prts = new PrinterSettings();
            PaperSource paper = new PaperSource();
            paper.RawKind = (int)PaperKind.Custom;
            paper.SourceName = "Custom";
            p.RawKind = (int)PaperKind.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";


            //p.PaperName = "Roll Paper 80 x 297 mm";
            //p.Height = 297;
            //p.Width = 80;
            //ps.PaperSize = p;
            ps.Margins.Bottom = 0;
            ps.Margins.Top = 0;
            ps.Margins.Left = 0;
            ps.Margins.Right = 0;
            //ps.PaperSource = paper;
            //ps.PaperSize.
            ps.PaperSource.SourceName = "Custom";


            ////this.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            //this.reportViewer1.SetPageSettings(ps);
            ////this.reportViewer1.PrinterSettings = prts;
            ////this.reportViewer1.PrinterSettings = prts;
            ////this.reportViewer1.ZoomPercent = 100;
            //this.reportViewer1.RefreshReport();

            //ReportDataSource r = new ReportDataSource("DataSet1", (DataTable)CheckDetailsTableAdapter.GetDataByCheckSeq(123876));
            //LocalReport lcr = new LocalReport();
            //lcr.ReportEmbeddedResource = this.reportViewer1.LocalReport.ReportEmbeddedResource;

            //lcr.DataSources.Add(r);

            //lcr.PrintToPrinter();
            //this.reportViewer1.LocalReport.PrintToPrinter();
            //this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////CheckDetailsTableAdapter.FillByCheckSeq(this.model.CheckDetails, 123876);
            //ReportDataSource r = new ReportDataSource("DataSet1", (DataTable)CheckDetailsTableAdapter.GetDataByCheckSeq(123877));
            //LocalReport lr = new LocalReport();
            //lr.DataSources.Add(r);
            ////lr.b
            //lr.ReportEmbeddedResource = this.reportViewer1.LocalReport.ReportEmbeddedResource;
            ////lr.
            //lr.PrintToPrinter();
            
            RMSDataSet md = new RMSDataSet();


            CRInvoice iv = new CRInvoice();

            PrinterSettings ps = new PrinterSettings();
            DataTable dt = new DataTable();
            tbListInvoice.FillBySaleID(md.ListForInvoice, 107);
            tbInvoice.FillBySaleID(md.InvoiceDetail, 107);
            tbGetPayment.Fill(md.GetPayment, 107);
            tbTerminal.Fill(md.Terminal);
            tbStore.Fill(md.ospos_store);
            iv.SetDataSource(md);
  
            //b.SetDataSource(models);
            iv.PrintOptions.PrinterName = ps.PrinterName;
            crystalReportViewer1.ReportSource = iv;
            iv.Refresh();
            //t.PrintToPrinter(1, false, 0, 0);
            md.Dispose();
    
        }

        private void reportViewer1_Print(object sender, ReportPrintEventArgs e)
        {
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                s += printer + Environment.NewLine;
            }
            MessageBox.Show(s);
        }
    }
}
