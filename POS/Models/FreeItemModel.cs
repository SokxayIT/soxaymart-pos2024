using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class FreeItemModel
    {
        public int sale_id { get; set; }
        public int free_seq { get; set; }
        public int sale_detailseq { get; set; }
        public DateTime sale_datetime { get; set; }
        public int fk_product_item_id { get; set; }
        public string barcode { get; set; }
        public string product_item_name { get; set; }
        public string item_status { get; set; }
        public decimal item_qty { get; set; }
        public decimal item_price { get; set; }
        public decimal points { get; set; }
        public string interfacestatus { get; set; }
    }
}
