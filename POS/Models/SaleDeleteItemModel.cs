using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class SaleDeleteItemModel
    {
        public int sale_id { get; set; }
        public int seq { get; set; }
        public int sale_detail_seq { get; set; }
        public DateTime delete_datetime { get; set; }
        public int sale_no { get; set; }
        public string fk_terminal_id { get; set; }
        public string fk_user_id { get; set; }
        public DateTime sale_date_time { get; set; }
        public int fk_product_item_id { get; set; }
        public string product_name { get; set; }
        public decimal item_qty { get; set; }
        public decimal qty_peice { get; set; }
        public decimal item_price { get; set; }
        public decimal item_vat { get; set; }
        public decimal item_discount { get; set; }
        public decimal item_netprice { get; set; }
        public decimal item_priceorigin { get; set; }
        public string item_status { get; set; }
        public string promo_type { get; set; }
        public int fk_promo_free_id { get; set; }
        public int fk_promo_dis_id { get; set; }
        public string remark { get; set; }
        public string interfacestatus { get; set; }
    }
}
