using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using POS.ClassControl;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;

namespace POS
{
    public partial class FrmCustomerDetail : Form
    {
        public FrmMain frm;
        public int CusID;
        string CusName, CusPhone;
        decimal Points = 0;
        HttpClient http = new HttpClient();
        List<CustomerModel> Customer = new List<CustomerModel>();

        ospos_companyTableAdapter tbCompany = new ospos_companyTableAdapter();
        public FrmCustomerDetail(FrmMain fm, string cusname, string cusphone, int cusid)
        {
            InitializeComponent();
            frm = fm;
            CusID = cusid;
            CusName = cusname;
            CusPhone = cusphone;
        }

        private void FrmCustomerDetail_Load(object sender, EventArgs e)
        {
            lbCusName.Text = CusName;
            lbCustomerID.Text = CusPhone;
            getCustomer();

            if (frm.isMember != true)
            {
                btnSignOut.Visible = false;
            }
            if (frm.isMember == true)
            {
                btnUse.Visible = false;
            }
        }
        private void getCustomer()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "8.8.8.8";
                byte[] buffer = new byte[32];
                int timeout = 3000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                if (reply.Status == IPStatus.Success)
                {
                    http.DefaultRequestHeaders.Add("Authorization", "Bearer " + frm.Token);
                    Uri url = new UriBuilder(tbCompany.GetIPServer() + "/api/sxmember/" + CusPhone).Uri;
                    HttpResponseMessage response = http.GetAsync(url).Result;
                    string customer = response.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<List<MemberPointModel>>(customer);
                    if (data != null)
                    {
                        foreach (var item in data)
                        {
                            this.Points = item.points;
                            //Amount = item.Amount;
                        }
                    }
                    lbPoints.Text = Points.ToString("N0");
                    //lbAmount.Text = (((int)Points / 500) * 500).ToString("N0");
                }
                else
                {
                    FrmDialogOK.Show("ອິນເຕີເນັດ ຂາດການເຊື່ອມຕໍ່!" + "\n" + "(ບໍ່ສາມາດນຳໃຊ້ຄະແນນຊຳລະສິນຄ້າໄດ້)", "Error!");
                }
            }
            catch
            {
                FrmDialogOK.Show("ອິນເຕີເນັດ ຂາດການເຊື່ອມຕໍ່!" + "\n" + "(ບໍ່ສາມາດນຳໃຊ້ຄະແນນຊຳລະສິນຄ້າໄດ້)", "Error!");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frm.ClearFreeitem();
            frm.MemberID = 0;
            frm.MemberName = "";
            frm.MemberPhone = "";
            frm.MemberPoints = 0;
            frm.isMember = false;
            frm.PointUsed = 0;
            frm.Monitor.lbMember.Text = "";
            frm.Monitor.lbPoints.Text = "";
            frm.lbMember.Text = "";
            frm.lbPoints.Text = "";
            frm.LoadList();
            this.Close();
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            frm.lbMember.Text = CusPhone;
            frm.lbPoints.Text = Points.ToString("N0");
            frm.MemberID = CusID;
            frm.MemberName = CusName;
            frm.MemberPhone = CusPhone;
            frm.MemberPoints = Points;
            frm.Monitor.lbMember.Text = CusPhone;
            frm.Monitor.lbPoints.Text = Points.ToString("N0");
            frm.isMember = true;
            this.Close();
        }

        private void btnRedeem_Click(object sender, EventArgs e)
        {
            if (frm.isMember == false)
            {
                frm.lbMember.Text = CusPhone;
                frm.lbPoints.Text = Points.ToString("N0");
                frm.MemberID = CusID;
                frm.MemberName = CusName;
                frm.MemberPhone = CusPhone;
                frm.MemberPoints = Points;
                frm.Monitor.lbMember.Text = CusPhone;
                frm.Monitor.lbPoints.Text = Points.ToString("N0");
                frm.isMember = true;
            }
            frm.uC_Reward.BringToFront();
            frm.uC_Reward.LoadPoints();
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
