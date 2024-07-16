using Microsoft.PointOfService;
using Microsoft.ReportingServices.Diagnostics.Internal;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows;

namespace POS.ClassControl
{
    public class SaleService
    {
        FrmMain frm;

        ospos_sale_detailsTableAdapter tbSaleDetail = new ospos_sale_detailsTableAdapter();
        ospos_saleTableAdapter tbSale = new ospos_saleTableAdapter();
        ospos_sale_deleteitemTableAdapter tbDeleteItem = new ospos_sale_deleteitemTableAdapter();
        ospos_sale_paymentsTableAdapter tbSalePayment = new ospos_sale_paymentsTableAdapter();
        ospos_pointsconditionTableAdapter tbPointcond = new ospos_pointsconditionTableAdapter();
        ospos_member_pointsTableAdapter tbMemberPoints = new ospos_member_pointsTableAdapter();
        ospos_sale_delete_paymentsTableAdapter tbDeletePayment = new ospos_sale_delete_paymentsTableAdapter();
        ospos_payment_methodTableAdapter tbPaymentMethod = new ospos_payment_methodTableAdapter();
        ospos_product_itemTableAdapter tbProductItem = new ospos_product_itemTableAdapter();
        ospos_taxTableAdapter tbTax = new ospos_taxTableAdapter();
        ospos_storeTableAdapter tbStore = new ospos_storeTableAdapter();
        ospos_usersTableAdapter tbuser = new ospos_usersTableAdapter();
        ospos_sale_refundTableAdapter tbSaleRefunds = new ospos_sale_refundTableAdapter();
        ospos_sale_refund_detailsTableAdapter tbSaleRefundDetail = new ospos_sale_refund_detailsTableAdapter();
        ospos_temp_sale_refundTableAdapter tbTempSaleRefunds = new ospos_temp_sale_refundTableAdapter();
        ospos_temp_sale_refund_detailTableAdapter tbTempSaleRefundDetail = new ospos_temp_sale_refund_detailTableAdapter();
        //GET METHOD
        public int GetStoreID()
        {
            int id = (int)tbStore.GetStoreID();
            return id;
        }
        public int GeTax()
        {
            int tax = (int)tbTax.GetTax();
            return tax;
        }
        public int GetMargin()
        {
            int margin = (int)tbPointcond.GetMargin();
            return margin;
        }
        public int GetSaleNO()
        {
            int saleNo = (int)tbSale.GenSaleNO();
            return saleNo;
        }
        public string GetPaymentName(int paymentID)
        {
            string name = tbPaymentMethod.GetPaymentName(paymentID);
            return name;
        }
        public int GetSaleID()
        {
            int saleId = (int)tbSale.GenMaxSaleID();
            return saleId;
        }
        public int GetDetailSeq(int proId, int saleId)
        {
            int detailSeq = (int)tbSaleDetail.GetDetailSeq(proId, saleId);
            return detailSeq;
        }
        public int GetDetailSeqForFreeItem(int proId, int saleId)
        {
            int detailSeq = (int)tbSaleDetail.GetDetailSeqForFreeitem(proId, saleId);
            return detailSeq;
        }
        public string GetProdName(int proId)
        {
            string name = tbProductItem.GetName(proId).ToString();
            return name;
        }

        //GENERATE METHOD
        public int CreatePaymentSeq(int saleId)
        {
            int paymentSeq = (int)tbSalePayment.GenPaymentSeq(saleId);
            return paymentSeq;
        }
        public int CreateDetailSeq(int saleId)
        {
            int detailSeq = (int)tbSaleDetail.GenDetailSeq(saleId);
            return detailSeq;
        }
        public int CreateDeleteSeq(int saleId)
        {
            int delSeq = (int)tbDeleteItem.GenSeq(saleId);
            return delSeq;
        }
        public int CreateDeletePaymentSeq(int saleId)
        {
            int delSeq = (int)tbDeletePayment.GenSeq(saleId);
            return delSeq;
        }

