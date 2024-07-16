using POS.ClassControl;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmEnterCustomerID : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Des, int Reserve);
        public string cusName;
        public int CustomerID;
        public string CustomerPhone;
        public bool checkStatus;
        int des;
        public FrmMain frm;

        RMSDataSet ds = new RMSDataSet();

        ospos_memberTableAdapter tbMember = new ospos_memberTableAdapter();
        
        public FrmEnterCustomerID()
        {
            InitializeComponent();
        }
        public FrmEnterCustomerID(FrmMain main)
        {
            InitializeComponent();
            frm = main;
        }

        private void FrmConfirmPass_Load(object sender, EventArgs e)
        {
            txtCustomerID.Focus();
        }

        private void EnterQty(object e)
        {
            Button b = (Button)e;
            txtCustomerID.Text += b.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            string s = txtCustomerID.Text;
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                txtCustomerID.Text = s;
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text.Length == 0)
            {
                FrmDialogOK.Show("ກະລຸນາປ້ອນຂໍ້ມູນ", "");
                return;
            }
            this.tbMember.FillBy(ds.ospos_member, txtCustomerID.Text);
            if (ds.ospos_member.Rows.Count > 0)
            {
                this.CustomerPhone = ds.ospos_member.Rows[0][ds.ospos_member.phoneColumn].ToString();
                this.CustomerID = (int)ds.ospos_member.Rows[0][ds.ospos_member.idColumn];
                this.cusName = ds.ospos_member.Rows[0][ds.ospos_member.cusNameColumn].ToString();
                this.checkStatus = (bool)ds.ospos_member.Rows[0][ds.ospos_member.statusColumn];
            }
            if (CustomerID != 0 && checkStatus == true)
            {
                FrmCustomerDetail fm = new FrmCustomerDetail(frm, this.cusName, this.CustomerPhone, this.CustomerID);
                fm.ShowDialog();
                this.Close();
            }
            else if (CustomerID == 0)
            {
                FrmDialogOK.Show("ບໍ່ມີຂໍ້ມູນລູກຄ້າໃນລະບົບ !", "Warning !");
            }
            else if (checkStatus == false)
            {
                FrmDialogOK.Show("ສະມາຊິກຖືກປິດໃຊ້ງານ!", "Warning");
            }
            this.CustomerPhone = "";
            this.cusName = "";
            this.CustomerID = 0;
            if (InternetGetConnectedState(out des, 0))
            {

            }
            else
            {
                FrmDialogOK.Show("Offline", "");
            }
            ds.Dispose();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter_click(sender, e);
            }
        }
    }
}
