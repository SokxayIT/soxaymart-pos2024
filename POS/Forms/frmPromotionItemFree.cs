using POS.ClassControl;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace POS
{
    public partial class frmPromotionItemFree : Form
    {
        FrmMain frm;
        RMSDataSet ds = new RMSDataSet();
        SaleService saleService = new SaleService();
        PromotionsTableAdapter tbPromotion = new PromotionsTableAdapter();
        ospos_sale_detailsTableAdapter tbSaleDetail = new ospos_sale_detailsTableAdapter();
        ospos_product_itemTableAdapter tbProductItem = new ospos_product_itemTableAdapter();
        public frmPromotionItemFree(FrmMain frmMains)
        {
            InitializeComponent();
            frm = frmMains;
        }
        public frmPromotionItemFree()
        {
            InitializeComponent();
        }
        private void frmPromotionItemFree_Load(object sender, EventArgs e)
        {
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void GridItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridItem.CurrentRow.Cells[c_check.Name].Value = !bool.Parse(GridItem.CurrentRow.Cells[c_check.Name].Value.ToString());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in GridItem.Rows)
            {
                int promoID = (int)item.Cells[this.promo_id.Name].Value;
                int freeID = (int)item.Cells[this.c_id.Name].Value;
                string prodName = item.Cells[this.c_name.Name].Value.ToString();
                string proType = item.Cells[this.c_type.Name].Value.ToString();
                decimal qty = (decimal)item.Cells[this.c_qty.Name].Value;
                int qty_peice = (int)item.Cells[this.qty_peice.Name].Value;

                tbPromotion.GetNotFreeProd(ds.Promotions, (int)item.Cells[this.promo_id.Name].Value);
                //tbSaleDetail.FillByPromoFreeitem(ds.ospos_sale_details, frm.SaleID, freeID, promoID);
                //if (ds.ospos_sale_details.Rows.Count > 0)
                //{
                //    int detailSeq = (int)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.sale_detailseqColumn];
                //    if ((int)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.fk_promo_free_idColumn] == promoID && detailSeq > 0)
                //    {
                //        saleService.UpdateAddQty(frm.SaleID, detailSeq, 1, 0, 0);
                //    }
                //}
                //else
                //{
                    SaleDetailModel detail = new SaleDetailModel
                    {
                        sale_id = frm.SaleID,
                        sale_detailseq = saleService.CreateDetailSeq(frm.SaleID),
                        sale_datetime = DateTime.Now,
                        fk_product_item_id = freeID,
                        product_item_name = prodName,
                        qty_peice = qty_peice,
                        item_qty = qty,
                        item_price = 0,
                        item_vat = 0,
                        item_discount = 0,
                        item_netprice = 0,
                        item_costprice = 0,
                        item_priceorigin = 0,
                        item_status = "O",
                        fk_promo_dis_id = 0,
                        fk_promo_free_id = promoID,
                        promo_type = proType,
                        points = 0,
                        interfacestatus = "T",
                    };
                    saleService.InsertSaleDetail(detail);
                //}
                SaleDetailModel saleDetail = new SaleDetailModel
                {
                    sale_id = frm.SaleID,
                    fk_product_item_id = (int)ds.Promotions.Rows[0][ds.Promotions.product_idColumn],
                    fk_promo_free_id = promoID,
                    promo_type = proType,
                };
                saleService.UpdatePromoFree(saleDetail);
            }
            frm.LoadList();
            ds.Dispose();
            this.Close();
        }

        private void GridItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