        //CALCULATE METHOD
        public decimal CalVat(decimal value)
        {
            int tax = GeTax();
            decimal vat = value * tax / (100 + tax);
            return vat;
        }
        public decimal CalCostPrice(int id)
        {
            decimal price = (decimal)tbSaleDetail.SumCostPrice(id);
            return price;
        }
        public decimal SUMPoints(int id)
        {
            decimal points = (decimal)tbSaleDetail.SumPoints(id);
            return points;
        }
        public decimal SUMPaymentReceipt(int id)
        {
            decimal receipt = (decimal)tbSalePayment.SUMReceipt(id);
            return receipt;
        }
        public decimal Points(decimal netprice, decimal costprice, decimal discount)
        {
            decimal points = 0;
            decimal margin = (int)tbPointcond.GetMargin();
            if (discount <= 0 && netprice > costprice && costprice > 0 && costprice != 0)
            {
                points = ((netprice - costprice) *( margin/10) / 100);
                return points;
            }
            return points;

        }

        //INSERT DATA METHOD
        public void InsertSaleDetail(SaleDetailModel saleDetail)
        {
            try
            {
                tbSaleDetail.InsertSaleDetail(saleDetail.sale_id, saleDetail.sale_detailseq, saleDetail.sale_datetime, saleDetail.fk_product_item_id, saleDetail.product_item_name,
                    saleDetail.item_qty, saleDetail.qty_peice, saleDetail.item_price, saleDetail.item_vat, saleDetail.item_discount, saleDetail.item_netprice, saleDetail.item_costprice, saleDetail.item_priceorigin, saleDetail.item_status,
                    saleDetail.fk_promo_dis_id, saleDetail.fk_promo_free_id, saleDetail.promo_type, saleDetail.points, saleDetail.interfacestatus);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void InsertSale(SaleModel sale)
        {
            try
            {
                tbSale.InsertSale(sale.sale_id, sale.sale_no, sale.fk_sale_channel_id, sale.receipt_no, sale.fk_terminal_id.ToString(), sale.fk_user_id, sale.sale_status, sale.opendate, sale.closedate,
                    sale.subtotal_amount, sale.discount_amount, sale.vat_amount, sale.netprice_amount, sale.cost_amount, sale.remark, sale.lastupdate, sale.close_terminal_id,
                    sale.close_user_id, sale.fk_member_id, sale.points, sale.total_points, sale.margin_points, sale.interfacestatus);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void InsertSalePayment(SalePaymentModel salePayment)
        {
            try
            {
                tbSalePayment.InsertSalePayment(salePayment.sale_id, salePayment.paymentseq, salePayment.payment_datetime, salePayment.fk_payment_method_id,
                    salePayment.payment_value, salePayment.payment_receive, salePayment.payment_change, salePayment.fk_terminal_id, salePayment.fk_user_id,
                    salePayment.interfacestatus);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void InsertMemberPoint(MemberPointModel memberPoint)
        {
            try
            {
                tbMemberPoints.InsertQuery(memberPoint.fk_member_id, memberPoint.fk_sale_id, memberPoint.item_cost, memberPoint.net_amount, memberPoint.points,
                    memberPoint.saledate, memberPoint.type, memberPoint.sale_status, memberPoint.interfacestatus);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void InsertDeleteProductItem(SaleDeleteItemModel saleDeleteItem)
        {
            try
            {
                tbDeleteItem.InsertSaleDeleteItem(saleDeleteItem.sale_id, saleDeleteItem.seq, saleDeleteItem.sale_detail_seq, saleDeleteItem.delete_datetime, saleDeleteItem.sale_no,
                            saleDeleteItem.fk_terminal_id, saleDeleteItem.fk_user_id, saleDeleteItem.sale_date_time, saleDeleteItem.fk_product_item_id, saleDeleteItem.product_name, saleDeleteItem.item_qty,
                            saleDeleteItem.qty_peice, saleDeleteItem.item_price, saleDeleteItem.item_vat, saleDeleteItem.item_discount, saleDeleteItem.item_netprice, saleDeleteItem.item_priceorigin, saleDeleteItem.item_status,
                            saleDeleteItem.promo_type, saleDeleteItem.fk_promo_free_id, saleDeleteItem.fk_promo_dis_id, saleDeleteItem.remark, saleDeleteItem.interfacestatus);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void InsertDeletePayment(SaleDeletePaymentModel saleDeletePayment)
        {
            try
            {
                tbDeletePayment.InsertDeletePayment(saleDeletePayment.sale_id, saleDeletePayment.seq, saleDeletePayment.delete_datetime, saleDeletePayment.sale_no, saleDeletePayment.fk_terminal_id,
                    saleDeletePayment.fk_user_id, saleDeletePayment.paymentseq, saleDeletePayment.payment_datetime, saleDeletePayment.fk_payment_method_id, saleDeletePayment.payment_name,
                            saleDeletePayment.payment_value, saleDeletePayment.payment_receive, saleDeletePayment.payment_change, saleDeletePayment.remark, saleDeletePayment.interfacestatus);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void InsertSaleRefund(SaleRefundModel SaleRefund)
        {
            try
            {
                tbSaleRefunds.InsertSaleRefund(SaleRefund.sale_id, SaleRefund.sale_no, SaleRefund.fk_sale_channel_id,
                SaleRefund.receipt_no, SaleRefund.fk_terminal_id.ToString(), SaleRefund.fk_user_id_approve,
                SaleRefund.fk_user_id_refund, SaleRefund.fk_user_id, SaleRefund.sale_status, SaleRefund.refund_datetime, SaleRefund.opendate,
                SaleRefund.closedate, SaleRefund.subtotal_amount, SaleRefund.discount_amount, SaleRefund.vat_amount,
                SaleRefund.netprice_amount, SaleRefund.cost_amount, SaleRefund.remark, SaleRefund.lastupdate,
                SaleRefund.close_terminal_id, SaleRefund.close_user_id, SaleRefund.fk_member_id, SaleRefund.points,
                SaleRefund.total_points, SaleRefund.margin_points, SaleRefund.interfacestatus);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void InsertSaleRefundDetail(SaleRefundDetailModel SaleRefundDetail)
        {
            try
            {
                tbSaleRefundDetail.InsertSaleRefundDetail(SaleRefundDetail.sale_id, SaleRefundDetail.sale_detailseq, SaleRefundDetail.refund_datetime, 
                    SaleRefundDetail.sale_datetime, SaleRefundDetail.fk_terminal_id.ToString(), SaleRefundDetail.fk_user_id_refund, SaleRefundDetail.fk_user_id_approve,
                    SaleRefundDetail.fk_product_item_id, SaleRefundDetail.product_name,SaleRefundDetail.item_qty, SaleRefundDetail.qty_peice, SaleRefundDetail.item_costprice,
                    SaleRefundDetail.item_price, SaleRefundDetail.item_vat, SaleRefundDetail.item_discount, SaleRefundDetail.item_netprice, SaleRefundDetail.item_priceorigin, 
                    SaleRefundDetail.item_status,SaleRefundDetail.fk_promo_dis_id, SaleRefundDetail.fk_promo_free_id, SaleRefundDetail.promo_type, SaleRefundDetail.points,
                    SaleRefundDetail.remark, SaleRefundDetail.interfacestatus);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void InsertselectSaleRefund(string sale_refund_seq, string fk_terminal_id,string fk_user_id_approve,string fk_user_id_refund,int saleid)
        {
            try
            {
                tbSaleRefunds.InsertSelectSaleRefund(sale_refund_seq,fk_terminal_id, fk_user_id_approve, fk_user_id_refund, saleid);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void InsertselectSaleRefundDetail(string sale_refund_seq, string fk_terminal_id,string remark, string fk_user_id_approve, string fk_user_id_refund, int saleid)
        {
            try
            {
                tbSaleRefundDetail.InsertSelectSaleRefundDetails(sale_refund_seq, fk_terminal_id,remark, fk_user_id_approve, fk_user_id_refund, saleid);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void InsertRefundProduct(string sale_refund_seq, string fk_terminal_id, string remark, string fk_user_id_approve, string fk_user_id_refund, int saleid,int prodid)
        {
            try
            {
                tbSaleRefundDetail.InsertRefundDetail(sale_refund_seq, fk_terminal_id, remark, fk_user_id_approve, fk_user_id_refund, saleid, prodid);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void InsertTempSaleRefund(int saleid)
        {
            try
            {
                tbTempSaleRefunds.InsertTempSaleRefund(saleid);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void InsertTempSaleRefundDetail(int saleid)
        {
            try
            {
                tbTempSaleRefundDetail.InsertTempSaleRefundDetail(saleid);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void InsertTempSaleRefundProduct(int saleid,int proid)
        {
            try
            {
                tbTempSaleRefundDetail.InsertTempSaleRefundProduct(saleid, proid);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        //UPDATE METHOD
        public void UpdateAddQty(int saleID, int detailseq, decimal qty, decimal vat, decimal point)
        {
            try
            {
                tbSaleDetail.UpdateAddQty(qty, vat, point, saleID, detailseq);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdateQty(int saleID, int detailseq, decimal qty, decimal vat, decimal point)
        {
            try
            {
                tbSaleDetail.UpdateQty(qty, vat, point, saleID, detailseq);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdateDiscount(SaleDetailModel saleDetail)
        {
            try
            {
                tbSaleDetail.UpdateDiscount(saleDetail.item_discount, saleDetail.fk_promo_dis_id, saleDetail.fk_promo_free_id, saleDetail.promo_type, saleDetail.points, saleDetail.sale_id, saleDetail.sale_detailseq);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdateSaleStatus(int id, string status, string remark, string infStatus)
        {
            try
            {
                tbSale.UpdateStatus(status, remark, infStatus, id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdateSaleDetailStatus(int id, string status, string infStatus)
        {
            try
            {
                tbSaleDetail.UpdateStatus(status, infStatus, id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdateMemberPointStatus(int id, string status, string infStatus)
        {
            try
            {
                tbMemberPoints.UpdateStatus(status, infStatus, id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdateSaleValues(SaleModel sale)
        {
            try
            {
                tbSale.UpdateSaleValues(sale.subtotal_amount, sale.discount_amount, sale.vat_amount, sale.netprice_amount, sale.cost_amount, sale.sale_id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdateCloseSale(SaleModel sale)
        {
            try
            {
                tbSale.UpdateCloseSale(sale.sale_status, sale.closedate, sale.lastupdate, sale.close_terminal_id, sale.close_user_id,
                    sale.fk_member_id, sale.points, sale.total_points, sale.remark, sale.interfacestatus, sale.sale_id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdatePromoPrice(SaleDetailModel saleDetail)
        {
            try
            {
                tbSaleDetail.UpdatePromoPrice(saleDetail.item_price, saleDetail.item_discount, saleDetail.item_netprice, saleDetail.fk_promo_dis_id, saleDetail.fk_promo_free_id, saleDetail.promo_type, saleDetail.points,
                    saleDetail.sale_id, saleDetail.fk_product_item_id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdatePromoDis(SaleDetailModel saleDetail)
        {
            try
            {
                tbSaleDetail.UpdatePromotionDiscount(saleDetail.item_discount, saleDetail.fk_promo_dis_id, saleDetail.fk_promo_free_id, saleDetail.promo_type, saleDetail.points,
                    saleDetail.sale_id, saleDetail.fk_product_item_id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdatePromoFree(SaleDetailModel saleDetail)
        {
            try
            {
                tbSaleDetail.UpdatePromoFree(saleDetail.fk_promo_free_id, saleDetail.promo_type, saleDetail.points, saleDetail.sale_id, saleDetail.fk_product_item_id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdatePriceOnline(int saleid,int seqid, decimal item_price, decimal item_qty,decimal item_vat,decimal points,decimal item_priceorigin)
        {
            try
            {
                tbSaleDetail.UpdatePriceOnline(item_price, item_vat, points, item_qty, item_priceorigin, saleid, seqid);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void updatestatusonline(string status,string userid)
        {
            try
            {
                tbuser.UpdateStatusOnline(status, userid);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdateSaleValuesByPayonline(decimal subtotal_amount,decimal discount_amount,decimal vat_amount,decimal netprice_amount,decimal cost_amount,int sale_id)
        {
            try
            {
                tbSale.UpdateSaleValues(subtotal_amount, discount_amount, vat_amount,netprice_amount, cost_amount, sale_id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //DELETE METHOD
        public void DeleteItemSaleDetail(int saleID, int detailSeq)
        {
            try
            {
                tbSaleDetail.DeleteSaleDetail(saleID, detailSeq);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void DeletePayment(int saleID, int detailSeq)
        {
            try
            {
                tbSalePayment.DeletePayment(saleID, detailSeq);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void DeletePromotionItem(int saleID, int promoID, int freeID)
        {
            try
            {
                tbSaleDetail.DeletePromoFreeItem(saleID, promoID, freeID);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void DeleteTempSaleRefund(int saleID)
        {
            try
            {
                tbTempSaleRefunds.DeleteSaleID(saleID);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void DeleteTempSaleRefundDetail(int saleID)
        {
            try
            {
                tbTempSaleRefundDetail.DeleteSaleID(saleID);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


    }
}
