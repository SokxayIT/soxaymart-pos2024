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
    public partial class UC_ButtonDiscount : UserControl
    {
        public UC_ButtonDiscount()
        {
            InitializeComponent();
        }
        string _DiscountID,_Dispay, _DiscountName, _DiscountType, _Status = null;
        decimal _DiscountAmount;
        public string DiscountID {
            get { return _DiscountID; }
            set { _DiscountID = value; }
        }
        public string DiscountName
        {
            get { return _DiscountName; }
            set
            {
                _DiscountName = value;
            }
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        public string DisplayText
        {
            get { return _Dispay; }
            set { _Dispay = value; btnDis.Text = value; }
        }
        public string DiscountType
        {
            get { return _DiscountType; }
            set { _DiscountType = value; }
        }
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public decimal DiscountAmount
        {
            get { return _DiscountAmount; }
            set { _DiscountAmount = value; }
        }
        public UC_ButtonDiscount(string disID,string disName,string disType,string status,decimal amount)
        {
            InitializeComponent();
            this.DiscountID = disID;
            this.DiscountName = disName;
            this.DiscountType = disType;
            this.Status = status;
            this.DiscountAmount = amount;
        }
    }
}
