using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using POS.ClassControl;
using System.Threading;
using POS.Models.RMSDataSetTableAdapters;

namespace POS
{
    public partial class FrmMonitor : Form
    {
        public FrmMain frm;
        public FrmMonitor(FrmMain fm)
        {
            InitializeComponent();
            frm = fm;
        }
        //new
        public int SaleID = 0, SaleNO = 0;
        public decimal SubTotal = 0, Total = 0, Discount = 0, Receipt = 0;
        public string emp;
        public bool disImage = false;
        LogError er = new LogError();

        SaleService saleFunction = new SaleService();

        SellListTableAdapter tbSellList = new SellListTableAdapter();
        CurrencyTableAdapter tbCurrency = new CurrencyTableAdapter();
        public void LoadList()
        {
            WindowState = FormWindowState.Maximized;
            if (this.SaleID != 0)
            {
                gridItem.DataSource = tbSellList.GetData(SaleID);
            }
            else
            {
                gridItem.DataSource = null;
            }
            gridItem.ClearSelection();
            GrandTotal();
            if (gridItem.Rows.Count > 0)
            {
                gridItem.FirstDisplayedScrollingRowIndex = gridItem.RowCount - 1;
            }
            DispCash();
        }
        public void GrandTotal()
        {
            Receipt = 0;
            decimal total = 0, discount = 0;
            foreach (DataGridViewRow row in gridItem.Rows)
            {
                if (row.Cells[sortbyDataGridViewTextBoxColumn.Name].Value.ToString() == "1")
                {
                    total += decimal.Parse(row.Cells[totalDataGridViewTextBoxColumn.Name].Value.ToString());
                    discount += decimal.Parse(row.Cells[itemdiscountDataGridViewTextBoxColumn.Name].Value.ToString());
                }
                else if (row.Cells[sortbyDataGridViewTextBoxColumn.Name].Value.ToString() == "2")
                {
                    total += decimal.Parse(row.Cells[totalDataGridViewTextBoxColumn.Name].Value.ToString());
                    discount += decimal.Parse(row.Cells[itemdiscountDataGridViewTextBoxColumn.Name].Value.ToString());
                }
                else if (row.Cells[sortbyDataGridViewTextBoxColumn.Name].Value.ToString() == "3")
                {
                    Receipt += decimal.Parse(row.Cells[totalDataGridViewTextBoxColumn.Name].Value.ToString());
                }
            }
            SubTotal = total + discount;
            Total = total;
            Discount = Math.Abs(discount);
            lbBil.Text = SaleNO.ToString();
            lbSubtotal.Text = (SubTotal).ToString("N0");
            lbDiscount.Text = discount.ToString("N0").Replace("-", string.Empty);
            lbVat.Text = saleFunction.CalVat(SubTotal).ToString("N0");
            lbAmount.Text = (total).ToString("N0");
            lbCash.Text = Receipt.ToString("N0");
            Total = total;
        }
        public void DispCash()
        {
            if (Receipt >= Total)
            {
                lbChange.Text = (Total - Receipt).ToString("N0").Replace("-", string.Empty);
            }
            else
            {
                lbChange.Text = "0";
            }

        }
        string[] ImgName = null;
        int i = 0;
        private void FrmMonitor_Load(object sender, EventArgs e)
        {
            LoadImage();
            lbTitleVat.Text = ("ອມພ " + saleFunction.GeTax() + "%");
            decimal thb = (decimal)tbCurrency.getTHB();
            decimal usd = (decimal)tbCurrency.getUSD();
            lbTHB.Text = thb.ToString("N2");
            lbUSD.Text = usd.ToString("N2");

        }
        public void LoadImage()
        {
            timerChangeImage.Start();
            lbEmp.Text = emp;
            try
            {
                ImgName = Directory.GetFiles(@"c:\image\", "*");
            }
            catch (Exception)
            {
            }
        }

        private void gridItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerChangeImage.Interval = 3000;
            if (ImgName != null)
            {
                if (ImgName.Length > 0)
                {
                    if (i >= ImgName.Length)
                    {
                        i = 0;
                    }
                    try
                    {
                        if (disImage == false)
                        {
                            PicPromotion.Image.Dispose();
                            PicPromotion.Image = Image.FromFile(ImgName[i]);
                        }
                    }
                    catch (OutOfMemoryException ex)
                    {
                        er.NewError(ex.Message, "Change Image");
                    }
                    i++;
                }
            }
            else
            {
                try
                {
                    if (disImage == false)
                    {
                        PicPromotion.Image.Dispose();
                        PicPromotion.Image = Properties.Resources.empty_grocery_store;
                    }
                }
                catch (OutOfMemoryException ex)
                {
                    er.NewError(ex.Message, "Change Image");
                }
            }

        }

        private void PicPromotion_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbVat_Click(object sender, EventArgs e)
        {

        }
    }
}
