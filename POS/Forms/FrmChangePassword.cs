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
    public partial class FrmChangePassword : Form
    {
        FrmMain frm;

        ospos_usersTableAdapter tbUser = new ospos_usersTableAdapter();
        public FrmChangePassword(FrmMain main)
        {
            InitializeComponent();
            frm = main;
        }
        bool pass, newpass;
        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            txtPass.Focus();
            pass = true;
            newpass = false;
        }
        private void EnterNumber(object e)
        {
            Button b = (Button)e;
            if (pass == true)
            {
                txtPass.Text += b.Text;
            }
            else if (newpass == true)
            {
                txtNewPass.Text += b.Text;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (frm.Pass != txtPass.Text)
            {
                FrmDialogOK.Show("Incorrect Password !","Warnning");
            }
            else
            {
                RMSDataSet ds = new RMSDataSet();
                tbUser.Login(ds.ospos_users, txtNewPass.Text);
                if(ds.ospos_users.Rows.Count > 0)
                {
                    FrmDialogOK.Show("ບໍ່ສາມາດນຳໃຊ້ລະຫັດນີ້ໄດ້!", "Warning!");
                    return;
                }
                tbUser.UpdatePassword(txtNewPass.Text, frm.EmpID);
                ds.Dispose();
                this.Close();
            }   
        }

        private void txtNewPass_Click(object sender, EventArgs e)
        {
            newpass = true;
            pass = false;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            pass = true;
            newpass = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            string s = txtPass.Text;
            string n = txtNewPass.Text;
            if (pass)
            {
                if (s.Length > 0)
                {
                    s = s.Substring(0, s.Length - 1);
                    txtPass.Text = s;
                }
            }
            else if (newpass)
            {
                if (n.Length > 0)
                {
                    n = n.Substring(0, n.Length - 1);
                    txtNewPass.Text = n;
                }
            }

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            if (pass)
            {
                txtPass.Clear();
            }
            else if (newpass)
            {
                txtNewPass.Clear();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
