using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class SaleQtyModel
    {
        public int BarId { get; set; }
        public decimal TotalQty { get; set; }
        public string MenuItemID { get; set; }
    }
}
