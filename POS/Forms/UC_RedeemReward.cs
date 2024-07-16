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
    public partial class UC_RedeemReward : UserControl
    {
        FrmMain frm;
        RMSDataSet ds = new RMSDataSet();
        UC_Reward uC_Reward;
        SaleService saleService = new SaleService();
        RedeemService redeemService = new RedeemService();
        ospos_freeitemTableAdapter tbFreeItem = new ospos_freeitemTableAdapter();
        ospos_freeitemconditionTableAdapter tbFreeItemCond = new ospos_freeitemconditionTableAdapter();
        ospos_product_itemTableAdapter tbProductItem = new ospos_product_itemTableAdapter();
        ospos_sale_detailsTableAdapter tbSaleDetail = new ospos_sale_detailsTableAdapter();
        public UC_RedeemReward(UC_Reward rw, FrmMain fm)
        {
            InitializeComponent();
            frm = fm;
            uC_Reward = rw;
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            insertReward();
        }
        public void EnterNumber(object sender, EventArgs e)
        {
            txtBarcode.Focus();
            Button btn = (Button)sender;
            txtBarcode.Text += btn.Text;
            txtBarcode.Select(txtBarcode.TextLength, 0);
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
            txtBarcode.Focus();
            txtBarcode.Select(txtBarcode.TextLength, 0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string s = txtBarcode.Text;
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                txtBarcode.Text = s;
            }
            txtBarcode.Focus();
            txtBarcode.Select(txtBarcode.TextLength, 0);
        }

        private void insertReward()
        {
            decimal ItemValue = 0;
            this.tbFreeItemCond.FillBy(ds.ospos_freeitemcondition, txtBarcode.Text);
            if (ds.ospos_freeitemcondition.Rows.Count > 0)
            {
                ItemValue = (decimal)ds.ospos_freeitemcondition.Rows[0][ds.ospos_freeitemcondition.pointsColumn];
                if ((frm.MemberPoints - frm.PointUsed) >= ItemValue)
                {
                    frm.PointUsed += ItemValue;
                    if (frm.isOpenBill)
                    {
                        insertDetails(ItemValue);
                    }
                    else
                    {
                        frm.SaleNO = saleService.GetSaleNO();
                        frm.SaleID = saleService.GetSaleID();
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
                            fk_member_id = null,
                            points = 0,
                            total_points = 0,
                            margin_points = frm.Margin_Point,
                            interfacestatus = "T",
                        };
                        saleService.InsertSale(sale);
                        insertDetails(ItemValue);
                        frm.isOpenBill = true;
                    }
                }
                else
                {
                    FrmDialogOK.Show("Your point not enough", "Wanning");
                }
            }
            else
            {
                FrmDialogOK.Show("Not Found Product", "Wanning");
            }
            ds.Dispose();
            uC_Reward.LoadPoints();
            txtBarcode.Text = "";
            frm.LoadList();
        }

        private void insertDetails(decimal point)
        {
            string prodName = "", barcode = "";
            int prodID, qtypeice;
            this.tbProductItem.FillByBarcode(ds.ospos_product_item, txtBarcode.Text);
            if (ds.ospos_product_item.Rows.Count > 0)
            {
                prodID = (int)ds.ospos_product_item.Rows[0][ds.ospos_product_item.idColumn];
                prodName = ds.ospos_product_item.Rows[0][ds.ospos_product_item.nameColumn].ToString();
                barcode = ds.ospos_product_item.Rows[0][ds.ospos_product_item.barcodeColumn].ToString();
                qtypeice = (int)ds.ospos_product_item.Rows[0][ds.ospos_product_item.quantityColumn];
            }
            else
            {
                FrmDialogOK.Show("Not Found Product", "Wanning");
                return;
            }

            //INSERT INTO CHECKDETAILS
            int detailSeq = (int)tbSaleDetail.GetDetailSeqForFreeitem(prodID, frm.SaleID);
            if (detailSeq > 0)
            {
                tbSaleDetail.UpdateAddQtyForFreeitem(1, frm.SaleID, detailSeq);
            }
            else
            {
                SaleDetailModel saleDetail = new SaleDetailModel
                {
                    sale_id = frm.SaleID,
                    sale_detailseq = saleService.CreateDetailSeq(frm.SaleID),
                    sale_datetime = DateTime.Now,
                    fk_product_item_id = prodID,
                    product_item_name = prodName,
                    qty_peice = qtypeice,
                    item_qty = 1,
                    item_price = 0,
                    item_vat = 0,
                    item_discount = 0,
                    item_netprice = 0,
                    item_costprice = 0,
                    item_priceorigin = 0,
                    item_status = "O",
                    promo_type = "Reward",
                    interfacestatus = "T"
                };
                saleService.InsertSaleDetail(saleDetail);
            }

            //INSERT INTO OSPOS_FREEITEM
            this.tbFreeItem.GetCheckItem(ds.ospos_freeitem, prodID, frm.SaleID);
            if (ds.ospos_freeitem.Rows.Count >= 1)
            {
                redeemService.UpdateQtyFreeItem(frm.SaleID, prodID, 1);
            }
            else
            {
                FreeItemModel freeItem = new FreeItemModel
                {
                    sale_id = frm.SaleID,
                    free_seq = redeemService.CreateFreeSeq(frm.SaleID),
                    sale_detailseq = saleService.GetDetailSeqForFreeItem(prodID, frm.SaleID),
                    sale_datetime = DateTime.Now,
                    fk_product_item_id = prodID,
                    barcode = barcode,
                    product_item_name = prodName,
                    item_status = "O",
                    item_qty = 1,
                    item_price = 0,
                    points = point,
                    interfacestatus = "T"
                };
                redeemService.InsertFreeItem(freeItem);
            }
            ds.Dispose();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                insertReward();
            }
            uC_Reward.LoadPoints();
        }
    }
}
