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
    public partial class FrmQRPayment : Form
    {
        public int PaymnetType = 0;
        public FrmQRPayment()
        {
            InitializeComponent();
        }

        private void btnOnePay_Click(object sender, EventArgs e)
        {
            lbDiaplayName.Text = "One Pay";
            PaymnetType = 1;
        }

        private void btnECard_Click(object sender, EventArgs e)
        {
            lbDiaplayName.Text = "Sokxay All E-Card";
            PaymnetType = 2;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (PaymnetType == 0)
            {
                FrmDialogOK.Show("Please Select Payment Type", "Warning");
            }
            else
            {
                this.Close();
            }
        }

        private void btnCanCel_Click(object sender, EventArgs e)
        {
            PaymnetType = 0;
            this.Close();
        }
    }
}
