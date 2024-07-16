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
    public partial class frmDialogPay : Form
    {
        public frmDialogPay()
        {
            InitializeComponent();
        }
        public decimal total { set { lbtotal.Text = value.ToString("N0"); } }
        public decimal receipt { set { lbreceipt.Text = value.ToString("N0"); } }
        public decimal change { set { lbchange.Text = value.ToString("N0"); } }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbchange_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
