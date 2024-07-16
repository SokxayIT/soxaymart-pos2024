using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class MemberPointModel
    {
        public int id { get; set; }
        public int fk_member_id { get; set; }
        public int fk_sale_id { get; set; }
        public decimal item_cost { get; set; }
        public decimal net_amount { get; set; }
        public decimal points { get; set; }
        public DateTime saledate { get; set; }
        public string type { get; set; }
        public string sale_status { get; set; }
        public string interfacestatus { get; set; }
    }
}
