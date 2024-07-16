using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using POS.Report;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using POS.ClassControl;
using DevExpress.Printing.Utils.DocumentStoring;
using System.Net.NetworkInformation;
using POS.Services;

namespace POS
{
    public partial class UC_Manage : UserControl
    {
        FrmMain frm;
        //model models;
        RMSDataSet ds = new RMSDataSet();

        SaleService saleService = new SaleService();

        ospos_sale_paymentsTableAdapter tbSalePayment = new ospos_sale_paymentsTableAdapter();
        ClockTimeTableAdapter tbClockTime = new ClockTimeTableAdapter();
        ospos_usersTableAdapter tbUser = new ospos_usersTableAdapter();
        TerminalTableAdapter tbTerminal = new TerminalTableAdapter();
        ListBillTableAdapter tbListBill = new ListBillTableAdapter();

        public UC_Manage()
        {
            InitializeComponent();
        }
        public UC_Manage(FrmMain main)
        {
            InitializeComponent();
            frm = main;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            frm._Manage.SendToBack();
        }

        private void UC_Manage_Load(object sender, EventArgs e)
        {

        }

        private void btnPaidIn_Click(object sender, EventArgs e)
        {
            using (FrmConfirmPassForStaff fm = new FrmConfirmPassForStaff(frm, 1))
            {
                fm.ShowDialog();
            }
        }

        private void btnPaidOut_Click(object sender, EventArgs e)
        {
            using (FrmConfirmPassForStaff fm = new FrmConfirmPassForStaff(frm, 2))
            {
                fm.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.tbSalePayment.FillBySaleID(ds.ospos_sale_payments, frm.SaleID);
            if (ds.ospos_sale_payments.Rows.Count > 0)
            {
                FrmDialogOK.Show("ກະລຸນາລຶບລາຍການຈ່າຍເງິນກ່ອນ!!!", "Warning!");
                return;
            }
            if (frm.SaleID != 0)
            {
                saleService.UpdateSaleStatus(frm.SaleID, "B", " ", "T");
            }
            saleService.updatestatusonline("0", frm.EmpID);
            frm.ClearFreeitem();
            ds.Dispose();
            frm.uC_Sale1.btnclose_Click(sender, e);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.tbSalePayment.FillBySaleID(ds.ospos_sale_payments, frm.SaleID);
            if (ds.ospos_sale_payments.Rows.Count > 0)
            {
                FrmDialogOK.Show("ກະລຸນາລຶບລາຍການຈ່າຍເງິນກ່ອນ!!!", "Warning!");
                return;
            }
            if (frm.SaleID != 0)
            {
                saleService.UpdateSaleStatus(frm.SaleID, "B", " ", "T");

            }
            saleService.updatestatusonline("0", frm.EmpID);
            frm.ClearFreeitem();
            ds.Dispose();
            frm.uC_Sale1.btnsignout_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmChangePassword changepass = new FrmChangePassword(frm);
            changepass.ShowDialog();
            changepass.Dispose();
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Properties.Settings.Default.clock || Properties.Settings.Default.checkdate.Date != DateTime.Now.Date)
                {
                    if (FrmDialogYesNo.Show("Confirm To Clock In", "Message") == DialogResult.Yes)
                    {
                        Properties.Settings.Default.clock = true;
                        Properties.Settings.Default.checkdate = DateTime.Now.Date;
                        Properties.Settings.Default.clockseq = (int)this.tbClockTime.ClockSeq();
                        Properties.Settings.Default.Save();
                        this.tbClockTime.InsertQuery(DateTime.Now.Date, frm.EmpID, Properties.Settings.Default.clockseq, "1", DateTime.Now, null, null);

                        CRClock Clock = new CRClock();
                        RMSDataSet md = new RMSDataSet();
                        md.EnforceConstraints = false;
                        this.tbUser.FillByUserID(md.ospos_users, frm.EmpID);
                        this.tbClockTime.FillByClock(md.ClockTime, DateTime.Now.Date, Properties.Settings.Default.clockseq);
                        this.tbTerminal.FillByTerminalID(md.Terminal, frm.TerminalID);
                        Clock.SetDataSource(md);
                        Clock.PrintToPrinter(1, false, 0, 0);
                        Clock.Dispose();
                    }
                }
                else
                {
                    if (FrmDialogYesNo.Show("Confirm To Clock Out", "Message") == DialogResult.Yes)
                    {
                        RMSDataSet md = new RMSDataSet();
                        md.EnforceConstraints = false;
                        DateTime st = DateTime.Now;
                        DateTime en = DateTime.Now;
                        Properties.Settings.Default.clock = false;
                        Properties.Settings.Default.Save();
                        this.tbClockTime.UpdateQuery(DateTime.Now, DateTime.Now.Date, Properties.Settings.Default.clockseq);
                        CRClockOut ClockOut = new CRClockOut();
                        this.tbUser.FillByUserID(md.ospos_users, frm.EmpID);
                        this.tbClockTime.FillByClock(md.ClockTime, DateTime.Now.Date, Properties.Settings.Default.clockseq);
                        this.tbTerminal.FillByTerminalID(md.Terminal, frm.TerminalID);
                        if (md.ClockTime.Rows.Count > 0)
                        {
                            st = md.ClockTime[0].InDate;
                            en = md.ClockTime[0].OutDate;
                        }
                        TimeSpan hrs = DateTime.Parse(en.Hour.ToString() + ":" + en.Minute.ToString() + ":" + en.Second.ToString()).Subtract(DateTime.Parse(st.Hour.ToString() + ":" + st.Minute.ToString() + ":" + st.Second.ToString()));
                        ClockOut.SetDataSource(md);
                        ClockOut.SetParameterValue("hours", hrs.ToString());
                        ClockOut.PrintToPrinter(1, false, 0, 0);
                        ClockOut.Dispose();
                    }
                }
            }
            catch (Exception)
            {
                //FrmDialogOK.Show("Connot Connect Printer", "Error");
            }
        }

