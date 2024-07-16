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

namespace POS.Forms
{
    public partial class FrmUnitSize : Form
    {
        FrmMain frm;
        SaleDetailModel saleDetailModel;
        SaleService saleService = new SaleService();

        ospos_product_itemTableAdapter tbProductItem = new ospos_product_itemTableAdapter();
        public FrmUnitSize(FrmMain fm, SaleDetailModel model)
        {
            InitializeComponent();
            this.frm = fm;
            saleDetailModel = model;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            RMSDataSet ds = new RMSDataSet();
            int pid = 0;
            decimal item_qty = 0, qty_piece = 0, item_price = 0, item_cost = 0, vat = 0, points = 0;
            string pname = "";

            pname = dataGridView.CurrentRow.Cells[prodName.Name].Value.ToString();
            pid = (int)dataGridView.CurrentRow.Cells[id.Name].Value;
            item_qty = (decimal)dataGridView.CurrentRow.Cells[qty.Name].Value;
            qty_piece = Convert.ToDecimal(dataGridView.CurrentRow.Cells[size.Name].Value);
            item_price = (decimal)dataGridView.CurrentRow.Cells[price.Name].Value;
            item_cost = (decimal)dataGridView.CurrentRow.Cells[cost.Name].Value;
            vat = saleService.CalVat(item_price);
            points = saleService.Points(item_price, item_cost, 0);
            int detailSeq = saleService.GetDetailSeq(pid, frm.SaleID);

            SaleDetailModel detail = new SaleDetailModel
            {
                sale_id = frm.SaleID,
                sale_detailseq = saleService.CreateDetailSeq(frm.SaleID),
                sale_datetime = DateTime.Now,
                fk_product_item_id = pid,
                product_item_name = pname,
                item_qty = item_qty,
                qty_peice = qty_piece,
                item_price = item_price,
                item_vat = vat,
                item_discount = 0,
                item_netprice = item_price * item_qty,
                item_costprice = item_cost,
                item_priceorigin = item_price * item_qty,
                item_status = "O",
                promo_type = " ",
                points = points,
                interfacestatus = "T",
            };

            if (detailSeq > 0)
            {
                saleService.UpdateAddQty(frm.SaleID, detailSeq, item_qty, vat, points);
            }
            else
            {
                saleService.InsertSaleDetail(detail);
            }
            frm.PromotionService(detail.fk_product_item_id);

            if (saleDetailModel.item_qty * saleDetailModel.qty_peice - (item_qty * qty_piece) > 0)
            {
                int unit = (int)tbProductItem.ScalarQueryUnit(saleDetailModel.fk_product_item_id);
                ds.Dispose();
                if(unit == 3)
                {
                    decimal left_qty = saleDetailModel.item_qty * saleDetailModel.qty_peice - (item_qty * qty_piece);
                    SaleDetailModel saleDetail = new SaleDetailModel
                    {
                        sale_id = saleDetailModel.sale_id,
                        sale_detailseq = saleService.CreateDetailSeq(saleDetailModel.sale_id),
                        sale_datetime = DateTime.Now,
                        fk_product_item_id = saleDetailModel.fk_product_item_id,
                        product_item_name = saleDetailModel.product_item_name,
                        item_qty = left_qty,
                        qty_peice = saleDetailModel.qty_peice,
                        item_price = saleDetailModel.item_price,
                        item_vat = saleService.CalVat(saleDetailModel.item_price),
                        item_discount = 0,
                        item_netprice = saleDetailModel.item_price * left_qty,
                        item_costprice = saleDetailModel.item_costprice,
                        item_priceorigin = saleDetailModel.item_priceorigin,
                        item_status = saleDetailModel.item_status,
                        promo_type = saleDetailModel.promo_type,
                        points = saleService.Points(saleDetailModel.item_netprice, saleDetailModel.item_costprice, saleDetailModel.item_discount),
                        interfacestatus = saleDetailModel.interfacestatus,
                    };

                    int seq = saleService.GetDetailSeq(saleDetailModel.fk_product_item_id, frm.SaleID);

                    if (seq > 0)
                    {
                        saleService.UpdateAddQty(frm.SaleID, seq, left_qty, saleService.CalVat(saleDetailModel.item_price), saleService.Points(saleDetailModel.item_price, saleDetailModel.item_costprice, 0));
                    }
                    else
                    {
                        saleService.InsertSaleDetail(saleDetail);
                    }
                    frm.PromotionService(saleDetail.fk_product_item_id);
                }
                else if (unit == 2)
                {
                    decimal left_qty = (((saleDetailModel.item_qty * saleDetailModel.qty_peice) - (item_qty * qty_piece))/( saleDetailModel.qty_peice));
                    SaleDetailModel saleDetail = new SaleDetailModel
                    {
                        sale_id = saleDetailModel.sale_id,
                        sale_detailseq = saleService.CreateDetailSeq(saleDetailModel.sale_id),
                        sale_datetime = DateTime.Now,
                        fk_product_item_id = saleDetailModel.fk_product_item_id,
                        product_item_name = saleDetailModel.product_item_name,
                        item_qty = left_qty,
                        qty_peice = saleDetailModel.qty_peice,
                        item_price = saleDetailModel.item_price,
                        item_vat = saleService.CalVat(saleDetailModel.item_price),
                        item_discount = 0,
                        item_netprice = saleDetailModel.item_price * left_qty,
                        item_costprice = saleDetailModel.item_costprice,
                        item_priceorigin = saleDetailModel.item_priceorigin,
                        item_status = saleDetailModel.item_status,
                        promo_type = saleDetailModel.promo_type,
                        points = saleService.Points(saleDetailModel.item_netprice, saleDetailModel.item_costprice, saleDetailModel.item_discount),
                        interfacestatus = saleDetailModel.interfacestatus,
                    };

                    int seq = saleService.GetDetailSeq(saleDetailModel.fk_product_item_id, frm.SaleID);

                    if (seq > 0)
                    {
                        saleService.UpdateAddQty(frm.SaleID, seq, left_qty, saleService.CalVat(saleDetailModel.item_price), saleService.Points(saleDetailModel.item_price, saleDetailModel.item_costprice, 0));
                    }
                    else
                    {
                        saleService.InsertSaleDetail(saleDetail);
                    }
                    frm.PromotionService(saleDetail.fk_product_item_id);
                }else
                {

                }
                
            }
            frm.LoadList();
            this.Close();
        }
    }
}
