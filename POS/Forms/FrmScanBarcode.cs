using DevExpress.Utils.About;
using POS.ClassControl;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
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
    public partial class FrmScanBarcode : Form
    {
      
        public FrmMain frm;
        public FrmRefundItem frmr;
        int SaleID;
        int checksaleRefundDetail;
        int productitemid;
        int checksaledetail;
        RMSDataSet ds = new RMSDataSet();
        SaleService saleService = new SaleService();
        ospos_sale_refund_detailsTableAdapter tbSaleRefundDetail = new ospos_sale_refund_detailsTableAdapter();   
        ospos_product_itemTableAdapter tbProductitem = new ospos_product_itemTableAdapter();
        ospos_sale_detailsTableAdapter tbSaleDetail = new ospos_sale_detailsTableAdapter();


        public FrmScanBarcode(FrmMain frms,int checkseq)
        {
            InitializeComponent();
            frm = frms;
            SaleID = checkseq;
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text != "")
            {
                productitemid = (int)tbProductitem.GetProductitemID(txtBarcode.Text.ToString());
                if (productitemid == 0)
                {
                    FrmDialogOK.Show("ສິນຄ້າບໍ່ມີໃນລະບົບ!!!", "Warnning");
                    txtBarcode.Focus();
                }
                else
                {
                    checksaledetail = (int)tbSaleDetail.ScalarProductItemid(SaleID, productitemid);
                    if (checksaledetail == 0) 
                    {
                        FrmDialogOK.Show("ສິນຄ້ານີ້ນີ້ບໍ່ມີໃນໃບບິນ!!!", "Warnning");
                        txtBarcode.Clear();
                        txtBarcode.Focus();
                    }
                    else
                    {
                        checksaleRefundDetail = (int)tbSaleRefundDetail.CheckProductitemID(SaleID, productitemid);
                        if (checksaleRefundDetail == 0)
                        {
                            //saleService.InsertTempSaleRefund((int.Parse(txtCheckNoRefunditem.Text)));
                            saleService.InsertTempSaleRefundProduct(SaleID, productitemid);
                            FrmBillRefundProduct frmbill = new FrmBillRefundProduct(frm);
                            frmbill.SaleID = SaleID;
                            frmbill.itemid = productitemid;
                            frmbill.txtQty.Focus();
                            frmbill.ShowDialog();
                            Close();
                        }
                        else
                        {
                            FrmDialogOK.Show("ລາຍການນີ້ຖືກຍົກເລີກແລ້ວ!!!", "Warnning");
                            txtBarcode.Clear();
                            txtBarcode.Focus();

                        }

                    }
                                                   
                }
               
            } 
            else
            {
                FrmDialogOK.Show("ກະລຸນາປ້ອນບາໂຄດ!!!", "Warnning");
            }
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           
        }
        private void EnterNumber(object e)
        {
            Button b = (Button)e;
            txtBarcode.Text += b.Text;
        }
        private void Number_Click(object sender, EventArgs e)
        {
            EnterNumber(sender);
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string s = txtBarcode.Text;
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                txtBarcode.Text = s;
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
        }

        private void FrmScanBarcode_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saleService.DeleteTempSaleRefund(SaleID);
            saleService.DeleteTempSaleRefundDetail(SaleID);
            Close();
        }
    }
}
