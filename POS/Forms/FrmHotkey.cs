using POS.ClassControl;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmHotkey : Form
    {
        FrmMain frm;

        RMSDataSet ds = new RMSDataSet();

        SaleService saleService = new SaleService();

        ospos_product_itemTableAdapter tbProductItem = new ospos_product_itemTableAdapter();
        ospos_hotkeyTableAdapter tbHotkey = new ospos_hotkeyTableAdapter();
        public FrmHotkey(FrmMain fm)
        {
            InitializeComponent();
            frm = fm;
        }

        private void FrmHotkey_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tbHotkey.Fill(ds.ospos_hotkey);
            foreach (RMSDataSet.ospos_hotkeyRow type in ds.ospos_hotkey)
            {
                TabPage tabPage = new TabPage(type.laoname);
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Dock = DockStyle.Fill;
                flowLayoutPanel.AutoScroll = true;

                UC_hotkey hotkey;
                this.tbProductItem.FillByHotkey(ds.ospos_product_item, (short?)type.id);
                foreach (RMSDataSet.ospos_product_itemRow item in ds.ospos_product_item)
                {

                    Image im = null;
                    try
                    {
                        if (item.immage != null)
                        {
                            if (!File.Exists(item.immage))
                            {
                                im = null;
                            }
                            else
                            {
                                im = Image.FromFile(item.immage);
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                    string size = ("1x" + item.quantity);
                    hotkey = new UC_hotkey(im, size);
                    hotkey.ItemID = item.id;
                    hotkey.Barcode = item.barcode;
                    hotkey.ItemName = item.name;
                    hotkey.QtyPiece = item.quantity;
                    hotkey.ItemPrice = item.price;
                    hotkey.CostPrice = item.custom_cost;
                    hotkey.Click += HotKeyClick;
                    flowLayoutPanel.Controls.Add(hotkey);
                }

                tabPage.Controls.Add(flowLayoutPanel);
                tabControl1.TabPages.Add(tabPage);
            }
        }
        private void HotKeyClick(object sender, EventArgs e)
        {
            UC_hotkey obj = (UC_hotkey)sender;
            if (frm.isOpenBill)
            {
                insertDetail(obj);
                frm.LoadList();
            }
            //Insert Check
            else
            {
                frm.SaleID = saleService.GetSaleID();
                frm.SaleNO = saleService.GetSaleNO();
                SaleModel sale = new SaleModel
                {
                    sale_id = frm.SaleID,
                    sale_no = frm.SaleNO,
                    fk_sale_channel_id = 1,
                    receipt_no = DateTime.Now.ToString("yyMMddhhmmss"),
                    fk_terminal_id = frm.TerminalID,
                    fk_user_id = frm.EmpID,
                    sale_status = "O",
                    opendate = DateTime.Now,
                    closedate = null,
                    subtotal_amount = frm.SubTotal,
                    discount_amount = frm.Discount,
                    vat_amount = saleService.CalVat(frm.SubTotal),
                    netprice_amount = frm.Total,
                    cost_amount = saleService.CalCostPrice(frm.SaleID),
                    remark = " ",
                    lastupdate = null,
                    close_terminal_id = null,
                    close_user_id = null,
                    fk_member_id = 0,
                    points = 0,
                    total_points = 0,
                    margin_points = saleService.GetMargin(),
                    interfacestatus = "T",
                };
                saleService.InsertSale(sale);
                Properties.Settings.Default.SaleID = frm.SaleID;
                Properties.Settings.Default.Save();
                frm.isOpenBill = true;
                insertDetail(obj);
                frm.LoadList();
            }
            frm.txtsearch.Clear();
            frm.txtsearch.Focus();
            ds.Dispose();
            this.Close();
        }
        private void insertDetail(UC_hotkey obj)
        {
            int prodID = obj.ItemID;
            decimal price = obj.ItemPrice;
            decimal costPrice = obj.CostPrice;
            decimal vat = saleService.CalVat(price);
            decimal point = saleService.Points(price, costPrice, 0);
            int dec = saleService.GetDetailSeq(obj.ItemID, frm.SaleID);
            string bar = obj.Barcode;
            if (dec > 0)
            {
                saleService.UpdateAddQty(frm.SaleID, dec, 1, vat, point);
            }
            else
            {
                SaleDetailModel detail = new SaleDetailModel
                {
                    sale_id = frm.SaleID,
                    sale_detailseq = saleService.CreateDetailSeq(frm.SaleID),
                    sale_datetime = DateTime.Now,
                    fk_product_item_id = obj.ItemID,
                    product_item_name = obj.ItemName,
                    qty_peice = obj.QtyPiece,
                    item_qty = 1,
                    item_price = price,
                    item_vat = vat,
                    item_discount = 0,
                    item_netprice = price,
                    item_costprice = costPrice,
                    item_priceorigin = price,
                    item_status = "O",
                    promo_type = " ",
                    points = point,
                    interfacestatus = "T",
                };
                saleService.InsertSaleDetail(detail);
            }
            frm.PromotionService(prodID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            ds.Dispose();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
