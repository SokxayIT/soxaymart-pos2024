using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class UC_Reward : UserControl
    {
        //model models = new model();
        bool _switch = false;
        FrmMain frm;
        public UC_RedeemReward uC_RedeemReward;
        RMSDataSet ds = new RMSDataSet();
        ospos_freeitemconditionTableAdapter tbFreeItemCond = new ospos_freeitemconditionTableAdapter();
        public UC_Reward(FrmMain fm)
        {
            InitializeComponent();
            frm = fm;
        }

        private void btnRedeem_Click(object sender, EventArgs e)
        {
            if (!_switch)
            {
                _switch = true;
                btnRedeem.Text = "ລາຍການ";
                uC_RedeemReward.BringToFront();
                uC_RedeemReward.txtBarcode.Focus();
            }
            else
            {
                _switch = false;
                btnRedeem.Text = "ແລກສິນຄ້າ";
                this.flowLayoutPanel1.BringToFront();
            }
        }

        private void UC_Reward_Load(object sender, EventArgs e)
        {
            uC_RedeemReward = new UC_RedeemReward(this, frm);
            uC_RedeemReward.Dock = DockStyle.Fill;
            pnMain.Controls.Add(uC_RedeemReward);
            flowLayoutPanel1.BringToFront();
            LoadPoints();
            UC_ItemReward itemReward;
            this.tbFreeItemCond.Fill(ds.ospos_freeitemcondition);
            foreach (RMSDataSet.ospos_freeitemconditionRow item in ds.ospos_freeitemcondition)
            {
                System.Drawing.Image img = null;
                try
                {

                    if (item.imagepath != null)
                    {
                        if (!File.Exists(item.imagepath))
                        {
                            img = null;
                        }
                        else
                        {
                            img = System.Drawing.Image.FromFile(item.imagepath);
                        }
                    }
                }
                catch
                {

                }

                itemReward = new UC_ItemReward(img);
                itemReward.ItemId = item.id;
                itemReward.ItemName = item.name;
                itemReward.Point = item.points;
                this.flowLayoutPanel1.Controls.Add(itemReward);
            }
        }
        public void LoadPoints()
        {
            lbPoints.Text = (frm.MemberPoints - frm.PointUsed).ToString("N2");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ds.Dispose();
            frm.uC_Sale1.BringToFront();
        }
    }
}
