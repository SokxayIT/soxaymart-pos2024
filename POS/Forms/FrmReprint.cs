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
    public partial class FrmReprint : Form
    {
        public FrmMain frm;
        RMSDataSet ds = new RMSDataSet();
        RePrintInvoiceTableAdapter tbRePrint = new RePrintInvoiceTableAdapter();
        public FrmReprint(FrmMain frms)
        {
            InitializeComponent();
            frm = frms;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        decimal amt = 0;
        private void EnterValue(object e, EventArgs ev)
        {
            Button b = (Button)e;
            txtAmount.Text += b.Text;
            if (txtAmount.TextLength > 0)
            {
                amt = decimal.Parse(txtAmount.Text.Replace(",", ""));
            }
            txtAmount.Text = amt.ToString("N0");
        }
        private void FrmReprint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rMSDataSet.RePrintInvoice' table. You can move, or remove it, as needed.
            try
            {
                this.tbRePrint.Fill(ds.RePrintInvoice);
                dtp.Value = DateTime.Now;
            }
            catch { }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            if (radioDate.Checked == true)
            {
                Grids.DataSource = this.tbRePrint.GetDataByDate(dtp.Value.ToString());
            }
            else if (radioDateMoney.Checked == true)
            {
                if (txtAmount.Text == "")
                {
                    return;
                }
                Grids.DataSource = this.tbRePrint.GetDataByDateAmount(dtp.Value.ToString(), decimal.Parse(txtAmount.Text.Replace(",", "")));
            }
            else if (radioMoney.Checked == true)
            {
                if (txtAmount.Text == "")
                {
                    return;
                }
                Grids.DataSource = this.tbRePrint.GetDataByAmount(decimal.Parse(txtAmount.Text.Replace(",", "")));
            }
            else if (radioBill.Checked == true)
            {
                if (txtAmount.Text == "")
                {
                    return;
                }
                Grids.DataSource = this.tbRePrint.GetDataBySaleID(int.Parse(txtAmount.Text.Replace(",", "")));
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            Grids.DataSource = this.tbRePrint.GetDataByDate(DateTime.Now.ToString());
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (Grids.Rows.Count == 0)
            {
                return;
            }
            FrmBillDetail FrmBill = new FrmBillDetail(frm);
            FrmBill.SaleID = (int)Grids.CurrentRow.Cells[saleidDataGridViewTextBoxColumn.Name].Value;
            FrmBill.SaleNO = (int)Grids.CurrentRow.Cells[salenoDataGridViewTextBoxColumn.Name].Value;
            FrmBill.Emp = Grids.CurrentRow.Cells[fullnameDataGridViewTextBoxColumn.Name].Value.ToString();
            FrmBill.CTime = Grids.CurrentRow.Cells[opendateDataGridViewTextBoxColumn.Name].Value.ToString();
            FrmBill.prints = true;
            FrmBill.ShowDialog();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            string s = txtAmount.Text;
            if (s.Length == 1)
            {
                txtAmount.Clear();
                return;
            }
            else if (s.Length > 1)
            {
                s = s.Replace(",", "");
                s = s.Substring(0, s.Length - 1);
                txtAmount.Text = decimal.Parse(s).ToString("N0");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
