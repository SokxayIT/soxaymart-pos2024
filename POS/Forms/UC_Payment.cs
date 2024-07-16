using Newtonsoft.Json;
using POS.ClassControl;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using POS.Report;
using POS.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class UC_Payment : UserControl
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Des, int Reserve);
        FrmMain frm { get; set; }
        public bool EnterPay = false;
        int des;
        GenerateQR QR;
        //model models;
        public static UC_Payment uc_payment;
        //string QRStore, QRBillNo, QRTotal;
        HttpClient http = new HttpClient();
        APIRespone responses = new APIRespone();
        APIRequest requests = new APIRequest();

        ResponeAPI res = new ResponeAPI();
        RequestAPI req = new RequestAPI();

        SqlCommand cmdP = new SqlCommand();
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.RMSConnectionString);

        LogError er = new LogError();

        RMSDataSet ds = new RMSDataSet();

        SaleService saleService = new SaleService();
        RedeemService redeemService = new RedeemService();
        SyncData sync = new SyncData();

        ospos_saleTableAdapter tbSale = new ospos_saleTableAdapter();
        ospos_sale_detailsTableAdapter tbSaleDetail = new ospos_sale_detailsTableAdapter();
        ospos_sale_paymentsTableAdapter tbSalePayment = new ospos_sale_paymentsTableAdapter();
        ospos_member_pointsTableAdapter tbMemberPoints = new ospos_member_pointsTableAdapter();
        ospos_payment_methodTableAdapter tbPaymentMethod = new ospos_payment_methodTableAdapter();
        ospos_freeitemTableAdapter tbFreeItem = new ospos_freeitemTableAdapter();
        SellListTableAdapter tbSellList = new SellListTableAdapter();
        POSCashDrawerTableAdapter tbCashDrawer = new POSCashDrawerTableAdapter();
        PromotionsTableAdapter tbPromotion = new PromotionsTableAdapter();
        ospos_usersTableAdapter tbUser = new ospos_usersTableAdapter();
        TerminalTableAdapter tbTerminal = new TerminalTableAdapter();
        GetPaymentTableAdapter tbGetPayment = new GetPaymentTableAdapter();
        ospos_storeTableAdapter tbStore = new ospos_storeTableAdapter();
        ListForInvoiceTableAdapter tbListInvoice = new ListForInvoiceTableAdapter();
        InvoiceDetailTableAdapter tbInvoice = new InvoiceDetailTableAdapter();
        ospos_companyTableAdapter tbCompany = new ospos_companyTableAdapter();
        ospos_product_itemTableAdapter tbProductItem = new ospos_product_itemTableAdapter();
        public UC_Payment()
        {
            InitializeComponent();
        }
        public UC_Payment(FrmMain frms)
        {
            InitializeComponent();
            frm = frms;
            uc_payment = this;
        }
        public void loadImage()
        {
            frm.Monitor.disImage = false;
            frm.Monitor.PicPromotion.Image = Properties.Resources.empty_grocery_store;
            frm.Monitor.LoadImage();
            frm.Monitor.PicPromotion.SizeMode = PictureBoxSizeMode.StretchImage;
            frm.Monitor.PicPromotion.BackgroundImage = null;
        }
        private void btnprevious_Click(object sender, EventArgs e)
        {
            frm.uC_Sale1.BringToFront();
            frm.txtsearch.Clear();
            this.EnterPay = false;
            frm.txtsearch.Focus();
        }

        private void UC_Payment_Load(object sender, EventArgs e)
        {
            LoadPayment();
        }
        private void LoadPayment()
        {
            UC_Credit credit;
            RMSDataSet ds = new RMSDataSet();
            ds.Clear();

            flowLayoutPanel1.Controls.Clear();
            var data = tbPaymentMethod.GetDataBy1(2);
            foreach (var item in data)
            {
                Image im = null;
                try
                {
                    if (item.immage != null)
                    {
                        if (!File.Exists(item.immage))
                        {
                            im = null;
                        }
                        else
                        {
                            im = Image.FromFile(item.immage);
                        }
                    }
                }
                catch (Exception)
                {

                }

                credit = new UC_Credit(item.id.ToString(), im, item.laoname, item.fk_payment_type_id);
                credit.Click += creditClick;
                flowLayoutPanel1.Controls.Add(credit);
            }
        }
        private void creditClick(object sender, EventArgs e)
        {
            decimal points = 0, totalPoints = 0, priceUpdate = 0, 
                vatUpdate=0, discount=0, costprice=0, pointupdate=0, 
                subtotal_amount=0, discount_amount=0, vat_amount=0, 
                netprice_amount=0, cost_amount=0;
            UC_Credit uc = new UC_Credit();
            uc = (UC_Credit)sender;
            if (frm.Total == 0)
            {
                FrmDialogOK.Show("Please Add Product To List", "");
                return;
            }
            if (frm.Receipt > 0)
            {
                FrmDialogOK.Show("Please Remove Cash From List", "");
                return;
            }
            if (FrmDialogYesNo.Show("Confirm Payment to Pay By " + uc.PaymentName + "?", "Confirm") == DialogResult.Yes)
            {
                frm.isOpenBill = false;

                SalePaymentModel payment = new SalePaymentModel
                {
                    sale_id = frm.SaleID,
                    paymentseq = saleService.CreatePaymentSeq(frm.SaleID),
                    payment_datetime = DateTime.Now,
                    fk_payment_method_id = int.Parse(uc.PaymentID),
                    payment_value = frm.Total,
                    payment_receive = frm.Total,
                    payment_change = 0,
                    fk_terminal_id = frm.TerminalID,
                    fk_user_id = frm.EmpID,
                    interfacestatus = "T"
                };
                saleService.InsertSalePayment(payment);

                if (frm.isMember == true)
                {
                    points = saleService.SUMPoints(frm.SaleID);
                    totalPoints = (frm.MemberPoints + points) - frm.PointUsed;
                    if (points > 0)
                    {
                        MemberPointModel memberReceive = new MemberPointModel
                        {
                            fk_member_id = frm.MemberID,
                            fk_sale_id = frm.SaleID,
                            item_cost = saleService.CalCostPrice(frm.SaleID),
                            net_amount = frm.Total,
                            points = saleService.SUMPoints(frm.SaleID),
                            saledate = DateTime.Now,
                            type = "Receive",
                            sale_status = "S",
                            interfacestatus = "T"
                        };
                        saleService.InsertMemberPoint(memberReceive);
                    }
                    this.tbFreeItem.FillBySaleID(ds.ospos_freeitem, frm.SaleID);
                    if (ds.ospos_freeitem.Rows.Count > 0)
                    {
                        redeemService.UpdateStatusFreeItem(frm.SaleID, "S", "T");

                        MemberPointModel memberApply = new MemberPointModel
                        {
                            fk_member_id = frm.MemberID,
                            fk_sale_id = frm.SaleID,
                            item_cost = saleService.CalCostPrice(frm.SaleID),
                            net_amount = frm.Total,
                            points = -frm.PointUsed,
                            saledate = DateTime.Now,
                            type = "Apply",
                            sale_status = "S",
                            interfacestatus = "T"
                        };
                        saleService.InsertMemberPoint(memberApply);
                    }
                }
                //****update price online****//

                //this.tbSaleDetail.FillByDetail(ds.ospos_sale_details, frm.SaleID);
                //if (ds.ospos_sale_details.Rows.Count > 0)
                //{
                //    foreach (RMSDataSet.ospos_sale_detailsRow item in ds.ospos_sale_details)
                //    {                     
                //         priceUpdate = (decimal)tbProductItem.FoodPandaPrice(item.fk_product_item_id);                     
                //         vatUpdate = saleService.CalVat(priceUpdate);
                //         discount = item.item_discount;
                //         costprice = item.item_costprice;
                //         pointupdate = saleService.Points(priceUpdate, item.item_costprice, 0);
                //         this.tbSaleDetail.UpdatePriceOnline(priceUpdate, vatUpdate, pointupdate, item.item_qty, priceUpdate, item.sale_id,item.sale_detailseq);
                //        subtotal_amount +=priceUpdate;
                //        discount_amount += discount;
                //        vat_amount += vatUpdate;
                //        netprice_amount += priceUpdate+discount;
                //        cost_amount += costprice;
 
                //    }
                //    saleService.UpdateSaleValuesByPayonline(subtotal_amount, discount_amount, vat_amount, netprice_amount, cost_amount, frm.SaleID);
                //}
                //*******************************************//

                saleService.UpdateSaleDetailStatus(frm.SaleID, "S", "T");

                SaleModel sale = new SaleModel
                {
                    sale_id = frm.SaleID,
                    sale_status = "S",
                    closedate = DateTime.Now,
                    lastupdate = DateTime.Now,
                    close_terminal_id = frm.TerminalID,
                    close_user_id = frm.EmpID,
                    fk_member_id = frm.MemberID,
                    points = points,
                    total_points = totalPoints,
                    remark = " ",
                    interfacestatus = "T",
                };
                saleService.UpdateCloseSale(sale);
                Task.Run(() => PrintBill(frm.SaleID));
                sync.syncAllData(frm.BaseURL, frm.StoreID, frm.Token);

                using (frmDialogPay fpay = new frmDialogPay())
                {
                    fpay.total = frm.Total;
                    fpay.receipt = frm.Total;
                    fpay.change = 0;
                    fpay.ShowDialog();
                }

                Properties.Settings.Default.SaleID = 0;
                Properties.Settings.Default.Save();
                frm.ResetSale();
                frm.uC_Sale1.BringToFront();
                loadImage();
                frm.LoadList();
                ds.ospos_freeitem.Dispose();
            }
        }
        private void btnpay_Click(object sender, EventArgs e)
        {
            decimal points = 0, totalPoints = 0;
            this.tbSellList.Fill(ds.SellList, frm.SaleID);
            this.tbFreeItem.FillBySaleID(ds.ospos_freeitem, frm.SaleID);

            if (ds.SellList.Rows.Count <= 0)
            {
                FrmDialogOK.Show("ບໍ່ມີລາຍການຊຳລະ", "");
                return;
            }

            if (FrmDialogYesNo.Show("ຢືນຢັນການຊຳລະເງິນສົດ?", "Confirm Payment?") == DialogResult.Yes)
            {
                if (frm.txtsearch.TextLength > 0 && decimal.Parse(frm.txtsearch.Text) + frm.Receipt < frm.Total)
                {
                    FrmDialogOK.Show("Money Not Enought", "");
                    return;
                }
                if (frm.isOpenBill && frm.Total > 0 || ds.ospos_freeitem.Rows.Count > 0)
                {
                    frm.Discount = Math.Abs(frm.Discount);
                    frm.isOpenBill = false;

                    if (frm.txtsearch.Text == "")
                    {
                        SalePaymentModel payment = new SalePaymentModel
                        {
                            sale_id = frm.SaleID,
                            paymentseq = saleService.CreatePaymentSeq(frm.SaleID),
                            payment_datetime = DateTime.Now,
                            fk_payment_method_id = 1,
                            payment_value = frm.Total,
                            payment_receive = frm.Total,
                            payment_change = 0,
                            fk_terminal_id = frm.TerminalID,
                            fk_user_id = frm.EmpID,
                            interfacestatus = "T"
                        };
                        saleService.InsertSalePayment(payment);
                    }
                    else if (decimal.Parse(frm.txtsearch.Text) + frm.Receipt >= (frm.Total) - frm.Receipt)
                    {
                        SalePaymentModel payment = new SalePaymentModel
                        {
                            sale_id = frm.SaleID,
                            paymentseq = saleService.CreatePaymentSeq(frm.SaleID),
                            payment_datetime = DateTime.Now,
                            fk_payment_method_id = 1,
                            payment_value = frm.Total,
                            payment_receive = decimal.Parse(frm.txtsearch.Text),
                            payment_change = decimal.Parse(frm.txtsearch.Text) - (frm.Total - frm.Receipt),
                            fk_terminal_id = frm.TerminalID,
                            fk_user_id = frm.EmpID,
                            interfacestatus = "T"
                        };
                        saleService.InsertSalePayment(payment);
                    }

                    if (frm.isMember == true)
                    {
                        points = saleService.SUMPoints(frm.SaleID);
                        totalPoints = (frm.MemberPoints + points) - frm.PointUsed;
                        if (points > 0)
                        {
                            MemberPointModel memberReceive = new MemberPointModel
                            {
                                fk_member_id = frm.MemberID,
                                fk_sale_id = frm.SaleID,
                                item_cost = saleService.CalCostPrice(frm.SaleID),
                                net_amount = frm.Total,
                                points = points,
                                saledate = DateTime.Now,
                                type = "Receive",
                                sale_status = "S",
                                interfacestatus = "T"
                            };
                            saleService.InsertMemberPoint(memberReceive);
                        }

                        if (ds.ospos_freeitem.Rows.Count > 0)
                        {
                            redeemService.UpdateStatusFreeItem(frm.SaleID, "S", "T");

                            MemberPointModel memberApply = new MemberPointModel
                            {
                                fk_member_id = frm.MemberID,
                                fk_sale_id = frm.SaleID,
                                item_cost = saleService.CalCostPrice(frm.SaleID),
                                net_amount = frm.Total,
                                points = -frm.PointUsed,
                                saledate = DateTime.Now,
                                type = "Apply",
                                sale_status = "S",
                                interfacestatus = "T"
                            };
                            saleService.InsertMemberPoint(memberApply);
                        }
                    }
                
                    //************************************************************//
                    saleService.UpdateSaleDetailStatus(frm.SaleID, "S", "T");

                    SaleModel sale = new SaleModel
                    {
                        sale_id = frm.SaleID,
                        sale_status = "S",
                        closedate = DateTime.Now,
                        lastupdate = DateTime.Now,
                        close_terminal_id = frm.TerminalID,
                        close_user_id = frm.EmpID,
                        fk_member_id = frm.MemberID,
                        points = points,
                        total_points = totalPoints,
                        remark = " ",
                        interfacestatus = "T",
                    };
                    saleService.UpdateCloseSale(sale);

                    this.tbCashDrawer.InsertQuery(DateTime.Now.Date, DateTime.Now, frm.TerminalID, frm.EmpID, 1, "5", "sale", frm.Total, "F", DateTime.Now, "F");
                    frm.OpenCashDrawer();
                    Task.Run(() => PrintBill(frm.SaleID));
                    sync.syncAllData(frm.BaseURL, frm.StoreID, frm.Token);

                    using (frmDialogPay fpay = new frmDialogPay())
                    {
                        fpay.total = frm.Total;
                        if (frm.txtsearch.Text == "")
                        {
                            fpay.receipt = frm.Total;
                            fpay.change = 0;
                            frm.lbCash.Text = frm.Total.ToString("N0");
                            frm.lbChange.Text = "0.00";
                        }
                        else if (decimal.Parse(frm.txtsearch.Text) + frm.Receipt >= frm.Total)
                        {
                            fpay.receipt = (decimal.Parse(frm.txtsearch.Text) + frm.Receipt);
                            fpay.change = Math.Abs((decimal.Parse(frm.txtsearch.Text) + frm.Receipt) - frm.Total);
                            frm.lbCash.Text = (decimal.Parse(frm.txtsearch.Text) + frm.Receipt).ToString("N2");
                            frm.lbChange.Text = ((decimal.Parse(frm.txtsearch.Text) + frm.Receipt) - frm.Total).ToString("N2");
                        }
                        frm.LoadList();
                        fpay.ShowDialog();
                    }

                    frm.ResetSale();
                    frm.uC_Sale1.BringToFront();
                    frm.LoadList();
                    loadImage();
                    ds.Dispose();
                }
            }
        }
        private void PayByMoney(decimal money)
        {
            decimal points = 0, totalPoints = 0;
            if (frm.isOpenBill && frm.Total != 0)
            {
                frm.Discount = Math.Abs(frm.Discount);
                if ((money + frm.Receipt) >= frm.Total)
                {
                    SalePaymentModel payment = new SalePaymentModel
                    {
                        sale_id = frm.SaleID,
                        paymentseq = saleService.CreatePaymentSeq(frm.SaleID),
                        payment_datetime = DateTime.Now,
                        fk_payment_method_id = 1,
                        payment_value = frm.Total,
                        payment_receive = money,
                        payment_change = (frm.Receipt + money) - frm.Total,
                        fk_terminal_id = frm.TerminalID,
                        fk_user_id = frm.EmpID,
                        interfacestatus = "T"
                    };
                    saleService.InsertSalePayment(payment);
                }
                else if ((money + frm.Receipt) < frm.Total)
                {
                    SalePaymentModel payment = new SalePaymentModel
                    {
                        sale_id = frm.SaleID,
                        paymentseq = saleService.CreatePaymentSeq(frm.SaleID),
                        payment_datetime = DateTime.Now,
                        fk_payment_method_id = 1,
                        payment_value = frm.Total,
                        payment_receive = money,
                        payment_change = 0,
                        fk_terminal_id = frm.TerminalID,
                        fk_user_id = frm.EmpID,
                        interfacestatus = "T"
                    };
                    saleService.InsertSalePayment(payment);
                }

                frm.Receipt = saleService.SUMPaymentReceipt(frm.SaleID);
                frm.CashChange = frm.Receipt - frm.Total;

                if (frm.Receipt >= frm.Total)
                {
                    frm.LoadList();
                    frm.isOpenBill = false;
                    if (frm.isMember == true)
                    {
                        points = saleService.SUMPoints(frm.SaleID);
                        totalPoints = (frm.MemberPoints + points) - frm.PointUsed;
                        if (points > 0)
                        {
                            MemberPointModel memberReceive = new MemberPointModel
                            {
                                fk_member_id = frm.MemberID,
                                fk_sale_id = frm.SaleID,
                                item_cost = saleService.CalCostPrice(frm.SaleID),
                                net_amount = frm.Total,
                                points = points,
                                saledate = DateTime.Now,
                                type = "Receive",
                                sale_status = "S",
                                interfacestatus = "T"
                            };
                            saleService.InsertMemberPoint(memberReceive);
                        }
                        this.tbFreeItem.FillBySaleID(ds.ospos_freeitem, frm.SaleID);
                        if (ds.ospos_freeitem.Rows.Count > 0)
                        {
                            redeemService.UpdateStatusFreeItem(frm.SaleID, "S", "T");

                            MemberPointModel memberApply = new MemberPointModel
                            {
                                fk_member_id = frm.MemberID,
                                fk_sale_id = frm.SaleID,
                                item_cost = saleService.CalCostPrice(frm.SaleID),
                                net_amount = frm.Total,
                                points = -frm.PointUsed,
                                saledate = DateTime.Now,
                                type = "Apply",
                                sale_status = "S",
                                interfacestatus = "T"
                            };
                            saleService.InsertMemberPoint(memberApply);
                        }
                    }
                    //************************************************************//
                    saleService.UpdateSaleDetailStatus(frm.SaleID, "S", "T");

                    SaleModel sale = new SaleModel
                    {
                        sale_id = frm.SaleID,
                        sale_status = "S",
                        closedate = DateTime.Now,
                        lastupdate = DateTime.Now,
                        close_terminal_id = frm.TerminalID,
                        close_user_id = frm.EmpID,
                        fk_member_id = frm.MemberID,
                        points = points,
                        total_points = totalPoints,
                        remark = " ",
                        interfacestatus = "T",
                    };
                    saleService.UpdateCloseSale(sale);


                    this.tbCashDrawer.InsertQuery(DateTime.Now.Date, DateTime.Now, frm.TerminalID, frm.EmpID, 1,
                        "5", "sale", frm.Total, "F", DateTime.Now, "F");

                    Task.Run(() => PrintBill(frm.SaleID));
                    sync.syncAllData(frm.BaseURL, frm.StoreID, frm.Token);
                    frm.OpenCashDrawer();

                    using (frmDialogPay fpay = new frmDialogPay())
                    {
                        fpay.total = frm.Total;
                        fpay.receipt = frm.Receipt;
                        fpay.change = frm.CashChange;
                        fpay.ShowDialog();
                    }

                    frm.ResetSale();
                    frm.uC_Sale1.BringToFront();
                }
                frm.LoadList();
                loadImage();
                ds.Dispose();
            }
        }
        private void PrintBill(int saleID)
        {
            RMSDataSet md = new RMSDataSet();

            CRInvoice invoice = new CRInvoice();

            PrinterSettings ps = new PrinterSettings();
            md.EnforceConstraints = false;
            tbListInvoice.FillBySaleID(md.ListForInvoice, saleID);
            tbInvoice.FillBySaleID(md.InvoiceDetail, saleID);
            tbGetPayment.Fill(md.GetPayment, saleID);
            tbTerminal.FillByTerminalID(md.Terminal, frm.TerminalID);
            tbStore.Fill(md.ospos_store);
            tbCompany.FillBy(md.ospos_company);

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
        }
        private void btnSubtotal_Click(object sender, EventArgs e)
        {

        }
        private void EnterMoney(object e)
        {
            Button b = (Button)e;
            frm.txtsearch.Text += b.Text;
            EnterPay = true;
        }
        private void button29_Click(object sender, EventArgs e)
        {
            EnterMoney(sender);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            EnterMoney(sender);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            EnterMoney(sender);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            EnterMoney(sender);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            EnterMoney(sender);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            EnterMoney(sender);
        }
        private void button35_Click(object sender, EventArgs e)
        {
            EnterMoney(sender);
        }
        private void button36_Click(object sender, EventArgs e)
        {
            EnterMoney(sender);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            EnterMoney(sender);
        }
        private void button39_Click(object sender, EventArgs e)
        {
            EnterMoney(sender);
        }
        private void btnClr_Click(object sender, EventArgs e)
        {
            frm.txtsearch.Clear();
            this.EnterPay = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            frm.InsertCheck();
        }
        private void btn5000_Click(object sender, EventArgs e)
        {
            PayByMoney(5000);
        }
        private void btn10000_Click(object sender, EventArgs e)
        {
            PayByMoney(10000);
        }
        private void btn20000_Click(object sender, EventArgs e)
        {
            PayByMoney(20000);
        }
        private void btn50000_Click(object sender, EventArgs e)
        {
            PayByMoney(50000);
        }
        private void btn100000_Click(object sender, EventArgs e)
        {
            PayByMoney(100000);
        }
        private void btnDleteItem_Click(object sender, EventArgs e)
        {
            frm.uC_Sale1.btndeleteitem_Click(sender, e);
        }

        private void btnQRPay_Click(object sender, EventArgs e)
        {
            if (frm.isMember == false)
            {
                FrmEnterCustomerID CusFrm = new FrmEnterCustomerID(frm);
                CusFrm.ShowDialog();
                CusFrm.Dispose();
                if (frm.isMember == true)
                {
                    frm.uC_Reward.BringToFront();
                    frm.uC_Reward.LoadPoints();
                }
            }
            else if (frm.isMember == true)
            {
                frm.uC_Reward.BringToFront();
                frm.uC_Reward.LoadPoints();
            }
            frm.LoadList();
            //decimal vat_rate = (decimal)vatTableAdapter1.ScalarQuery();
            //if (frm.isConnect)
            //{
            //    if (FrmDialogYesNo.Show("Online Payment", "Confirm To Payment") == DialogResult.Yes)
            //    {
            //        frm.dis = Math.Abs(frm.dis);
            //        FrmQRPayment DialogQR = new FrmQRPayment();
            //        DialogQR.ShowDialog();

            //        if (DialogQR.PaymnetType == 1)
            //        {
            //            QR = new GenerateQR();
            //            QR.amount = (frm.TotalAmount - frm.dis).ToString();
            //            QR.store = frm.CompanyName;
            //            QR.invoiceid = Convert.ToString(frm.CheckSeq);
            //            QR.transactionid = Convert.ToString(frm.CheckSeq);
            //            frm.Monitor.PicPromotion.BackgroundImage = Properties.Resources.bcel_onepay_6d112631d9a7416d250b1095cef73db0ae26925465dd751f2912236718622ba1;
            //            frm.Monitor.PicPromotion.BackgroundImageLayout = ImageLayout.Stretch;
            //            frm.Monitor.PicPromotion.SizeMode = PictureBoxSizeMode.CenterImage;
            //            frm.Monitor.timerChangeImage.Stop();
            //            frm.Monitor.PicPromotion.Image = QR.QRImage_BCEL(QR.GenNumberBCEL());
            //        }
            //        else if (DialogQR.PaymnetType == 2)
            //        {
            //            QR = new GenerateQR();
            //            QR.amount = (frm.TotalAmount - frm.dis).ToString();
            //            QR.store = frm.CompanyName;
            //            QR.invoiceid = Convert.ToString(frm.CheckSeq);//.ToString();
            //            QR.transactionid = Convert.ToString(frm.CheckSeq);//.ToString();
            //            frm.Monitor.PicPromotion.BackgroundImage = Properties.Resources.SOKXAYALL_CARD_PAY;
            //            frm.Monitor.PicPromotion.BackgroundImageLayout = ImageLayout.Stretch;
            //            frm.Monitor.PicPromotion.SizeMode = PictureBoxSizeMode.CenterImage;
            //            frm.Monitor.timerChangeImage.Stop();
            //            frm.Monitor.PicPromotion.Image = QR.QRImage_BCEL(
            //                Properties.Settings.Default.storeID + ";" + Properties.Settings.Default.storeID.ToString() + "-" + frm.CheckSeq + ";" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "; " +
            //               (frm.TotalAmount - frm.dis -frm.Receipt).ToString("#") + ";" + (Math.Floor((frm.TotalAmount - frm.dis - frm.Receipt) / Properties.Settings.Default.storePoint)).ToString() + "; " + Properties.Settings.Default.e_otp + "; " + Properties.Settings.Default.e_userid);
            //            using (FrmConfirmPayment fm = new FrmConfirmPayment())
            //            {
            //                fm.pay.billNumber = Properties.Settings.Default.storeID.ToString() + "-" + frm.CheckSeq;
            //                fm.ShowDialog();
            //                if (fm.Conf == false)
            //                {
            //                    loadImage();
            //                    return;
            //                }
            //                var Cardtype = "";
            //                requests.point = int.Parse(Math.Floor(frm.TotalAmount / Properties.Settings.Default.storePoint).ToString());

            //                if (fm.res.cardTypeId == 1)
            //                {
            //                    Cardtype = "Sokxay Point Card";
            //                    requests.point = 0;
            //                }
            //                else if (fm.res.cardTypeId == 2)
            //                {
            //                    Cardtype = "Sokxay Debit Card";
            //                }
            //                else if (fm.res.cardTypeId == 3)
            //                {
            //                    Cardtype = "Sokxay Credit Card";
            //                }
            //                if (fm.res.resultCode == "OK")
            //                {
            //                    frm.bill = false;
            //                    frm.lbPay.Text = Convert.ToString(frm.TotalAmount - frm.dis -frm.Receipt);// frm.TotalAmount.ToString("N2");
            //                    frm.lbChange.Text = "0.00";

            //                    checkPaymentsTableAdapter1.InsertQuery(frm.CheckSeq, (int)checkPaymentsTableAdapter1.PaymentSeq(frm.CheckSeq), DateTime.Now,
            //                    this.paymentTableAdapter1.PaymentID(Cardtype), Cardtype, 2, (frm.TotalAmount -frm.Receipt) - frm.dis, (frm.TotalAmount - frm.Receipt) - frm.dis,
            //                        0, frm.TerminalID, frm.emp);
            //                    if (frm.dis < 0)
            //                        frm.dis *= (-1);
            //                    frm.dis = Math.Abs(frm.dis);
            //                    this.checkDetailsTableAdapter1.UpdateSale(frm.CheckSeq);
            //                    string recNo = this.ReceiptNo();
            //                    this.checksTableAdapter1.UpdateQueryPayment(recNo, "S", frm.TotalAmount, (frm.TotalAmount * frm.vat_rate) / (100 + frm.vat_rate),frm.dis, frm.TotalAmount - frm.dis, DateTime.Now, DateTime.Now, frm.TerminalID, DateTime.Now.Date, frm.emp, requests.point, frm.CheckSeq);
            //                    this.posCashDrawerTableAdapter1.InsertQuery(DateTime.Now.Date, DateTime.Now, frm.TerminalID, frm.emp, 1, "5", string.Empty, frm.TotalAmount + frm.dis, "F", DateTime.Now, "F");
            //                    PrintBill(frm.CheckSeq, true);
            //                    using (frmDialogPay fpay = new frmDialogPay())
            //                    {
            //                        fpay.total = decimal.Parse(Convert.ToString(frm.TotalAmount)).ToString("N2");
            //                        if (frm.txtsearch.Text == "")
            //                        {
            //                            fpay.receipt = (frm.TotalAmount + frm.dis).ToString("N2");
            //                            fpay.change = "0.00";
            //                        }
            //                        else if (decimal.Parse(frm.txtsearch.Text) > (frm.TotalAmount + frm.dis) - frm.Receipt)
            //                        {
            //                            fpay.receipt = decimal.Parse(frm.txtsearch.Text).ToString("N2");
            //                            fpay.change = (decimal.Parse(frm.txtsearch.Text) - frm.TotalAmount + frm.dis).ToString("N2");
            //                        }

            //                        fpay.ShowDialog();
            //                    }
            //                    frm.CheckSeq = 0;
            //                    frm.Receipt = 0;
            //                    frm.CashChange = 0;
            //                    frm.TotalAmount = 0;
            //                    frm.uC_Sale1.BringToFront();
            //                    frm.LoadList();
            //                    loadImage();
            //                }
            //            }
            //        }


            //    }
            //}
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public class ResponeAPI
        {
            public string messageResult { get; set; }
            public string resultCode { get; set; }
        }
        public class RequestAPI
        {
            public string FileStream { get; set; }
        }
    }
}
