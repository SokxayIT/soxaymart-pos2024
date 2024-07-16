using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using POS.Report;
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
    public partial class FrmPaidIn : Form
    {
        decimal amount;
        public string ID, Reason, TerminalID, Emp;
        CRPaid Paid;
        RMSDataSet ds = new RMSDataSet();

        TenderTableAdapter tbTender = new TenderTableAdapter();
        POSCashDrawerTableAdapter tbCashDrawer = new POSCashDrawerTableAdapter();
        POSCashDrawerTenderTableAdapter tbCashDrawerTender = new POSCashDrawerTenderTableAdapter();
        ospos_usersTableAdapter tbUser = new ospos_usersTableAdapter();
        public bool cancels { get; set; }
        public FrmPaidIn()
        {
            InitializeComponent();
        }
        public FrmPaidIn(string id, string rea, string terid, string emp)
        {
            InitializeComponent();
            ID = id;
            Reason = rea;
            TerminalID = terid;
            Emp = emp;
        }
        private void FrmPaidIn_Load(object sender, EventArgs e)
        {
            this.tbTender.Fill(ds.Tender);
            foreach (DataRow item in ds.Tender.Rows)
            {
                Grids.Rows.Add(item[ds.Tender.TenderNameColumn].ToString(), null, null, item[ds.Tender.TenderIDColumn].ToString(), decimal.Parse(item[ds.Tender.TenderValueColumn].ToString()));
            }
            cancels = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancels = true;
            this.Close();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EnterValue(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EnterValue(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EnterValue(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EnterValue(sender);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EnterValue(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EnterValue(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EnterValue(sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EnterValue(sender);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EnterValue(sender);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            EnterValue(sender);
        }
        private void EnterValue(object sender)
        {
            Button btn = (Button)sender;
            Grids.CurrentRow.Cells[c_qty.Name].Value += btn.Text;
            Grids.CurrentRow.Cells[c_Amount.Name].Value = decimal.Parse(Grids.CurrentRow.Cells[c_qty.Name].Value.ToString()) * decimal.Parse(Grids.CurrentRow.Cells[c_Value.Name].Value.ToString());
            GetTotal();
        }
        private void GetTotal()
        {
            amount = 0;
            foreach (DataGridViewRow item in Grids.Rows)
            {
                if (item.Cells[c_Amount.Name].Value != null)
                {
                    if (item.Cells[c_Amount.Name].Value.ToString() != "")
                    {
                        amount += decimal.Parse(item.Cells[c_Amount.Name].Value.ToString());
                    }
                }
            }
            lbAmount.Text = amount.ToString("N0");
        }
        private void Clr()
        {
            Grids.CurrentRow.Cells[c_qty.Name].Value = "";
            Grids.CurrentRow.Cells[c_Amount.Name].Value = "";
            //lbAmount.Text = "0";
            GetTotal();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            string s = Grids.CurrentRow.Cells[c_qty.Name].Value.ToString();
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                Grids.CurrentRow.Cells[c_qty.Name].Value = s;
                if (s.Length > 0)
                {
                    Grids.CurrentRow.Cells[c_Amount.Name].Value = decimal.Parse(Grids.CurrentRow.Cells[c_qty.Name].Value.ToString()) * decimal.Parse(Grids.CurrentRow.Cells[c_Value.Name].Value.ToString());
                }
                GetTotal();
            }
            if (s.Length == 0)
            {
                Clr();
            }
        }

        private void Grids_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            Clr();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Now;
                if (amount > 0)
                {
                    this.tbCashDrawer.InsertQuery(date.Date, date, TerminalID, Emp, 1, ID, Reason, amount, "T", date, "F");
                    foreach (DataGridViewRow item in Grids.Rows)

                        if (item.Cells[c_Amount.Name].Value != null)
                        {
                            if (item.Cells[c_Amount.Name].Value.ToString() != "")
                            {
                                this.tbCashDrawerTender.InsertQuery(date, TerminalID, item.Cells[c_TenderID.Name].Value.ToString(), decimal.Parse(item.Cells[c_qty.Name].Value.ToString()), decimal.Parse(item.Cells[c_Value.Name].Value.ToString()));
                            }
                        }
                }
                if (ID == "2")
                {
                    Paid = new CRPaid();
                    RMSDataSet md = new RMSDataSet();
                    this.tbUser.Login(md.ospos_users, Emp);
                    this.tbCashDrawer.FillByPaid(md.POSCashDrawer, date, TerminalID);
                    this.tbCashDrawerTender.FillByPaid(md.POSCashDrawerTender, date, TerminalID);
                    this.tbTender.Fill(md.Tender);
                    Paid.SetDataSource(md);
                    Paid.PrintToPrinter(1, false, 0, 0);
                    md.Dispose();
                }
                else if (ID == "3")
                {
                    Paid = new CRPaid();
                    RMSDataSet md = new RMSDataSet();
                    this.tbUser.Login(md.ospos_users, Emp);
                    this.tbCashDrawer.FillByPaid(md.POSCashDrawer, date, TerminalID);
                    this.tbCashDrawerTender.FillByPaid(md.POSCashDrawerTender, date, TerminalID);
                    this.tbTender.Fill(md.Tender);
                    Paid.SetDataSource(md);
                    md.Dispose();
                    Paid.PrintToPrinter(1, false, 0, 0);
                    
                }
                this.Close();


            }
            catch (Exception)
            {
                FrmDialogOK.Show("Connot Connect Printer", "Error");
                
                this.Close();
            }
        }
}
}
