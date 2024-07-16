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
    public partial class UC_ListBill : UserControl
    {
        public UC_ListBill()
        {
            InitializeComponent();
        }
        public UC_ListBill(int sid, int saleno, string emp, string paid, string start, string last)
        {
            InitializeComponent();
            this.SaleID = sid;
            this.SaleNO = saleno;
            this.EmpName = emp;
            this.btnName = "SaleNo: "+saleno.ToString() + Environment.NewLine +"EMP: "+ emp + Environment.NewLine +"Total: "+ paid +
                Environment.NewLine +"Open Time: "+ start + Environment.NewLine +"Close Time:"+ last;
            this._btnDate = start;
        }
        int saleID;
        int saleNO;
        string empName;
        string _name;
        Color _c,_fc;
        bool _bool;
        string _btnDate;
        public int SaleID
        {
            get { return saleID; }
            set { saleID = value; }
        }
        public int SaleNO
        {
            get { return saleNO; }
            set { saleNO = value; }
        }
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        public string btnName
        {
            get { return _name; }
            set { _name = value; btnBill.Text = value; }
        }
        public string btnDate
        {
            get { return _btnDate; }
            set { _btnDate = value; }
        }
        public Color btnCol
        {
            get { return _c; }
            set { _c = value; btnBill.BackColor = value; }
        }
        public Color btnfor
        {
            get { return _fc; }
            set { _fc = value;btnBill.ForeColor = value; }
        }
        public bool billcheck
        {
            get { return _bool; }
            set
            {
                _bool = value;
            }
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
