using POS.ClassControl;
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
    public partial class FrmDisountAmount : Form
    {
        FrmMain frm;
        RMSDataSet ds = new RMSDataSet();
        SaleService saleService = new SaleService();
        ospos_sale_detailsTableAdapter tbSaleDetail = new ospos_sale_detailsTableAdapter();
        public FrmDisountAmount()
        {
            InitializeComponent();
        }
        public FrmDisountAmount(FrmMain frmMain)
        {
            InitializeComponent();
            frm = frmMain;
        }
        decimal amt = 0;
        private void EnterQty(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtQty.Text += b.Text;
            if (txtQty.TextLength > 0)
            {
                amt = decimal.Parse(txtQty.Text.Replace(",", ""));
            }
            txtQty.Text = amt.ToString("N0");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            string s = txtQty.Text;
            if (s.Length == 1)
            {
                txtQty.Clear();
                return;
            }
            else if (s.Length > 1)
            {
                s = s.Replace(",", "");
                s = s.Substring(0, s.Length - 1);
                txtQty.Text = decimal.Parse(s).ToString("N0");
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtQty.Clear();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbSaleDetail.FillForCheckDiscount(ds.ospos_sale_details, frm.SaleID, frm.DetailSeq);
            if (ds.ospos_sale_details.Rows.Count > 0)
            {
                FrmDialogOK.Show("ບໍ່ສາມາດນຳໃຊ້ສ່ວນຫຼຸດ!!!", "Warning!");
                return;
            }
            if (txtQty.TextLength > 0)
            {
                if (frm.ItemValue <= decimal.Parse(txtQty.Text))
                {
                    FrmDialogOK.Show("Cannot Discount With This Value", "Warnning");
                    return;
                }

                if (frm.isDiscount)
                {
                    SaleDetailModel saleDetail = new SaleDetailModel
                    {
                        sale_id = frm.SaleID,
                        sale_detailseq = frm.DetailSeq,
                        item_discount = decimal.Parse(txtQty.Text),
                        fk_promo_dis_id = 0,
                        fk_promo_free_id = 0,
                        promo_type = "Discount by Amount",
                        points = 0
                    };
                    saleService.UpdateDiscount(saleDetail);

                    frm.isDiscount = false;
                    frm.LoadList();
                    this.Close();
                }
                else { FrmDialogOK.Show("Select Item To Discount", ""); }
            }
            ds.Dispose();
        }
    }
}
