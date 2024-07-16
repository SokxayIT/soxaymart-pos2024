using DevExpress.Entity.Model.Metadata;
using POS.ClassControl;
using POS.Forms;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using POS.Report;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace POS
{
    public partial class UC_Sale : UserControl
    {
        public FrmMain frm;
        public UC_Payment uc_payment;
        SaleService saleService = new SaleService();
        RMSDataSet ds = new RMSDataSet();

        SellListTableAdapter tbSellList = new SellListTableAdapter();
        ospos_saleTableAdapter tbSale = new ospos_saleTableAdapter();
        ospos_sale_detailsTableAdapter tbSaleDetail = new ospos_sale_detailsTableAdapter();
        ospos_sale_paymentsTableAdapter tbSalePayment = new ospos_sale_paymentsTableAdapter();
        DiscountTableAdapter tbDiscount = new DiscountTableAdapter();
        TerminalTableAdapter tbTerminal = new TerminalTableAdapter();
        ospos_usersTableAdapter tbUser = new ospos_usersTableAdapter();
        POSCashDrawerTableAdapter tbCashDrawer = new POSCashDrawerTableAdapter();
        ospos_freeitemTableAdapter tbFreeItem = new ospos_freeitemTableAdapter();
        GetPaymentTableAdapter tbGetPayment = new GetPaymentTableAdapter();
        ospos_storeTableAdapter tbStore = new ospos_storeTableAdapter();
        ListForInvoiceTableAdapter tbListInvoice = new ListForInvoiceTableAdapter();
        InvoiceDetailTableAdapter tbInvoice = new InvoiceDetailTableAdapter();
        public UC_Sale()
        {
            InitializeComponent();
        }
        public UC_Sale(FrmMain frms)
        {
            InitializeComponent();
            frm = frms;
        }
        public void EnterNumber(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            frm.txtsearch.Text += btn.Text;
            frm.txtsearch.Focus();
            frm.txtsearch.Select(frm.txtsearch.TextLength, 0);
        }
        private void btnminimize_Click(object sender, EventArgs e)
        {
            using (FrmConfirmPass fm = new FrmConfirmPass(frm, 3))
            {
                fm.ShowDialog();
            }

        }

        public void btnclose_Click(object sender, EventArgs e)
        {
            using (FrmConfirmPass fm = new FrmConfirmPass(frm, 2))
            {
                fm.ShowDialog();
            }
        }

        private void btnadjust_Click(object sender, EventArgs e)
        {
            FrmAddQty frmadd = new FrmAddQty(frm);
            if (frm.isAdjust)
            {
                frmadd.ShowDialog();
            }
            else
            {
                FrmDialogOK.Show("Please Select Item", "");
            }
        }

        private void btnShowPayment_Click(object sender, EventArgs e)
        {
            this.tbSellList.Fill(ds.SellList, frm.SaleID);
            if (ds.SellList.Rows.Count <= 0)
            {
                ds.Dispose();
                return;
            }
            if (frm.isOpenBill)
            {
                frm.uC_Payment1.BringToFront();
                frm.txtsearch.Clear();
                frm.uC_Payment1.EnterPay = false;
            }
            ds.Dispose();
        }

        private void UC_Sale_Load(object sender, EventArgs e)
        {
            UC_ButtonDiscount btn;
            this.tbDiscount.FillByDiscPercent(ds.Discount);
            flDiscount.Controls.Clear();
            foreach (RMSDataSet.DiscountRow item in ds.Discount.Rows)
            {
                btn = new UC_ButtonDiscount();
                btn.DiscountID = item.DiscountID;
                btn.DiscountName = item.DiscountName;
                btn.DisplayText = item.DiscountAmount.ToString("N0") + "%";
                btn.DiscountType = item.DiscountType;
                btn.Status = item.Status;
                btn.DiscountAmount = item.DiscountAmount;
                btn.Click += DisClick;
                flDiscount.Controls.Add(btn);
            }
        }
        private void DisClick(object sender, EventArgs e)
        {
            if (frm.Role != "10004" && frm.Role != "10005" && frm.Role != "99999")
            {
                FrmConfirmPass con = new FrmConfirmPass(frm, 4);
                con.ShowDialog();
                if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                {
                    return;
                }
                frm.Permission = "";
                con.Dispose();
            }
            UC_ButtonDiscount uc = new UC_ButtonDiscount();
            uc = (UC_ButtonDiscount)sender;
            tbSaleDetail.FillForCheckDiscount(ds.ospos_sale_details, frm.SaleID, frm.DetailSeq);
            if (ds.ospos_sale_details.Rows.Count > 0)
            {
                FrmDialogOK.Show("ບໍ່ສາມາດນຳໃຊ້ສ່ວນຫຼຸດ!!!", "Warning!");
                return;
            }
            this.tbSaleDetail.FillByDetailSeq(ds.ospos_sale_details, frm.SaleID, frm.DetailSeq);
            if (frm.isDiscount)
            {
                if ((decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_discountColumn] > 0)
                {
                    FrmDialogOK.Show("This Item Already Have Discount", "Warning");
                    return;
                }
                SaleDetailModel saleDetail = new SaleDetailModel
                {
                    sale_id = frm.SaleID,
                    sale_detailseq = frm.DetailSeq,
                    item_discount = Math.Floor(((frm.ItemValue / 100) * uc.DiscountAmount) / 500) * 500,
                    fk_promo_dis_id = 0,
                    fk_promo_free_id = 0,
                    promo_type = "Discount " + uc.DiscountAmount.ToString("N0") + "%",
                    points = 0
                };
                saleService.UpdateDiscount(saleDetail);

                frm.isDiscount = false;
                ds.Dispose();
                frm.LoadList();
            }
            else { FrmDialogOK.Show("Select Item To Discount", ""); }
            ds.Dispose();
        }

        public void btndeleteitem_Click(object sender, EventArgs e)
        {

            if (FrmDialogYesNo.Show("Are You Sure To Delete This Item?", "Confirm") == DialogResult.No)
                return;
        
            if (frm.DeleteType == 1)
            {
                //if (frm.Role == "10004" || frm.Role == "10005" || frm.Role == "10003")
                //{
                //    FrmDialogOK.Show("You Dont Have Permission !!", "Warnning");
                //    return;
                //}
                if (frm.Role != "10004" && frm.Role != "10005" && frm.Role != "99999")
                {
                    FrmConfirmPass con = new FrmConfirmPass(frm, 4);
                    con.ShowDialog();
                    if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                    {
                        return;
                    }
                    frm.Permission = "";
                    con.Dispose();
                }
            }
            if (frm.Role == "99999" || frm.Role == "10005" || frm.Role == "10004")
            {
                frm.Maker = frm.EmpID;
            }
          
            if (frm.isDelete == true && frm.DeleteType == 1)
            {
                DeleteItem();
            }
            else if (frm.isDelete == true && frm.DeleteType == 3)
            {
                DeletePayment();
            }
            frm.DeleteType = 0;
            frm.isDelete = false;
            frm.ClearSelected();
        }
        public void DeleteItem()
        {
            try
            {
                RMSDataSet md = new RMSDataSet();
                this.tbSaleDetail.FillByDetailSeq(ds.ospos_sale_details, frm.SaleID, frm.DetailSeq);
                if (ds.ospos_sale_details.Rows.Count > 0)
                {
                    SaleDeleteItemModel saleDeleteItem = new SaleDeleteItemModel
                    {
                        sale_id = (int)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.sale_idColumn],
                        seq = saleService.CreateDeleteSeq(frm.SaleID),
                        sale_detail_seq = (int)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.sale_detailseqColumn],
                        delete_datetime = DateTime.Now,
                        sale_no = frm.SaleNO,
                        fk_terminal_id = frm.TerminalID,
                        fk_user_id = frm.EmpID,
                        sale_date_time = (DateTime)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.sale_datetimeColumn],
                        fk_product_item_id = (int)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.fk_product_item_idColumn],
                        product_name = ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.product_item_nameColumn].ToString(),
                        qty_peice = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.qty_peiceColumn],
                        item_qty = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_qtyColumn],
                        item_price = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_priceColumn],
                        item_vat = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_vatColumn],
                        item_discount = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_discountColumn],
                        item_netprice = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_netpriceColumn],
                        item_priceorigin = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_priceoriginColumn],
                        item_status = "D",
                        promo_type = ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.promo_typeColumn].ToString(),
                        fk_promo_free_id = (int)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.fk_promo_free_idColumn],
                        fk_promo_dis_id = (int)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.fk_promo_dis_idColumn],
                        remark = frm.Maker,
                        interfacestatus = "T",
                    };

                    saleService.InsertDeleteProductItem(saleDeleteItem);
                    saleService.DeleteItemSaleDetail(frm.SaleID, frm.DetailSeq);

                    tbSaleDetail.FillByPromotionFreeItem(md.ospos_sale_details, frm.SaleID, (int)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.fk_promo_free_idColumn]);
                    foreach (RMSDataSet.ospos_sale_detailsRow item in md.ospos_sale_details.Rows)
                    {
                        SaleDeleteItemModel saleDeleteFreeItem = new SaleDeleteItemModel
                        {
                            sale_id = item.sale_id,
                            seq = saleService.CreateDeleteSeq(frm.SaleID),
                            sale_detail_seq = item.sale_detailseq,
                            delete_datetime = DateTime.Now,
                            sale_no = frm.SaleNO,
                            fk_terminal_id = frm.TerminalID,
                            fk_user_id = frm.EmpID,
                            sale_date_time = item.sale_datetime,
                            fk_product_item_id = item.fk_product_item_id,
                            product_name = item.product_item_name,
                            item_qty = item.item_qty,
                            item_price = item.item_price,
                            item_vat = item.item_vat,
                            item_discount = item.item_discount,
                            item_netprice = item.item_netprice,
                            item_priceorigin = item.item_priceorigin,
                            item_status = "D",
                            promo_type = item.promo_type,
                            fk_promo_free_id = item.fk_promo_free_id,
                            fk_promo_dis_id = item.fk_promo_dis_id,
                            remark = frm.Maker,
                            interfacestatus = "T",
                        };
                        saleService.InsertDeleteProductItem(saleDeleteFreeItem);
                        saleService.DeleteItemSaleDetail(frm.SaleID, item.sale_detailseq);
                    }
                }

                tbFreeItem.FillByDetailSeq(ds.ospos_freeitem, frm.SaleID, frm.DetailSeq);
                if (ds.ospos_freeitem.Rows.Count > 0)
                {
                    this.tbFreeItem.DeleteQuery(frm.SaleID, frm.DetailSeq);
                    if (frm.isMember == true)
                    {
                        frm.PointUsed -= (decimal)ds.ospos_freeitem.Rows[0][ds.ospos_freeitem.pointsColumn] * (decimal)ds.ospos_freeitem.Rows[0][ds.ospos_freeitem.item_qtyColumn];
                    }
                }
                frm.LoadList();
                frm.Maker = " ";
                ds.Dispose();
                md.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void DeletePayment()
        {
            this.tbSalePayment.FillBySaleIDSeq(ds.ospos_sale_payments, frm.SaleID, frm.PaySeq);
            frm.Maker = " ";
            SaleDeletePaymentModel saleDeletePayment = new SaleDeletePaymentModel
            {
                sale_id = (int)ds.ospos_sale_payments.Rows[0][ds.ospos_sale_payments.sale_idColumn],
                seq = saleService.CreateDeletePaymentSeq(frm.SaleID),
                delete_datetime = DateTime.Now,
                sale_no = frm.SaleNO,
                fk_terminal_id = ds.ospos_sale_payments.Rows[0][ds.ospos_sale_payments.fk_terminal_idColumn].ToString(),
                fk_user_id = ds.ospos_sale_payments.Rows[0][ds.ospos_sale_payments.fk_user_idColumn].ToString(),
                paymentseq = (int)ds.ospos_sale_payments.Rows[0][ds.ospos_sale_payments.paymentseqColumn],
                payment_datetime = (DateTime)ds.ospos_sale_payments.Rows[0][ds.ospos_sale_payments.payment_datetimeColumn],
                fk_payment_method_id = (int)ds.ospos_sale_payments.Rows[0][ds.ospos_sale_payments.fk_payment_method_idColumn],
                payment_name = saleService.GetPaymentName((int)ds.ospos_sale_payments.Rows[0][ds.ospos_sale_payments.fk_payment_method_idColumn]),
                payment_value = (decimal)ds.ospos_sale_payments.Rows[0][ds.ospos_sale_payments.payment_valueColumn],
                payment_receive = (decimal)ds.ospos_sale_payments.Rows[0][ds.ospos_sale_payments.payment_receiveColumn],
                payment_change = (decimal)ds.ospos_sale_payments.Rows[0][ds.ospos_sale_payments.payment_changeColumn],
                remark = frm.Maker,
                interfacestatus = "T"
            };

            saleService.InsertDeletePayment(saleDeletePayment);
            saleService.DeletePayment(frm.SaleID, frm.PaySeq);

            frm.Receipt -= (decimal)ds.ospos_sale_payments.Rows[0][ds.ospos_sale_payments.payment_receiveColumn];
            frm.LoadList();
            frm.Maker = " ";
            ds.Dispose();
        }
        private void btnstopbill_Click(object sender, EventArgs e)
        {
            this.tbSalePayment.FillBySaleID(ds.ospos_sale_payments, frm.SaleID);
            if (frm.Role == "10004" || frm.Role == "10005" || frm.Role == "10003")
            {
                FrmDialogOK.Show("You Dont Have Permission !!", "Warnning");
                return;
            }
            if (ds.ospos_sale_payments.Rows.Count > 0)
            {
                FrmDialogOK.Show("ກະລຸນາລຶບລາຍການຈ່າຍເງິນກ່ອນ!!!", "Warning!");
                return;
            }
            if (frm.Role != "10004" && frm.Role != "10005" && frm.Role != "99999")
            {
                FrmConfirmPass con = new FrmConfirmPass(frm, 4);
                con.ShowDialog();
                if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                {
                    return;
                }
                frm.Permission = "";
                con.Dispose();
            }

            saleService.UpdateSaleStatus(frm.SaleID, "B", " ", "T");

            frm.isOpenBill = false;
            frm.ResetSale();
            Properties.Settings.Default.SaleID = 0;
            Properties.Settings.Default.Save();
            frm.uC_Sale1.BringToFront();
            frm.LoadList();
            ds.Dispose();
        }

        public void btnsignout_Click(object sender, EventArgs e)
        {
            this.tbSalePayment.FillBySaleID(ds.ospos_sale_payments, frm.SaleID);
            if (ds.ospos_sale_payments.Rows.Count > 0)
            {
                FrmDialogOK.Show("ກະລຸນາລຶບລາຍການຈ່າຍເງິນກ່ອນ!!!", "Warning!");
                return;
            }
            if (frm.SaleID != 0)
            {
                saleService.UpdateSaleStatus(frm.SaleID, "B", " ", "T");
            }
            saleService.updatestatusonline("0", frm.EmpID);
            frm.ClearFreeitem();
            frm.EmpID = "";
            frm.fmlogin.Show();
            frm.Monitor.Close();
            ds.Dispose();
          
            frm.Close();
        }

        private void btnbillnotpay_Click(object sender, EventArgs e)
        {
            if (frm.Role != "10004" && frm.Role != "10005" && frm.Role != "99999")
            {
                FrmConfirmPass con = new FrmConfirmPass(frm, 4);
                con.ShowDialog();
                if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                {
                    return;
                }
                frm.Permission = "";
                con.Dispose();
            }
            frmListBill frmListBills = new frmListBill(frm);
            frmListBills.start = "B";
            frmListBills.ShowDialog();
            frmListBills.Dispose();
            frm.txtsearch.Focus();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.tbSalePayment.FillBySaleID(ds.ospos_sale_payments, frm.SaleID);
            //if (frm.Role == "10004" || frm.Role == "10005" || frm.Role == "10003")
            //{
            //    FrmDialogOK.Show("You Dont Have Permission !!", "Warnning");
            //    return;
            //}
            if (ds.ospos_sale_payments.Rows.Count > 0)
            {
                FrmDialogOK.Show("ກະລຸນາລຶບລາຍການຈ່າຍເງິນກ່ອນ!!!", "Warning!");
                return;
            }
            if (frm.Role != "10004" && frm.Role != "10005" && frm.Role != "99999")
            {
                FrmConfirmPass con = new FrmConfirmPass(frm, 4);
                con.ShowDialog();
                if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                {
                    return;
                }
                frm.Permission = "";
                con.Dispose();
            }
            else if (frm.Role == "10004" || frm.Role == "10005" || frm.Role == "99999")
            {
                frm.Maker = frm.EmpID;
            }
            if (frm.SaleID != 0)
            {
                if (FrmDialogYesNo.Show("Are You Sure To Cancel This?", "Confirm") == DialogResult.Yes)
                {
                    RMSDataSet md = new RMSDataSet();

                    CRInvoiceCancel invoice = new CRInvoiceCancel();

                    PrinterSettings ps = new PrinterSettings();
                    md.EnforceConstraints = false;

                    SaleModel sale = new SaleModel
                    {
                        sale_id = frm.SaleID,
                        sale_status = "C",
                        closedate = DateTime.Now,
                        lastupdate = DateTime.Now,
                        close_terminal_id = frm.TerminalID,
                        close_user_id = frm.EmpID,
                        fk_member_id = frm.MemberID,
                        points = 0,
                        total_points = 0,
                        remark = frm.Maker,
                        interfacestatus = "T",
                    };
                    saleService.UpdateCloseSale(sale);
                    saleService.UpdateSaleDetailStatus(frm.SaleID, "C", "T");

                    tbListInvoice.FillBySaleID(md.ListForInvoice, frm.SaleID);
                    tbInvoice.FillBySaleID(md.InvoiceDetail, frm.SaleID);
                    //tbGetPayment.Fill(md.GetPayment, frm.SaleID);
                    tbTerminal.FillByTerminalID(md.Terminal, frm.TerminalID);
                    tbStore.Fill(md.ospos_store);

                    try
                    {
                        invoice.SetDataSource(md);
                        invoice.PrintOptions.PrinterName = ps.PrinterName;
                        invoice.Refresh();
                        invoice.PrintToPrinter(1, false, 0, 0);
                        md.Dispose();
                        invoice.Dispose();
                    }
                    catch (Exception)
                    {
                        FrmDialogOK.Show("Connot Connect Printer", "Error");
                    }
                    frm.isOpenBill = false;
                    frm.ResetSale();
                    Properties.Settings.Default.SaleID = 0;
                    Properties.Settings.Default.Save();
                    frm.LoadList();
                    md.Dispose();
                    invoice.Dispose();
                }
            }
            frm.txtsearch.Focus();
            frm.txtsearch.Select(frm.txtsearch.TextLength, 0);
            ds.Dispose();
        }

        public void btnopencash_Click(object sender, EventArgs e)
        {
            try
            {
                if (frm.Role != "10004" && frm.Role != "10005" && frm.Role != "99999")
                {
                    FrmConfirmPass con = new FrmConfirmPass(frm, 4);
                    con.ShowDialog();
                    if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                    {
                        return;
                    }
                    frm.Permission = "";
                    con.Dispose();
                }

                this.tbCashDrawer.InsertQuery(DateTime.Now.Date, DateTime.Now, frm.TerminalID, frm.EmpID, 1, "1", "Open Cashdrawer", 0, "F", DateTime.Now, "F");
                CROpenCash op = new CROpenCash();
                op.SetParameterValue("i", "1");
                op.SetParameterValue("d", DateTime.Now);
                op.SetParameterValue("n", frm.lbEmpName.Text);
                op.SetParameterValue("r", "Open Cashdrawer");
                op.PrintToPrinter(1, false, 0, 0);
                frm.OpenCashDrawer();
                frm.txtsearch.Focus();
                frm.txtsearch.Select(frm.txtsearch.TextLength, 0);
            }
            catch (Exception)
            {
                FrmDialogOK.Show("Connot Connect Printer", "Error");
            }
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            frm._Manage.BringToFront();
        }

        private void btnreprint_Click(object sender, EventArgs e)
        {
            using (FrmReprint fmp = new FrmReprint(frm))
            {
                fmp.ShowDialog();
            }
            frm.txtsearch.Focus();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            frm.txtsearch.Clear();
            frm.txtsearch.Focus();
            frm.txtsearch.Select(frm.txtsearch.TextLength, 0);
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            frm.InsertCheck();
        }

        private void btndiscount_Click(object sender, EventArgs e)
        {
            if (frm.Role != "10004" && frm.Role != "10005" && frm.Role != "99999")
            {
                FrmConfirmPass con = new FrmConfirmPass(frm, 4);
                con.ShowDialog();
                if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                {
                    return;
                }
                frm.Permission = "";
                con.Dispose();
            }
            FrmDisountAmount frmDisount = new FrmDisountAmount(frm);
            frmDisount.ShowDialog();
            frmDisount.Dispose();
            frm.txtsearch.Focus();
        }

        private void btncheckbill_Click(object sender, EventArgs e)
        {
            //if (frm.Role != "10004" && frm.Role != "10005" && frm.Role != "99999")
            //{
            //    FrmConfirmPass con = new FrmConfirmPass(frm, 4);
            //    con.ShowDialog();
            //    if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
            //    {
            //        return;
            //    }
            //    frm.Permission = "";
            //    con.Dispose();
            //}
            frmListBill frmListBills = new frmListBill(frm);
            frmListBills.start = "S";
            frmListBills.ShowDialog();
            frmListBills.Dispose();
        }

        private void btnseachitem_Click(object sender, EventArgs e)
        {
            FrmProduct product = new FrmProduct(frm);
          //  product.Dispose();
            product.ShowDialog();
            frm.txtsearch.Focus();
        }

        private void btncancelbill_Click(object sender, EventArgs e)
        {
            //if (frm.Role == "10004" || frm.Role == "10005" || frm.Role == "10003")
            //{
            //    FrmDialogOK.Show("You Dont Have Permission !!", "Warnning");
            //    return;
            //}
            if (frm.Role != "10004" && frm.Role != "10005" && frm.Role != "99999")
            {
                FrmConfirmPass con = new FrmConfirmPass(frm, 5);
                con.ShowDialog();
                if (frm.Permission != "10004" && frm.Permission != "10005" && frm.Permission != "99999")
                {
                    return;
                }
                frm.Permission = "";
                con.Dispose();
            }
            else if (frm.Role == "10004" || frm.Role == "10005" || frm.Role == "99999")
            {
                frm.Maker = frm.EmpID;
                FrmVoid frmyes = new FrmVoid(frm);
                frmyes.ShowDialog();
            }
             
             


            //FrmVoiceCheck frmVoice = new FrmVoiceCheck(frm);
            //frmVoice.ShowDialog();
            //frmVoice.Dispose();
            //frm.txtsearch.Focus();
            //frm.txtsearch.Select(frm.txtsearch.TextLength, 0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string s = frm.txtsearch.Text;
            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                frm.txtsearch.Text = s;
            }
            frm.txtsearch.Focus();
            frm.txtsearch.Select(frm.txtsearch.TextLength, 0);
        }

        private void btnhotkey_Click(object sender, EventArgs e)
        {
            FrmHotkey hotkey = new FrmHotkey(frm);
            hotkey.ShowDialog();
            hotkey.Dispose();
            frm.txtsearch.Focus();
        }

        private void flDiscount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncancelsomeitem_Click(object sender, EventArgs e)
        {
            if (frm.isMember != true)
            {
                FrmEnterCustomerID CusFrm = new FrmEnterCustomerID(frm);
                CusFrm.ShowDialog();
                CusFrm.Dispose();
            }
            else if (frm.isMember == true)
            {
                FrmCustomerDetail FrmCD = new FrmCustomerDetail(frm, frm.MemberName, frm.MemberPhone, frm.MemberID);
                FrmCD.ShowDialog();
                FrmCD.Dispose();
            }

        }
    }
}