        private void btnOpenCash_Click(object sender, EventArgs e)
        {
            frm.uC_Sale1.btnopencash_Click(sender, e);
        }

        private void btnBIllOpen_Click(object sender, EventArgs e)
        {
            if (frm.Role == "10004" || frm.Role == "10005" || frm.Role == "10003")
            {
                FrmDialogOK.Show("You Dont Have Permission !!", "Warnning");
                return;
            }
            if (frm.Role != "10004" && frm.Role != "10005" && frm.Role != "99999")
            {
                FrmConfirmPass con = new FrmConfirmPass(frm, 4);
                con.ShowDialog();
                if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                {
                    return;
                }
                frm.Permission = "";
                con.Dispose();
            }
            else if (frm.Role == "10004" || frm.Role == "10005" || frm.Role == "99999")
            {
                frm.Maker = frm.EmpID;
            }
            SyncData sync = new SyncData();
            RMSDataSet ds = new RMSDataSet();
            CRBillOpen t = new CRBillOpen();
            PrinterSettings ps = new PrinterSettings();

            tbListBill.FillByBillStucking(ds.ListBill);
            if(ds.ListBill.Count <= 0 )
            {
                FrmDialogOK.Show("ບໍ່ມີລາຍການບິນຄ້າງໃນລະບົບ", "");
                return;
            }
            Task.Run(() =>
            {
                foreach (RMSDataSet.ListBillRow item in ds.ListBill)
                {
                    SaleModel sale = new SaleModel
                    {
                        sale_id = item.sale_id,
                        sale_status = "C",
                        closedate = DateTime.Now,
                        lastupdate = DateTime.Now,
                        close_terminal_id = frm.TerminalID,
                        close_user_id = frm.EmpID,
                        fk_member_id = frm.MemberID,
                        points = 0,
                        total_points = 0,
                        remark = frm.Maker,
                        interfacestatus = "T",
                    };
                    saleService.UpdateCloseSale(sale);
                    saleService.UpdateSaleDetailStatus(item.sale_id, "C", "T");
                }
            });
            tbUser.Login(ds.ospos_users, frm.EmpID);
            tbTerminal.FillByTerminalID(ds.Terminal, frm.TerminalID);

            sync.syncAllData(frm.BaseURL, frm.StoreID, frm.Token);

            t.SetDataSource(ds);
            t.PrintOptions.PrinterName = ps.PrinterName;
            t.Refresh();
            t.PrintToPrinter(1, false, 0, 0);
            frm.Maker = " ";
            ds.Dispose();
        }
    }
}
