using POS.ClassControl;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using System;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace POS
{
    public partial class FrmAddQty : Form
    {
        FrmMain frm { get; set; }
        bool isAdjust = false;    
        RMSDataSet ds = new RMSDataSet();
        SaleService saleService = new SaleService();

        ospos_sale_detailsTableAdapter tbSaleDetail = new ospos_sale_detailsTableAdapter();
        public FrmAddQty()
        {
            InitializeComponent();
        }
        public FrmAddQty(FrmMain frms)
        {
            InitializeComponent();
            frm = frms;
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtQty.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EnterQty(object e)
        {
            var b = (Button)e;
            if (isAdjust)
            {
                txtQty.Text += b.Text;
            }
            else
            {
                txtQty.Text = b.Text;
                isAdjust = true;
            }

        }
        private void button29_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            EnterQty(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int distance;
            
            if (txtQty.TextLength > 3)
            {
                FrmDialogOK.Show("", "Warning!");
                txtQty.Text = "";
                txtQty.Focus();
                return;
            }
            if (txtQty.Text != null && int.TryParse(txtQty.Text, out distance) && int.Parse(txtQty.Text) > 0)
            {
                decimal qty = decimal.Parse(txtQty.Text);
                if (decimal.Parse(txtQty.Text) < frm.ItemQty)
                {
                    if (frm.Role == "10004" || frm.Role == "10005" || frm.Role == "10003")
                    {
                        FrmDialogOK.Show("You Dont Have Permission !!", "Warnning");
                        return;
                    }
                    if (frm.Role != "10004" && frm.Role != "10005" && frm.Role != "99999")
                    {
                        FrmConfirmPass con = new FrmConfirmPass(frm, 4);
                        con.ShowDialog();
                        if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                        {
                            return;
                        }
                        frm.Permission = "";
                        con.Dispose();
                    }
                }
                this.tbSaleDetail.FillByDetailSeq(ds.ospos_sale_details, frm.SaleID, frm.DetailSeq);
                int prodID = (int)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.fk_product_item_idColumn];
                decimal price = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_priceColumn];
                decimal costPrice = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_costpriceColumn];
                
                decimal point = saleService.Points(price, costPrice, 0) * qty;
                decimal vat = saleService.CalVat(price) * qty;

                this.tbSaleDetail.UpdateQty(qty, vat, point, frm.SaleID, frm.DetailSeq);

                frm.PromotionService(prodID);
                frm.LoadList();
                frm.CheckQuantity(prodID);
                ds.Dispose();
                this.Close();
            }
            else
            {
                FrmDialogOK.Show("Please Enter Number","");
            }
        }

        private void FrmAddQty_Load(object sender, EventArgs e)
        {

            txtQty.Text = Convert.ToString(frm.ItemQty); 
            txtQty.SelectAll();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            txtQty.MaxLength = 3;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
