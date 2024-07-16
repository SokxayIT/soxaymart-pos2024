using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class UC_Credit : UserControl
    {
        string _paymentID, _paymentName;
        int _typeid;
        Image Images;
        public UC_Credit()
        {
            InitializeComponent();
        }
        public string PaymentID
        {
            get { return _paymentID; }
            set { _paymentID = value; }
        }
        public int TypeID
        {
            get { return _typeid; }
            set { _typeid = value; }
        }
        public string PaymentName
        {
            get { return _paymentName; }
            set { _paymentName = value; }
        }
        public Image PaymentImage
        {
            get { return Images; }
            set { Images = value; this.button1.BackgroundImage = value; }
        }
        public UC_Credit(string id, Image im, string pname,int type)
        {
            InitializeComponent();
            PaymentID = id;
            PaymentName = pname;
            PaymentImage = im;
            TypeID = type;
            if (PaymentImage == null)
            {
                button1.Text = pname;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
