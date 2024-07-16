using POS.ClassControl;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmListBill : Form
    {
        //model m = new model();
        UC_ListBill uc;
        FrmMain frm;
        FrmBillDetail FrmBill;

        RMSDataSet ds = new RMSDataSet();

        SaleService saleService = new SaleService();
        ListBillTableAdapter tbListBill = new ListBillTableAdapter();
        ospos_saleTableAdapter tbSale = new ospos_saleTableAdapter();
        public string start { get; set; }
        public frmListBill()
        {
            InitializeComponent();
        }
        public frmListBill(FrmMain fm)
        {
            InitializeComponent();
            frm = fm;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ds.Dispose();
            this.Close();
        }

        private void frmListBill_Load(object sender, EventArgs e)
        {
            ds.ListBill.Clear();

            if (start == "B")
            {
                this.tbListBill.Fill(ds.ListBill, "B");
                BillBreak();
            }
            else if (start == "S")
            {
                this.tbListBill.FillBySale(ds.ListBill);
                BillSale();
            }
        }
        private void BillBreak()
        {
            foreach (DataRow item in ds.ListBill.Rows)
            {
                uc = new UC_ListBill((int)item[ds.ListBill.sale_idColumn], (int)item[ds.ListBill.sale_noColumn], item[ds.ListBill.fullnameColumn].ToString(), item[ds.ListBill.netprice_amountColumn].ToString(), item[ds.ListBill.opendateColumn].ToString(), item[ds.ListBill.lastupdateColumn].ToString());
                uc.Click += billClick;
                if (DateTime.Now.Date > DateTime.Parse(item[ds.ListBill.opendateColumn].ToString()))
                {
                    uc.Enabled = false;
                    uc.btnCol = Color.DarkRed;
                    uc.btnfor = Color.White;
                    uc.billcheck = false;
                }
                else { uc.billcheck = true; }
                flowLayoutPanel1.Controls.Add(uc);
            }
        }
        private void billClick(object sender, EventArgs e)
        {
            RMSDataSet ds = new RMSDataSet();
            ds.ospos_sale.Clear();
            ds.EnforceConstraints = false;

            if (frm.SaleID != 0)
            {
                saleService.UpdateSaleStatus(frm.SaleID, "B", "  ", "T");
            }
            string status = "";
            UC_ListBill uC_;
            uC_ = (UC_ListBill)sender;

            tbSale.FillBySaleID(ds.ospos_sale, uc.SaleID);
            if (ds.ospos_sale.Rows.Count > 0)
            {
                status = ds.ospos_sale.Rows[0][ds.ospos_sale.sale_statusColumn].ToString();
            }
            if (status == "B")
            {
                frm.SaleID = uC_.SaleID;
                frm.SaleNO = uC_.SaleNO;
                frm.isOpenBill = uC_.billcheck;
                frm.LoadList();
                saleService.UpdateSaleStatus(uC_.SaleID, "O", "  ", "T");
                ds.Dispose();
                this.Close();
            }
            else
            {
                FrmDialogOK.Show("ບິນນີ້ກຳລັງຖືກໃຊ້ງານຢູ່", "");
            }
            ds.Dispose();
        }
        private void BillSale()
        {
            foreach (DataRow item in ds.ListBill.Rows)
            {
                uc = new UC_ListBill((int)item[ds.ListBill.sale_idColumn], (int)item[ds.ListBill.sale_noColumn], item[ds.ListBill.fullnameColumn].ToString(), item[ds.ListBill.netprice_amountColumn].ToString(), item[ds.ListBill.opendateColumn].ToString(), item[ds.ListBill.lastupdateColumn].ToString());
                uc.Click += billDetail;
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void billDetail(object sender, EventArgs e)
        {
            UC_ListBill uC_;
            uC_ = (UC_ListBill)sender;
            frm.isOpenBill = uC_.billcheck;
            FrmBill = new FrmBillDetail(frm);
            FrmBill.SaleID = uC_.SaleID;
            FrmBill.SaleNO = uC_.SaleNO;
            FrmBill.Emp = uC_.EmpName;
            FrmBill.CTime = uC_.btnDate;
            FrmBill.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ds.Dispose();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
