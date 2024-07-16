using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using POS.ClassControl;
using System.Net.Http;
using POS.Report;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;

namespace POS
{
    public partial class FrmLogin : Form
    {
        Setting s;
        //model models;
        RMSDataSet ds = new RMSDataSet();
        GenerateQR QR = new GenerateQR();
        OTPRequest request = new OTPRequest();
        HttpClient http = new HttpClient();

        TerminalTableAdapter tbTerminal = new TerminalTableAdapter();
        ospos_usersTableAdapter tbUser = new ospos_usersTableAdapter();
        ClockTimeTableAdapter tbClock = new ClockTimeTableAdapter();
        SaleService saleService = new SaleService();
        string role, userID, statusonline;
        public FrmLogin()
        {
            InitializeComponent();
            request.UserName = Properties.Settings.Default.e_usernaem;
        }

        public string TerminalID { get; private set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void enternumb(object o)
        {
            Button b = new Button();
            b = (Button)o;
            txtpass.Text += b.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            enternumb(sender);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            enternumb(sender);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            enternumb(sender);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            enternumb(sender);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            enternumb(sender);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            enternumb(sender);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            enternumb(sender);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            enternumb(sender);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            enternumb(sender);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            enternumb(sender);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            string s = txtpass.Text;
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                txtpass.Text = s;
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            if (txtpass.Text =="55236641")
            {
                s = new Setting();
                s.ShowDialog();
            }
            txtpass.Clear();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            RMSDataSet ds = new RMSDataSet();

            this.tbUser.Login(ds.ospos_users, txtpass.Text);
            statusonline = tbUser.GetStatusOnline(txtpass.Text);
            TerminalID = tbTerminal.TerminalID(Environment.MachineName).ToString();
            try
            {
                var oj = http.PostAsJsonAsync("https://apipayment.sokxaycard.com/api/Users/GetOTP", request).Result;
                if (oj.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    OTPRespone otp = oj.Content.ReadAsAsync<OTPRespone>().Result;
                    Properties.Settings.Default.e_otp = otp.otpReturn;
                    Properties.Settings.Default.e_userid = otp.userId;
                    Properties.Settings.Default.ServerActive = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.ServerActive = false;
                    Properties.Settings.Default.Save();
                }


            }
            catch (Exception)
            {

            }


            if (ds.ospos_users.Rows.Count > 0)
            {
                this.userID = ds.ospos_users.Rows[0][ds.ospos_users.useridColumn].ToString();
             
                this.role = ds.ospos_users.Rows[0][ds.ospos_users.fk_usersrole_idColumn].ToString();
            }
            if (userID != null)
            {
                if (!Properties.Settings.Default.clock || Properties.Settings.Default.checkdate.Date != DateTime.Now.Date)
                {
                    try
                    {
                        if (FrmDialogYesNo.Show("Confirm To Clock In?", "Confirm") == DialogResult.Yes)
                        {
                            saleService.updatestatusonline("1", userID);
                            Properties.Settings.Default.clock = true;
                            Properties.Settings.Default.checkdate = DateTime.Now.Date;
                            Properties.Settings.Default.clockseq = (int)this.tbClock.ClockSeq();
                            Properties.Settings.Default.Save();
                            this.tbClock.InsertQuery(DateTime.Now.Date, userID.ToString(), Properties.Settings.Default.clockseq, "1", DateTime.Now, null, null);
                            CRClock Clock = new CRClock();
                            RMSDataSet dataSet = new RMSDataSet();
                            this.tbUser.FillByUserID(dataSet.ospos_users, userID.ToString());
                            this.tbClock.FillByClock(dataSet.ClockTime, DateTime.Now.Date, Properties.Settings.Default.clockseq);
                            this.tbTerminal.FillByTerminalID(dataSet.Terminal, TerminalID);
                            Clock.SetDataSource(dataSet);
                            Clock.PrintToPrinter(1, false, 0, 0);
                            
                        }
                        saleService.updatestatusonline("1", userID);
                    }
                    catch (Exception)
                    {
                        FrmDialogOK.Show("Connot Connect Printer", "Error");
                    }

                }
                saleService.updatestatusonline("1", userID);
                FrmMain fm = new FrmMain(this, this.role, this.userID);
                fm.Pass = txtpass.Text;
                fm.Show();
                this.Hide();
            }
            else
            {
                if (statusonline=="1") 
                {
                    FrmDialogOK.Show("->UserID ຂອງທ່ານ ມີເຄື່ອງທີ່ໃຊ້ງານແລ້ວ<- (ກໍລະນີບໍ່ມີເຄື່ອງໃຊ້ງານກະລຸນາແຈ້ງໄອທີ)", "");
                }
                else
                {
                    FrmDialogOK.Show("Password Incorrect", "");
                }
                
            }
            txtpass.Clear();
            ds.Dispose();
            userID = null;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtpass.Focus();                       
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
