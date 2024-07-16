using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class SaleModel
    {
        public int sale_id { get; set; }
        public int sale_no { get; set; }
        public int fk_sale_channel_id { get; set; }
        public string receipt_no { get; set; }
        public string fk_terminal_id { get; set; }
        public string fk_user_id { get; set; }
        public string sale_status { get; set; }
        public DateTime opendate { get; set; }
        public DateTime? closedate { get; set; }
        public decimal subtotal_amount { get; set; }
        public decimal discount_amount { get; set; }
        public decimal vat_amount { get; set; }
        public decimal netprice_amount { get; set; }
        public decimal cost_amount { get; set; }
        public string remark { get; set; }
        public DateTime? lastupdate { get; set; }
        public string close_terminal_id { get; set; }
        public string close_user_id { get; set; }
        public int? fk_member_id { get; set; }
        public decimal? points { get; set; }
        public decimal? total_points { get; set; }
        public int? margin_points { get; set; }
        public string interfacestatus { get; set; }
    }
}
