using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace POS
{
    public partial class QRPay : Form
    {
        public QRPay()
        {
            InitializeComponent();
        }
        public string qrs { get; set; }
        private void QRPay_Load(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(qrs, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            picQR.Image = code.GetGraphic(5);
        }
    }
}
