using Newtonsoft.Json;
using POS.ClassControl;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS.Services
{
    public class SyncData
    {
        ospos_saleTableAdapter tbSale = new ospos_saleTableAdapter();
        ospos_sale_refundTableAdapter tbSaleRefund = new ospos_sale_refundTableAdapter();
        ospos_sale_detailsTableAdapter tbDetail = new ospos_sale_detailsTableAdapter();
        ospos_sale_refund_detailsTableAdapter tbRefundDetail = new ospos_sale_refund_detailsTableAdapter();
        ospos_sale_paymentsTableAdapter tbPayment = new ospos_sale_paymentsTableAdapter();
        ospos_member_pointsTableAdapter tbMemberPoints = new ospos_member_pointsTableAdapter();
        ospos_freeitemTableAdapter tbFreeitem = new ospos_freeitemTableAdapter();
        ospos_companyTableAdapter tbCompany = new ospos_companyTableAdapter();

        public void syncAllData(string baseUrl, int storeId, string token)
        {
            try
            {
                Ping myPing = new Ping();
                String host = "8.8.8.8";
                byte[] buffer = new byte[32];
                int timeout = 3000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                if (reply.Status == IPStatus.Success)
                {
                    Task.Run(() => UploadSale(baseUrl, storeId, token));
                    Task.Run(() => UploadSaleRefund(baseUrl, storeId, token));
                    Task.Run(() => UploadSaleDetail(baseUrl, storeId, token));
                    Task.Run(() => UploadSaleRefundDetail(baseUrl, storeId, token));
                    Task.Run(() => UploadPayment(baseUrl, storeId, token));
                    Task.Run(() => UploadMemberPoints(baseUrl, storeId, token));
                    Task.Run(() => UploadFreeitem(baseUrl, storeId, token));
                }
            }
            catch (Exception ex)
            {
                FrmDialogOK.Show("Cannot Connect to Server", "Error");
            }
        }
        public void UploadSale(string baseUrl, int storeId, string token)
        {
            RMSDataSet ds = new RMSDataSet();
            ds.EnforceConstraints = false;
            var saleList = new List<SaleModel>();

            tbSale.FillForUpload(ds.ospos_sale);
            foreach (RMSDataSet.ospos_saleRow item in ds.ospos_sale.Rows)
            {
                SaleModel sale = new SaleModel
                {
                    sale_id = item.sale_id,
                    sale_no = item.sale_no,
                    fk_sale_channel_id = item.fk_sale_channel_id,
                    receipt_no = item.receipt_no,
                    fk_terminal_id = item.fk_terminal_id,
                    fk_user_id = item.fk_user_id,
                    sale_status = item.sale_status,
                    opendate = item.opendate,
                    closedate = item.closedate,
                    subtotal_amount = item.subtotal_amount,
                    discount_amount = item.discount_amount,
                    vat_amount = item.vat_amount,
                    netprice_amount = item.netprice_amount,
                    cost_amount = item.cost_amount,
                    remark = item.remark,
                    lastupdate = item.lastupdate,
                    close_terminal_id = item.close_terminal_id,
                    close_user_id = item.close_user_id,
                    fk_member_id = item.fk_member_id,
                    points = item.points,
                    total_points = item.total_points,
                    margin_points = item.margin_points,
                    interfacestatus = item.interfacestatus,
                };
                saleList.Add(sale);
            }
            if (ds.ospos_sale.Rows.Count > 0)
            {
                try
                {
                    Uri url = new UriBuilder(baseUrl + "/api/sale?loc=" + storeId).Uri;
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Headers.Add("Authorization", "Bearer " + token);
                    httpWebRequest.Method = "POST";
                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        string jsonString = JsonConvert.SerializeObject(saleList);
                        streamWriter.Write(jsonString);
                    }
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                    }
                    if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        foreach (RMSDataSet.ospos_saleRow item in ds.ospos_sale.Rows)
                        {
                            tbSale.UpdateInterfaceStatus("F", item.sale_id);
                        }
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
            ds.Dispose();
        }

        public void UploadSaleRefund(string baseUrl, int storeId, string token)
        {
            RMSDataSet ds = new RMSDataSet();
            ds.EnforceConstraints = false;
            var saleRefundList = new List<SaleRefundModel>();

            tbSaleRefund.FillForUpload(ds.ospos_sale_refund);
            foreach (RMSDataSet.ospos_sale_refundRow item in ds.ospos_sale_refund.Rows)
            {
                SaleRefundModel salerefund = new SaleRefundModel
                {
                    sale_refund_seq = item.sale_refund_seq,
                    sale_id = item.sale_id,
                    sale_no = item.sale_no,
                    fk_sale_channel_id = item.fk_sale_channel_id,
                    receipt_no = item.receipt_no,
                    fk_user_id_approve = item.fk_user_id_approve,
                    fk_user_id_refund = item.fk_user_id_refund,
                    fk_terminal_id = item.fk_terminal_id,
                    fk_user_id = item.fk_user_id,
                    sale_status = item.sale_status,
                    refund_datetime = item.refund_datetime,
                    opendate = item.opendate,
                    closedate = item.closedate,
                    subtotal_amount = item.subtotal_amount,
                    discount_amount = item.discount_amount,
                    vat_amount = item.vat_amount,
                    netprice_amount = item.netprice_amount,
                    cost_amount = item.cost_amount,
                    remark = item.remark,
                    lastupdate = item.lastupdate,
                    close_terminal_id = item.close_terminal_id,
                    close_user_id = item.close_user_id,
                    fk_member_id = item.fk_member_id,
                    points = item.points,
                    total_points = item.total_points,
                    margin_points = item.margin_points,
                    interfacestatus = item.interfacestatus,
                };
                saleRefundList.Add(salerefund);
            }
            if (ds.ospos_sale_refund.Rows.Count > 0)
            {
                try
                {
                    Uri url = new UriBuilder(baseUrl + "/api/sale_Refund?loc=" + storeId).Uri;
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Headers.Add("Authorization", "Bearer " + token);
                    httpWebRequest.Method = "POST";
                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        string jsonString = JsonConvert.SerializeObject(saleRefundList);
                        streamWriter.Write(jsonString);
                    }
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                    }
                    if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        foreach (RMSDataSet.ospos_sale_refundRow item in ds.ospos_sale_refund.Rows)
                        {
                            tbSaleRefund.UpdateInterFaceStatus("F", item.sale_id);
                        }
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
            ds.Dispose();
        }
        public void UploadSaleDetail(string baseUrl, int storeId, string token)
        {
            RMSDataSet ds = new RMSDataSet();
            ds.EnforceConstraints = false;

            tbDetail.FillForUpload(ds.ospos_sale_details);
            foreach (RMSDataSet.ospos_sale_detailsRow item in ds.ospos_sale_details.Rows)
            {
                SaleDetailModel saleDetail = new SaleDetailModel
                {
                    sale_id = item.sale_id,
                    sale_detailseq = item.sale_detailseq,
                    sale_datetime = item.sale_datetime,
                    fk_product_item_id = item.fk_product_item_id,
                    product_item_name = item.product_item_name,
                    item_qty = item.item_qty,
                    qty_peice = item.qty_peice,
                    item_price = item.item_price,
                    item_vat = item.item_vat,
                    item_discount = item.item_discount,
                    item_netprice = item.item_netprice,
                    item_costprice = item.item_costprice,
                    item_priceorigin = item.item_priceorigin,
                    item_status = item.item_status,
                    fk_promo_dis_id = item.fk_promo_dis_id,
                    fk_promo_free_id = item.fk_promo_free_id,
                    promo_type = item.promo_type,
                    points = item.points,
                    interfacestatus = item.interfacestatus,
                };

                try
                {
                    Uri url = new UriBuilder(baseUrl + "/api/sale_detail?loc=" + storeId).Uri;
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Headers.Add("Authorization", "Bearer " + token);
                    httpWebRequest.Method = "POST";
                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        string jsonString = JsonConvert.SerializeObject(saleDetail);
                        streamWriter.Write(jsonString);
                    }
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                    }
                    if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        tbDetail.UpdateInterfaceStatus("F", item.sale_id);
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
            ds.Dispose();
        }
        public void UploadSaleRefundDetail(string baseUrl, int storeId, string token)
        {
            RMSDataSet ds = new RMSDataSet();
            ds.EnforceConstraints = false;

            tbRefundDetail.FillForUpload(ds.ospos_sale_refund_details);
            foreach (RMSDataSet.ospos_sale_refund_detailsRow item in ds.ospos_sale_refund_details.Rows)
            {
                SaleRefundDetailModel saleRefundDetail = new SaleRefundDetailModel
                {
                    sale_refund_seq = item.sale_refund_seq,
                    sale_id = item.sale_id,
                    sale_detailseq = item.sale_detailseq,
                    refund_datetime = item.refund_datetime,
                    sale_datetime = item.sale_datetime,
                    fk_terminal_id = item.fk_terminal_id,
                    fk_user_id_refund = item.fk_user_id_refund,
                    fk_user_id_approve = item.fk_user_id_approve,
                    fk_product_item_id = item.fk_product_item_id,
                    product_name = item.product_name,
                    item_qty = item.item_qty,
                    qty_peice = item.qty_peice,
                    item_price = item.item_price,
                    item_vat = item.item_vat,
                    item_discount = item.item_discount,
                    item_netprice = item.item_netprice,
                    item_costprice = item.item_costprice,
                    item_priceorigin = item.item_priceorigin,
                    item_status = item.item_status,
                    fk_promo_dis_id = item.fk_promo_dis_id,
                    fk_promo_free_id = item.fk_promo_free_id,
                    promo_type = item.promo_type,
                    remark = item.remark,
                    points = item.points,
                    interfacestatus = item.interfacestatus,
                };

                try
                {
                    Uri url = new UriBuilder(baseUrl + "/api/sale_RefundDetail?loc=" + storeId).Uri;
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Headers.Add("Authorization", "Bearer " + token);
                    httpWebRequest.Method = "POST";
                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        string jsonString = JsonConvert.SerializeObject(saleRefundDetail);
                        streamWriter.Write(jsonString);
                    }
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                    }
                    if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        tbRefundDetail.UpdateInterFaceStatus("F", item.sale_id);
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
            ds.Dispose();
        }
        public void UploadPayment(string baseUrl, int storeId, string token)
        {
            RMSDataSet ds = new RMSDataSet();
            ds.EnforceConstraints = false;
            var paymentList = new List<SalePaymentModel>();

            tbPayment.FillForUpload(ds.ospos_sale_payments);
            foreach (RMSDataSet.ospos_sale_paymentsRow item in ds.ospos_sale_payments.Rows)
            {
                SalePaymentModel payment = new SalePaymentModel
                {
                    sale_id = item.sale_id,
                    paymentseq = item.paymentseq,
                    payment_datetime = item.payment_datetime,
                    fk_payment_method_id = item.fk_payment_method_id,
                    payment_value = item.payment_value,
                    payment_receive = item.payment_receive,
                    payment_change = item.payment_change,
                    fk_terminal_id = item.fk_terminal_id,
                    fk_user_id = item.fk_user_id,
                    interfacestatus = item.interfacestatus,
                };
                paymentList.Add(payment);
            }
            if (ds.ospos_sale_payments.Rows.Count > 0)
            {
                try
                {
                    Uri url = new UriBuilder(baseUrl + "/api/payments?loc=" + storeId).Uri;
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Headers.Add("Authorization", "Bearer " + token);
                    httpWebRequest.Method = "POST";
                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        string jsonString = JsonConvert.SerializeObject(paymentList);
                        streamWriter.Write(jsonString);
                    }
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                    }
                    if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        foreach (RMSDataSet.ospos_sale_paymentsRow item in ds.ospos_sale_payments.Rows)
                        {
                            tbPayment.UpdateInterfaceStatus("F", item.paymentseq, item.sale_id);
                        }
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
            ds.Dispose();
        }
        public void UploadMemberPoints(string baseUrl, int storeId, string token)
        {
            RMSDataSet ds = new RMSDataSet();
            ds.EnforceConstraints = false;
            var memberList = new List<MemberPointModel>();

            tbMemberPoints.FillForUpload(ds.ospos_member_points);
            foreach (RMSDataSet.ospos_member_pointsRow item in ds.ospos_member_points.Rows)
            {
                MemberPointModel member = new MemberPointModel
                {
                    id = item.id,
                    fk_member_id = item.fk_member_id,
                    fk_sale_id = item.fk_sale_id,
                    item_cost = item.item_cost,
                    net_amount = item.net_amount,
                    points = item.points,
                    saledate = item.saledate,
                    type = item.type,
                    sale_status = item.sale_status,
                    interfacestatus = item.interfacestatus,
                };
                memberList.Add(member);
            }
            if (ds.ospos_member_points.Rows.Count > 0)
            {
                try
                {
                    Uri url = new UriBuilder(baseUrl + "/api/memberpoints?loc=" + storeId).Uri;
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Headers.Add("Authorization", "Bearer " + token);
                    httpWebRequest.Method = "POST";
                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        string jsonString = JsonConvert.SerializeObject(memberList);
                        streamWriter.Write(jsonString);
                    }
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                    }
                    if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        foreach (RMSDataSet.ospos_member_pointsRow item in ds.ospos_member_points.Rows)
                        {
                            tbMemberPoints.UpdateInterfaceStatus("F", item.id);
                        }
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
            ds.Dispose();
        }
        public void UploadFreeitem(string baseUrl, int storeId, string token)
        {
            RMSDataSet ds = new RMSDataSet();
            ds.EnforceConstraints = false;
            var freeitemList = new List<FreeItemModel>();

            tbFreeitem.FillForUpload(ds.ospos_freeitem);
            foreach (RMSDataSet.ospos_freeitemRow item in ds.ospos_freeitem.Rows)
            {
                FreeItemModel freeitem = new FreeItemModel
                {
                    sale_id = item.sale_id,
                    free_seq = item.free_seq,
                    sale_detailseq = item.sale_detailseq,
                    sale_datetime = item.sale_datetime,
                    fk_product_item_id = item.fk_product_item_id,
                    barcode = item.barcode,
                    product_item_name = item.product_item_name,
                    item_status = item.item_status,
                    item_qty = item.item_qty,
                    item_price = item.item_price,
                    points = item.points,
                    interfacestatus = item.interfacestatus,
                };
                freeitemList.Add(freeitem);
            }
            if (ds.ospos_member_points.Rows.Count > 0)
            {
                try
                {
                    Uri url = new UriBuilder(baseUrl + "/api/freeitem?loc=" + storeId).Uri;
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Headers.Add("Authorization", "Bearer " + token);
                    httpWebRequest.Method = "POST";
                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        string jsonString = JsonConvert.SerializeObject(freeitemList);
                        streamWriter.Write(jsonString);
                    }
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                    }
                    if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        foreach (RMSDataSet.ospos_freeitemRow item in ds.ospos_freeitem.Rows)
                        {
                            tbFreeitem.UpdateInterfaceStatus("F", item.sale_id);
                        }
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
            ds.Dispose();
        }
    }
}
