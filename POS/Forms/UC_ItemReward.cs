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
    public partial class UC_ItemReward : UserControl
    {
        Image Images;
        public UC_ItemReward(Image img)
        {
            InitializeComponent();
            ItemImage = img;
        }
        public Image ItemImage {
            get { return Images; }
            set { Images = value; this.pictureBox1.Image = value; }
        }
        string _itemName = "";
        public string ItemName
        {
            get => _itemName;
            set { _itemName = value; this.lbItemName.Text = value; }
        }
        decimal _point = 0;
        public decimal Point
        {
            get => _point;
            set { _point = value; this.lbPoint.Text = value.ToString("N0") + " " + "ຄະແນນ"; }
        }

        public int ItemId { get; set; }
    }
}
