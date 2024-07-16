using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class UC_hotkey : UserControl
    {
        Image Images;
        public Image PaymentImage
        {
            get { return Images; }
            set { Images = value; this.button1.BackgroundImage = value; }
        }
        public UC_hotkey(Image im, string size)
        {
            InitializeComponent();
            PaymentImage = im;
            this.ItemSize = size;
            if (PaymentImage == null)
            {
                button1.Text = "";
            }
        }
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }
        string _itemname = "";
        string itemsize = "";
        public int ItemID { get; set; }
        public int QtyPiece { get; set; }
        public string ItemSize { get => itemsize; set => itemsize = value; }
        public string ItemName
        {
            get => _itemname; 
            set
            {
                _itemname = value;
                button1.Text = _itemname + "\n" + itemsize;
                // button1.Text = value + Environment.NewLine + this.Barcode;
            }
        }
        public string Barcode { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal CostPrice { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
