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
    public partial class FrmDialogOK : Form
    {
        static FrmDialogOK Msg; static DialogResult result;
        public FrmDialogOK()
        {
            InitializeComponent();
        }
        public static DialogResult Show(string Text,string Caption)
        {
            Msg = new FrmDialogOK();
            Msg.lbCaption.Text = Caption;
            Msg.lbMsg.Text = Text;
            Msg.StartPosition = FormStartPosition.CenterScreen;
            Msg.ShowDialog();            
            return result;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;Msg.Close();
        }
    }
}
