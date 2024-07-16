using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forms
{
    public partial class FrmVoid : Form
    {
        public FrmMain frm;
        public FrmVoid(FrmMain frms)
        {
            InitializeComponent();
            frm = frms;
        }
        
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
               
                FrmVoiceCheck frmVoice = new FrmVoiceCheck(frm);
                frmVoice.ShowDialog();
                frmVoice.Dispose();
                Close();
                frm.txtsearch.Focus();
                frm.txtsearch.Select(frm.txtsearch.TextLength, 0);
            }
            else if (radioButton2.Checked == true)
            {
               
                FrmRefundItem frmrefund= new FrmRefundItem(frm);
                frmrefund.ShowDialog();
                frmrefund.Dispose();
                Close();
                frm.txtsearch.Focus();
                frm.txtsearch.Select(frm.txtsearch.TextLength, 0);
                


            }
            else
            {
                FrmDialogOK.Show("ກະລຸນາເລືອກປະເພດການຍົກເລີກ", "");
                return;
            }
    
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton2.Enabled = false;
        }

        private void FrmVoid_Load(object sender, EventArgs e)
        {
           //radioButton1.Checked = true;
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton1.Enabled = false;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
