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
    public partial class FrmReason : Form
    {
        public string ID; 
        public string Reason;
        public bool Check = false;
        //model models;
        public FrmReason()
        {
            InitializeComponent();
        }
        public FrmReason(string id)
        {
            InitializeComponent();
            ID = id;
 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Check = false;
            this.Close();
        }

        private void FrmResson_Load(object sender, EventArgs e)
        {
            //models = new model();
            //this.reasonTableAdapter1.Fill(models.Reason, ID);
            //Grids.DataSource = models.Reason;
            //models.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ID = Grids.CurrentRow.Cells[reasonIDDataGridViewTextBoxColumn.Name].Value.ToString();
            Reason = Grids.CurrentRow.Cells[reasonTextDataGridViewTextBoxColumn.Name].Value.ToString();
            Check = true;
            this.Close();
        }
    }
}
