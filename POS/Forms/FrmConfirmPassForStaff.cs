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
    public partial class FrmConfirmPassForStaff : Form
    {
        string emp;
        int status;
        FrmMain frm;
        string Check = "";

        RMSDataSet ds = new RMSDataSet();

        ospos_usersTableAdapter tbUser = new ospos_usersTableAdapter();
        public FrmConfirmPassForStaff()
        {
            InitializeComponent();
        }
        public FrmConfirmPassForStaff(FrmMain main, int state)
        {
            InitializeComponent();
            frm = main;
            status = state;
        }

        private void FrmConfirmPass_Load(object sender, EventArgs e)
        {
            txtPass.Focus();
        }

        private void EnterQty(object e)
        {
            Button b = (Button)e;
            txtPass.Text += b.Text;
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
            string s = txtPass.Text;
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                txtPass.Text = s;
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_click(object sender, EventArgs e)
        {
            this.tbUser.paidinout(ds.ospos_users, txtPass.Text);
            if (ds.ospos_users.Rows.Count > 0)
            {
                this.emp = ds.ospos_users.Rows[0][ds.ospos_users.idColumn].ToString();
                this.Check = ds.ospos_users.Rows[0][ds.ospos_users.useridColumn].ToString();
            }
            if (emp != null)
            {
                if (status == 1)
                {
                    if (this.Check != frm.EmpID)
                    {
                        FrmDialogOK.Show("Incorrect Password", "");
                        txtPass.Clear();
                        return;
                    }
                    else
                    {
                        this.Close();

                        FrmPaidIn paidIn = new FrmPaidIn("2", "Cash In", frm.TerminalID, frm.EmpID);
                        paidIn.ShowDialog();
                        paidIn.Dispose();
                        if (paidIn.cancels)
                        {
                            return;
                        }
                        frm.OpenCashDrawer();
                    }
                }
                else if (status == 2)
                {
                    if (this.Check != frm.EmpID)
                    {
                        FrmDialogOK.Show("Incorrect Password", "");
                        txtPass.Clear();
                        return;
                    }
                    else
                    {
                        this.Close();
                        frm.OpenCashDrawer();
                        FrmPaidIn paidIn = new FrmPaidIn("3", "Cash Out", frm.TerminalID, frm.EmpID);
                        paidIn.ShowDialog();
                        paidIn.Dispose();
                    }

                }

            }
            else
            {
                FrmDialogOK.Show("Incorrect Password", "");
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
