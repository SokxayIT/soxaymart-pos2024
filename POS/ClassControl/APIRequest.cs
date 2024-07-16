using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.ClassControl
{
    public class APIRequest
    {
        public int usercardId { get; set; }
        public int shopId { get; set; }
        public DateTime billDate { get; set; }
        public string billNumber { get; set; }
        public decimal Amount { get; set; }
        public int point { get; set; }
        public int currencyId { get; set; }
        public string referenceNo { get; set; }
        public string remark { get; set; }
        public int accountType { get; set; }
        public int createdById { get; set; }
        public int updatedById { get; set; }
    }
    public class APIRespone
    {
        public string resultCode { get; set; }
        public string resultMessage { get; set; }
        public string billNumber { get; set; }
        public int cardTypeId { get; set; }
    }
    public class PaymentRequest
    {
        public string Passkey { get; set; }
        public string DigitalSignature { get; set; }
        public string billNumber { get; set; }
    }
    public class OTPRequest
    {
        public string Passkey { get; set; }
        public string DigitalSignature { get; set; }
        public string UserName { get; set; }
    }
    public class OTPRespone
    {
        public string resultCode { get; set; }
        public string resultMessage { get; set; }
        public string otpReturn { get; set; }
        public int userId { get; set; }
    }
}
