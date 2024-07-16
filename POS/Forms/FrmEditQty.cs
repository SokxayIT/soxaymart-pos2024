using POS.ClassControl;
using POS.Models.RMSDataSetTableAdapters;
using System;
using POS.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading;

namespace POS.Forms
{
    public partial class FrmEditQty : Form
    {
        //public FrmMain frm;
        //Form frm;
        
        public  FrmBillDetailRefund frmss;

        //public static FrmBillDetailRefund frmbdrf;
        public int SaleID { get; set; }
        public int SaleSeqDetail { get; set; }
        public int itemid { get; set; }

        public decimal SaleQty { get; set; }

        SaleService saleService = new SaleService();
        ospos_sale_refund_detailsTableAdapter tbSaleRefundDetail = new ospos_sale_refund_detailsTableAdapter();
        ospos_temp_sale_refund_detailTableAdapter tbTempSaleRefundDetail = new ospos_temp_sale_refund_detailTableAdapter();
        public FrmEditQty(FrmBillDetailRefund frms)
        {
            InitializeComponent();
            frmss = frms;
           
        }
        public FrmEditQty()
        {
            InitializeComponent();

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtQty.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmEditQty_Load(object sender, EventArgs e)
        {
           
            txtQty.SelectAll();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            txtQty.MaxLength = 3;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            decimal qty = decimal.Parse(txtQty.Text);
            if (SaleQty < qty)
            {
                FrmDialogOK.Show("ຈຳນວນທີ່ຕ້ອງການຍົກເລີກຫຼາຍກ່ອນໃນລະບົບ!!!", "Warnning");
                txtQty.Clear();
                txtQty.Focus();
            }
            else if (qty <= 0)
            {
                FrmDialogOK.Show("ກະລຸນາປ້ອນຈຳນວນ!!!", "Warnning");
                txtQty.Clear();
                txtQty.Focus();
            }
            else 
            {
                //this.tbTempSaleRefundDetail.UpdateTempSaleRefundDetailQty(qty, SaleID, SaleSeqDetail, itemid);
               
                Close();
            }
            frmss.LoadList();

        }
        private void EnterNumber(object e)
        {
            Button b = (Button)e;
            txtQty.Text += b.Text;
        }
        private void Number_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            string s = txtQty.Text;
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                txtQty.Text = s;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
