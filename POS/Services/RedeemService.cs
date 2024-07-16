using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.ClassControl
{
    public class RedeemService
    {
        FrmMain frm;
        ospos_freeitemTableAdapter tbFreeItem = new ospos_freeitemTableAdapter();
        //GENERATE METHOD
        public int CreateFreeSeq(int saleId)
        {
            int freeSeq = (int)tbFreeItem.GenFreeSeq(saleId);
            return freeSeq;
        }

        //INSERT METHOD
        public void InsertFreeItem(FreeItemModel freeItem)
        {
            try
            {
                tbFreeItem.InsertItem(freeItem.sale_id, freeItem.free_seq, freeItem.sale_detailseq, freeItem.sale_datetime, freeItem.fk_product_item_id, freeItem.barcode, freeItem.product_item_name,
                    freeItem.item_status, freeItem.item_qty, freeItem.item_price, freeItem.points, freeItem.interfacestatus);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //UPDATE METHOD
        public void UpdateQtyFreeItem(int saleID, int prodID, int qty)
        {
            try
            {
                tbFreeItem.UpdateQty(qty, prodID, saleID);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdateStatusFreeItem(int saleID, string status, string infStatus)
        {
            try
            {
                tbFreeItem.UpdateStatus(status, infStatus, saleID);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void UpdateFreeItemStatus(int id, string status, string infStatus)
        {
            try
            {
                tbFreeItem.UpdateStatus(status, infStatus, id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
