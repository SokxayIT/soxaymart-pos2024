using POS.ClassControl;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace POS.Forms
{
    public partial class FrmRefundItem : Form
    {
        int checkseq;
        int saleid;
        int CheckSaleRefund;
        public FrmMain frm;
        SaleService saleService = new SaleService();
        ospos_saleTableAdapter tbSale = new ospos_saleTableAdapter();
        ospos_sale_refundTableAdapter tbSaleRefunds = new ospos_sale_refundTableAdapter();
        ospos_temp_sale_refundTableAdapter tbTempSaleRefunds = new ospos_temp_sale_refundTableAdapter();

        public FrmRefundItem(FrmMain frms)
        {
            InitializeComponent();
            frm = frms;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtCheckNoRefunditem.Text == null)
            {
                FrmDialogOK.Show("ກະລຸນາປ້ອນເລກບິນ!!!", "Warnning");
            }
            else 
            {
                CheckSaleRefund = (int)tbTempSaleRefunds.ScalarTempSaleRefund(int.Parse(txtCheckNoRefunditem.Text));
                if(CheckSaleRefund == 0)
                {
                    //saleid = (int)tbSaleRefunds.GetSaleID(int.Parse(txtCheckNoRefunditem.Text));
                    //if (saleid == 0)
                    //{
                        checkseq = (int)tbSale.GetSaleIDBySaleNO(int.Parse(txtCheckNoRefunditem.Text));
                        if (checkseq == 0)
                        {
                            FrmDialogOK.Show("Not Found Check", "Warnning");
                        }
                        else
                        {
                            saleService.InsertTempSaleRefund((int.Parse(txtCheckNoRefunditem.Text)));
                            //saleService.InsertTempSaleRefundDetail((int.Parse(txtCheckNoRefunditem.Text)));
                            FrmScanBarcode Frmbarcode = new FrmScanBarcode(frm, checkseq);
                            Frmbarcode.ShowDialog();
                            Frmbarcode.Dispose();
                            Close();

                        }

                    //}
                    //else
                    //{
                    //    FrmDialogOK.Show("ໃບບິນມີການຍົກເລີກແລ້ວ!!!", "Warnning");
                    //    txtCheckNoRefunditem.Clear();
                    //    txtCheckNoRefunditem.Focus();
                    //}
                }
                else
                {
                    FrmDialogOK.Show("ໃບບິນນີ້ມີ ທຸລະກຳ ຍົກເລີກລາຍການຄ້າງໄວ້ ກະລຸນາແຈ້ງໄອທິກວດສອບ!!!", "Warnning");
                    txtCheckNoRefunditem.Clear();
                    txtCheckNoRefunditem.Focus();
                }
                
            }
      
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EnterNumber(object e)
        {
            Button b = (Button)e;
            txtCheckNoRefunditem.Text += b.Text;
        }
        private void Number_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }
        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void FrmRefundItem_Load(object sender, EventArgs e)
        {
            txtCheckNoRefunditem.Focus();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            string s = txtCheckNoRefunditem.Text;
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                txtCheckNoRefunditem.Text = s;
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtCheckNoRefunditem.Clear();
        }

        private void txtCheckNoRefunditem_TextChanged(object sender, EventArgs e)
        {
            txtCheckNoRefunditem.MaxLength = 11;
        }
    }
}
