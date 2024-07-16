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
    public partial class FrmVoiceCheck : Form
    {
        int checkseq;
        int saleid;
        int saleIDDetail;
        public FrmMain frm;
        ospos_saleTableAdapter tbSale = new ospos_saleTableAdapter();
        ospos_sale_refundTableAdapter tbSaleRefunds = new ospos_sale_refundTableAdapter();
        ospos_sale_refund_detailsTableAdapter tbSaleRefundDetail = new ospos_sale_refund_detailsTableAdapter();
        public FrmVoiceCheck(FrmMain frms)
        {
            InitializeComponent();
            frm = frms;
        }
        private void btnclr_Click(object sender, EventArgs e)
        {
            txtCheckNo.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            string s = txtCheckNo.Text;
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                txtCheckNo.Text = s;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EnterNumber(object e)
        {
            Button b = (Button)e;
            txtCheckNo.Text += b.Text;
        }
        private void Number_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            saleid = (int)tbSaleRefunds.GetSaleID(int.Parse(txtCheckNo.Text));
            saleIDDetail = (int)tbSaleRefundDetail.GetSaleID(int.Parse(txtCheckNo.Text));
            if (saleid == 0 && saleIDDetail== 0)
            {
                checkseq = (int)tbSale.GetSaleIDBySaleNO(int.Parse(txtCheckNo.Text));
                if (checkseq == 0)
                {
                    FrmDialogOK.Show("Not Found Check", "Warnning");
                    txtCheckNo.Clear();
                    txtCheckNo.Focus();
                }
                else
                {
                    FrmBillDetail detail = new FrmBillDetail(frm);
                    detail.prints = false;
                    detail.CancleBill = true;
                    detail.SaleID = checkseq;
                    detail.ShowDialog();
                    detail.Dispose();
                    Close();
                }
            }
            else
            {
                FrmDialogOK.Show("ໃບບິນມີການຍົກເລີກແລ້ວ!!!", "Warnning");
            }
       
        }

        private void txtCheckNo_TextChanged(object sender, EventArgs e)
        {
            txtCheckNo.MaxLength = 11;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmVoiceCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
