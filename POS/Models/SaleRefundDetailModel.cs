using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class SaleRefundDetailModel
    {
        public int sale_refund_seq { get; set; }
        public int sale_id { get; set; }
        public int sale_detailseq { get; set; }
        public DateTime refund_datetime { get; set; }
        public DateTime sale_datetime { get; set; }
        public string fk_user_id_refund { get; set; }
        public string fk_user_id_approve { get; set; }
        public string fk_terminal_id { get; set; }
        public int fk_product_item_id { get; set; }
        public string product_name { get; set; }
        public decimal item_qty { get; set; }
        public decimal qty_peice { get; set; }
        public decimal item_price { get; set; }
        public decimal item_vat { get; set; }
        public decimal item_discount { get; set; }
        public decimal item_netprice { get; set; }
        public decimal item_costprice { get; set; }
        public decimal item_priceorigin { get; set; }
        public string item_status { get; set; }
        public int fk_promo_dis_id { get; set; }
        public int fk_promo_free_id { get; set; }
        public string promo_type { get; set; }
        public decimal points { get; set; }
        public string remark { get; set; }
        public string interfacestatus { get; set; }
    }
}
