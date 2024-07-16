using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class SaleDeletePaymentModel
    {
        public int sale_id { get; set; }
        public int? seq { get; set; }
        public DateTime delete_datetime { get; set; }
        public int sale_no { get; set; }
        public string fk_terminal_id { get; set; }
        public string fk_user_id { get; set; }
        public int paymentseq { get; set; }
        public DateTime payment_datetime { get; set; }
        public int fk_payment_method_id { get; set; }
        public string payment_name { get; set; }
        public decimal payment_value { get; set; }
        public decimal payment_receive { get; set; }
        public decimal payment_change { get; set; }
        public string remark { get; set; }
        public string interfacestatus { get; set; }
    }
}
