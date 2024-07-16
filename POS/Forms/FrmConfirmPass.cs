using POS.ClassControl;
using POS.Forms;
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
    public partial class FrmConfirmPass : Form
    {
        string empID;
        int status;
        FrmMain frm;
        
        RMSDataSet ds = new RMSDataSet();

        SaleService saleService = new SaleService();

        ospos_usersTableAdapter tbUser = new ospos_usersTableAdapter();
        ospos_sale_paymentsTableAdapter tbSalePayment = new ospos_sale_paymentsTableAdapter();

        public FrmConfirmPass()
        {
            InitializeComponent();
        }
        public FrmConfirmPass(FrmMain main, int state)
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
            this.Close();
            this.tbUser.Login(ds.ospos_users, txtPass.Text);
            if (ds.ospos_users.Rows.Count > 0)
            {
                this.empID = ds.ospos_users.Rows[0][ds.ospos_users.useridColumn].ToString();
                frm.Permission = ds.ospos_users.Rows[0][ds.ospos_users.fk_usersrole_idColumn].ToString();
            }
            if (empID != null)
            {
                if (status == 1)
                {
                    frm.fmlogin.Show();
                    frm.Monitor.Close();
                    frm.Close();
                    this.Close();
                    
                }
                else if (status == 2)
                {
                    this.tbSalePayment.FillBySaleID(ds.ospos_sale_payments, frm.SaleID);
                    if (ds.ospos_sale_payments.Rows.Count > 0)
                    {
                        FrmDialogOK.Show("Please Remove Cash From List", "");
                        return;
                    }
                    if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                    {
                        txtPass.Clear();
                        FrmDialogOK.Show("You Dont Have Permission !!", "Warnning");
                        return;
                    }
                    if (frm.SaleID != 0)
                    {
                        saleService.UpdateSaleStatus(frm.SaleID, "B", " ", "T");
                    }
                    frm.ClearFreeitem();
                    saleService.updatestatusonline("0", frm.EmpID);
                    frm.fmlogin.Close();
                   
                }
                else if (status == 3)
                {
                    this.tbSalePayment.FillBySaleID(ds.ospos_sale_payments, frm.SaleID);
                    if (ds.ospos_sale_payments.Rows.Count > 0)
                    {
                        FrmDialogOK.Show("Please Remove Cash From List", "");
                        return;
                    }
                    if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                    {
                        txtPass.Clear();
                        FrmDialogOK.Show("You Dont Have Permission !!", "Warnning");
                        return;
                    }
                    frm.mini();
                }
                else if (status == 4)
                {
                    if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                    {
                        txtPass.Clear();
                        FrmDialogOK.Show("You Dont Have Permission !!", "Warnning");
                        return;
                    }
                    else
                    {
                        frm.Maker = this.empID;
                        this.Close();
                    }
                }
                else if (status == 5)
                {
                    if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                    {
                        txtPass.Clear();
                        FrmDialogOK.Show("You Dont Have Permission !!", "Warnning");
                        return;
                    }
                    else
                    {
                        frm.Maker = this.empID;                      
                        FrmVoid frmyes = new FrmVoid(frm);
                        frmyes.ShowDialog();
                        this.Close();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
