using POS.ClassControl;
using POS.Forms;
using POS.Models;
using POS.Models.RMSDataSetTableAdapters;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Forms;
using System.IO.Ports;

namespace POS
{
    public partial class FrmMain : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Des, int Reserve);
        //New
        public int SaleID = 0, DetailSeq = 0, ItemQty = 0, PaySeq = 0, DeleteType = 0, SaleNO = 0, MemberID = 0, ProdID = 0, Weight = 0, StoreID = 0, Margin_Point = 0;
        public decimal SubTotal = 0, Total = 0, CashChange = 0, ItemValue = 0, ItemDiscount = 0, Discount = 0, Receipt = 0, MemberPoints = 0, PointUsed = 0;
        public string Role, Permission, MemberName, MemberPhone, EmpID, TerminalID, Pass, Barcode, BaseURL, Token, Maker;
        public bool isOpenBill = false, isMember = false, isDiscount = false, isAdjust = false, isDelete = false, isConnect = false, isWeight = false;

        public UC_Payment uC_Payment1;
        public UC_Sale uC_Sale1;
        public UC_Reward uC_Reward;
        public FrmLogin fmlogin;
        public FrmMonitor Monitor;
        public UC_Manage _Manage;

        LogError er = new LogError();

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        RMSDataSet ds = new RMSDataSet();

        private void label21_Click(object sender, EventArgs e)
        {

        }

        SaleService saleService = new SaleService();

        TerminalTableAdapter tbTerminal = new TerminalTableAdapter();
        ospos_usersTableAdapter tbUser = new ospos_usersTableAdapter();
        ospos_saleTableAdapter tbSale = new ospos_saleTableAdapter();
        ospos_sale_detailsTableAdapter tbSaleDetail = new ospos_sale_detailsTableAdapter();
        ospos_product_itemTableAdapter tbProductItem = new ospos_product_itemTableAdapter();
        SellListTableAdapter tbSellList = new SellListTableAdapter();
        ospos_freeitemconditionTableAdapter tbFreeCond = new ospos_freeitemconditionTableAdapter();
        ospos_freeitemTableAdapter tbFreeItem = new ospos_freeitemTableAdapter();
        PromotionsTableAdapter tbPromotion = new PromotionsTableAdapter();
        ospos_companyTableAdapter tbCompany = new ospos_companyTableAdapter();
        ospos_users_roleTableAdapter tbRole = new ospos_users_roleTableAdapter();
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(FrmLogin fmlg, string role, string uid)
        {
            fmlogin = fmlg;
            EmpID = uid;
            Role = role;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtsearch.Focus();
            Monitor = new FrmMonitor(this);
            uC_Payment1 = new UC_Payment(this);
            uC_Sale1 = new UC_Sale(this);
            _Manage = new UC_Manage(this);
            uC_Reward = new UC_Reward(this);
            _Manage.Dock = DockStyle.Fill;
            uC_Payment1.Dock = DockStyle.Fill;
            uC_Sale1.Dock = DockStyle.Fill;
            uC_Reward.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uC_Payment1);
            pnlMain.Controls.Add(uC_Sale1);
            pnlMain.Controls.Add(uC_Reward);
            pnlParent.Controls.Add(_Manage);
            uC_Sale1.BringToFront();
            lbAuth.Text = tbRole.GetRole(Role);
            TerminalID = tbTerminal.TerminalID(Environment.MachineName).ToString();
            lbPC.Text = tbTerminal.TerminalName(TerminalID).ToString();
            lbEmpName.Text = EmpID + " " + tbUser.GetName(EmpID.ToString());
            timer1.Start();
            lbVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lbTitleVat.Text = ("ອມພ " + saleService.GeTax() + "%");
            if (Screen.AllScreens.Length > 1)
            {
                Screen screen = GetSecondaryScreen();
                Monitor.Location = screen.WorkingArea.Location;
                //Monitor.TopMost = true;
                Monitor.emp = lbEmpName.Text;
                try
                {
                    Monitor.Show();
                }
                catch (OutOfMemoryException ex)
                {
                    er.NewError(ex.Message, "Show Monitor");
                }
            }

            BaseURL = tbCompany.GetIPServer();
            Token = tbCompany.GetToken();
            StoreID = saleService.GetStoreID();
            Margin_Point = saleService.GetMargin();
        }

        public Screen GetSecondaryScreen()
        {
            if (Screen.AllScreens.Length == 1)
            {
                return null;
            }

            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.Primary == false)
                {
                    return screen;
                }
            }

            return null;
        }
        public void mini()
        {
            this.TopMost = false;
            this.WindowState = FormWindowState.Minimized;
        }
        public void LoadList()
        {
            WindowState = FormWindowState.Maximized;
            Monitor.WindowState = FormWindowState.Maximized;
            if (this.SaleID != 0)
            {
                gridItem.DataSource = tbSellList.GetData(SaleID);
                gridItem.Refresh();
            }
            else
            {
                gridItem.DataSource = null;
            }
            gridItem.ClearSelection();
            if (gridItem.Rows.Count > 0)
            {
                gridItem.FirstDisplayedScrollingRowIndex = gridItem.RowCount - 1;
            }
            DispCash();
            txtsearch.Focus();
            Monitor.SaleID = this.SaleID;
            Monitor.SaleNO = this.SaleNO;
            Monitor.lbPoints.Text = (MemberPoints - PointUsed).ToString("N0");
            GrandTotal();
            Monitor.LoadList();
            UpdateSale();
        }

        public void GrandTotal()
        {
            decimal total = 0, discount = 0;
            Receipt = 0;
            foreach (DataGridViewRow row in gridItem.Rows)
            {
                if (row.Cells[sortbyDataGridViewTextBoxColumn.Name].Value.ToString() == "1")
                {
                    total += decimal.Parse(row.Cells[totalDataGridViewTextBoxColumn.Name].Value.ToString());
                    discount += decimal.Parse(row.Cells[itemdiscountDataGridViewTextBoxColumn.Name].Value.ToString());
                }
                else if (row.Cells[sortbyDataGridViewTextBoxColumn.Name].Value.ToString() == "2")
                {
                    total += decimal.Parse(row.Cells[totalDataGridViewTextBoxColumn.Name].Value.ToString());
                    discount += decimal.Parse(row.Cells[itemdiscountDataGridViewTextBoxColumn.Name].Value.ToString());
                }
                else if (row.Cells[sortbyDataGridViewTextBoxColumn.Name].Value.ToString() == "3")
                {
                    Receipt += decimal.Parse(row.Cells[totalDataGridViewTextBoxColumn.Name].Value.ToString());
                }
            }
            Discount = Math.Abs(discount);
            Total = total;
            SubTotal = total + discount;

            lbBil.Text = SaleNO.ToString();
            lbSubtotal.Text = (SubTotal).ToString("N0");
            lbDiscount.Text = Discount.ToString("N0");
            lbVat.Text = saleService.CalVat(SubTotal).ToString("N0");
            lbTotal.Text = (Total).ToString("N0");
            lbCash.Text = Receipt.ToString("N0");
            lbPoints.Text = (MemberPoints - PointUsed).ToString("N0");
        }
        public void DispCash()
        {
            this.txtsearch.Clear();
            lbCash.Text = Receipt.ToString("N0");
            Monitor.Receipt = Receipt;
            if (Receipt >= Total)
            {
                lbChange.Text = (Total - Receipt).ToString("N0").Replace("-", string.Empty);
            }
            else
            {
            }

        }
        int des;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
            lbClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            try
            {
                if (InternetGetConnectedState(out des, 0))
                {
                    lbISonline.Text = "Online";
                    lbISonline.BackColor = Color.Lime;
                    isConnect = true;
                }
                else
                {
                    lbISonline.Text = "Offline";
                    lbISonline.BackColor = Color.Red;
                    isConnect = true;
                }
            }
            catch (Exception ex)
            {
                er.NewError(ex.Message, "Timer Check Internet");
            }

        }

        private void gridItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridItem.CurrentRow.Cells[sortbyDataGridViewTextBoxColumn.Name].Value.ToString() == "1" && (decimal)gridItem.CurrentRow.Cells[itempriceDataGridViewTextBoxColumn.Name].Value != 0)
            {
                isDiscount = true;
                isAdjust = true;
                isDelete = true;
                DeleteType = 1;
                ItemQty = int.Parse(((decimal)gridItem.CurrentRow.Cells[itemqtyDataGridViewTextBoxColumn.Name].Value).ToString().Replace(".00", string.Empty));
                this.DetailSeq = (int)gridItem.CurrentRow.Cells[saledetailseqDataGridViewTextBoxColumn.Name].Value;
            }
            else if (gridItem.CurrentRow.Cells[sortbyDataGridViewTextBoxColumn.Name].Value.ToString() == "1" && (decimal)gridItem.CurrentRow.Cells[itempriceDataGridViewTextBoxColumn.Name].Value == 0)
            {
                isDelete = true;
                isAdjust = false;
                DeleteType = 1;
            }
            else if (gridItem.CurrentRow.Cells[sortbyDataGridViewTextBoxColumn.Name].Value.ToString() == "2")
            {
                isDiscount = true;
                isDelete = true;
                isAdjust = false;
                DeleteType = 1;
                ItemQty = int.Parse(((decimal)gridItem.CurrentRow.Cells[itemqtyDataGridViewTextBoxColumn.Name].Value).ToString().Replace(".00", string.Empty));
                this.DetailSeq = (int)gridItem.CurrentRow.Cells[saledetailseqDataGridViewTextBoxColumn.Name].Value;
            }
            else if (gridItem.CurrentRow.Cells[sortbyDataGridViewTextBoxColumn.Name].Value.ToString() == "3")
            {
                this.PaySeq = int.Parse(gridItem.CurrentRow.Cells[saledetailseqDataGridViewTextBoxColumn.Name].Value.ToString());
                isDiscount = false;
                isDelete = true;
                DeleteType = 3;
            }
            this.ItemValue = decimal.Parse(gridItem.CurrentRow.Cells[totalDataGridViewTextBoxColumn.Name].Value.ToString());
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertCheck();
            }
        }
        public void OpenCashDrawer()
        {
            PrinterSettings ps = new PrinterSettings();
            string draw = Convert.ToString((char)27) + Convert.ToString((char)112) + Convert.ToString((char)48) + Convert.ToString((char)64) + Convert.ToString((char)64);
            RawPrinterHelper.SendStringToPrinter(ps.PrinterName, draw);
        }
        public void OpenCashDrawer2()
        {
            SerialPort serialPort = new SerialPort("COM3"); // Change "COM1" to your actual serial port
            serialPort.BaudRate = 9600; // Set baud rate
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.DataBits = 8;

            try
            {
                // Open the serial port
                serialPort.Open();

                // Send command to open the cash drawer
                // Note: Replace "your_open_command" with the appropriate command for your cash drawer model
                string command = "your_open_command";
                serialPort.Write(command);

                Console.WriteLine("Cash drawer opened successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening cash drawer: " + ex.Message);
            }
            finally
            {
                // Close the serial port
                serialPort.Close();
            }
        
    }
        public void InsertCheck()
        {
            Barcode = txtsearch.Text;
            if (txtsearch.Text.StartsWith(Properties.Settings.Default.prefix_weight_barcode))
            {
                Barcode = txtsearch.Text.Substring(2, 5);
                Weight = int.Parse(txtsearch.Text.Substring(7, 5));
                isWeight = true;
            }
            if (isOpenBill)
            {
                ds.ospos_product_item.Clear();
                tbProductItem.FillByBarcode(ds.ospos_product_item, Barcode);
                if (ds.ospos_product_item.Rows.Count > 0)
                {
                    insertDetail();
                }
                else
                {
                    FrmDialogOK.Show("Not Found Product", "Wanning");
                }
            }
            else
            {
                ds.ospos_product_item.Clear();
                tbProductItem.FillByBarcode(ds.ospos_product_item, Barcode);
                if (ds.ospos_product_item.Rows.Count > 0)
                {
                    this.SaleNO = saleService.GetSaleNO();
                    SaleID = saleService.GetSaleID();

                    SaleModel sale = new SaleModel
                    {
                        sale_id = SaleID,
                        sale_no = SaleNO,
                        fk_sale_channel_id = 1,
                        receipt_no = DateTime.Now.ToString("yyMMddhhmmss"),
                        fk_terminal_id = TerminalID,
                        fk_user_id = EmpID,
                        sale_status = "O",
                        opendate = DateTime.Now,
                        closedate = null,
                        subtotal_amount = SubTotal,
                        discount_amount = Discount,
                        vat_amount = saleService.CalVat(SubTotal),
                        netprice_amount = Total,
                        cost_amount = saleService.CalCostPrice(SaleID),
                        remark = " ",
                        lastupdate = null,
                        close_terminal_id = null,
                        close_user_id = null,
                        fk_member_id = 0,
                        points = 0,
                        total_points = 0,
                        margin_points = Margin_Point,
                        interfacestatus = "T",
                    };

                    saleService.InsertSale(sale);
                    Properties.Settings.Default.SaleID = SaleID;
                    Properties.Settings.Default.Save();
                    isOpenBill = true;
                    insertDetail();
                }
                else
                {
                    FrmDialogOK.Show("Not Found Product", "Wanning");
                }
            }
            Barcode = string.Empty;
            Weight = 0;
            isWeight = false;
            ds.Dispose();
            txtsearch.Clear();
            txtsearch.Focus();
        }
        public void insertDetail()
        {
            decimal price = 0, costPrice = 0, originPrice = 0, quantity = 0, vat = 0, points = 0, qty = 0, baseprice = 0;
            this.tbFreeCond.FillBy(ds.ospos_freeitemcondition, txtsearch.Text);
            if (ds.ospos_freeitemcondition.Rows.Count > 0)
            {
                FrmDialogOK.Show("Cannot add this items", "");
                return;
            }

            int prodId = int.Parse(ds.ospos_product_item.Rows[0][ds.ospos_product_item.idColumn].ToString());
            string prodName = ds.ospos_product_item.Rows[0][ds.ospos_product_item.nameColumn].ToString();
            int unittype = int.Parse(ds.ospos_product_item.Rows[0][ds.ospos_product_item.fk_unittype_idColumn].ToString());

            if (isWeight)
            {
                baseprice = decimal.Parse(ds.ospos_product_item.Rows[0][ds.ospos_product_item.priceColumn].ToString());
                quantity = 1;
                price = Math.Ceiling(((baseprice * Weight) / 1000) / 500) * 500;
                originPrice = (baseprice * Weight) / 1000;
                costPrice = (decimal.Parse(ds.ospos_product_item.Rows[0][ds.ospos_product_item.custom_costColumn].ToString()) * Weight) / 1000;
                qty = Weight;
            }
            else
            {
                baseprice = decimal.Parse(ds.ospos_product_item.Rows[0][ds.ospos_product_item.priceColumn].ToString());
                originPrice = decimal.Parse(ds.ospos_product_item.Rows[0][ds.ospos_product_item.priceColumn].ToString());
                quantity = decimal.Parse(ds.ospos_product_item.Rows[0][ds.ospos_product_item.quantityColumn].ToString());
                costPrice = decimal.Parse(ds.ospos_product_item.Rows[0][ds.ospos_product_item.custom_costColumn].ToString());
                qty = 1;
            }

            vat = saleService.CalVat(originPrice);
            points = saleService.Points(originPrice, costPrice, 0);
            int detailSeq = saleService.GetDetailSeq(prodId, SaleID);
            if (detailSeq > 0 && unittype != 4)
            {
                saleService.UpdateAddQty(SaleID, detailSeq, 1, vat, points);
            }
            else
            {
                SaleDetailModel detail = new SaleDetailModel
                {
                    sale_id = SaleID,
                    sale_detailseq = saleService.CreateDetailSeq(SaleID),
                    sale_datetime = DateTime.Now,
                    fk_product_item_id = prodId,
                    product_item_name = prodName,
                    item_qty = qty,
                    qty_peice = quantity,
                    item_price = baseprice,
                    item_vat = vat,
                    item_discount = 0,
                    item_netprice = baseprice,
                    item_costprice = costPrice,
                    item_priceorigin = originPrice,
                    item_status = "O",
                    promo_type = " ",
                    points = points,
                    interfacestatus = "T",
                };
                saleService.InsertSaleDetail(detail);
            }
            PromotionService(prodId);
            CheckQuantity(prodId);
            LoadList();
        }
        public void UpdateSale()
        {
            SaleModel saleValues = new SaleModel
            {
                sale_id = SaleID,
                subtotal_amount = SubTotal,
                discount_amount = Discount,
                vat_amount = saleService.CalVat(SubTotal),
                netprice_amount = Total,
                cost_amount = saleService.CalCostPrice(SaleID),
            };
            saleService.UpdateSaleValues(saleValues);
        }
        public void ClearFreeitem()
        {
            try
            {
                this.tbFreeItem.FillBySaleID(ds.ospos_freeitem, SaleID);
                if (ds.ospos_freeitem.Rows.Count > 0)
                {
                    foreach (RMSDataSet.ospos_freeitemRow item in ds.ospos_freeitem)
                    {
                        this.tbSaleDetail.DeleteSaleDetail(item.sale_id, item.sale_detailseq);
                        this.tbFreeItem.DeleteQuery(item.sale_id, item.sale_detailseq);
                    }
                    LoadList();
                    ds.Dispose();
                    this.Close();
                }
            }
            catch (Exception)
            {
            }
        }
        public void ClearSelected()
        {
            if (gridItem.RowCount > 0)
            {
                this.gridItem.CurrentCell.Selected = false;
            }
        }

        public void ResetSale()
        {
            this.SaleID = 0;
            this.DetailSeq = 0;
            this.ItemQty = 0;
            this.PaySeq = 0;
            this.DeleteType = 0;
            this.SaleNO = 0;
            this.SubTotal = 0;
            this.Total = 0;
            this.CashChange = 0;
            this.ItemValue = 0;
            this.ItemDiscount = 0;
            this.Discount = 0;
            this.Receipt = 0;
            this.MemberPoints = 0;
            this.PointUsed = 0;
            this.isMember = false;
            this.MemberID = 0;
            this.MemberPhone = "-";
            this.MemberName = "";
            this.lbMember.Text = "0.00";
            this.lbPoints.Text = "0.00";
            this.lbChange.Text = "0.00";
            Monitor.lbMember.Text = "";
            Monitor.lbPoints.Text = "0.00";
        }

        public void PromotionService(int prodID)
        {
            RMSDataSet md = new RMSDataSet();
            frmPromotionItemFree pf = new frmPromotionItemFree(this);

            this.tbPromotion.FillByProdID(md.Promotions, prodID);
            this.tbSaleDetail.FillBySaleIDProdID(md.ospos_sale_details, SaleID, prodID);
            if (md.Promotions.Rows.Count > 0 && md.ospos_sale_details.Rows.Count > 0)
            {
                int promoID = (int)md.Promotions.Rows[0][md.Promotions.promo_idColumn];
                string proName = md.Promotions.Rows[0][md.Promotions.promo_nameColumn].ToString();
                string type = md.Promotions.Rows[0][md.Promotions.promo_typeColumn].ToString();
                decimal dis_price = (decimal)md.Promotions.Rows[0][md.Promotions.discountColumn];
                decimal minimum = (decimal)md.Promotions.Rows[0][md.Promotions.qtyColumn];

                decimal qty = (decimal)md.ospos_sale_details.Rows[0][md.ospos_sale_details.item_qtyColumn];
                decimal original_price = (decimal)md.ospos_sale_details.Rows[0][md.ospos_sale_details.item_priceoriginColumn];
                decimal cost_price = (decimal)md.ospos_sale_details.Rows[0][md.ospos_sale_details.item_costpriceColumn];
                decimal points = saleService.Points(original_price, cost_price, 0) * qty;
                decimal disQty = Math.Floor(qty / minimum);
                bool is_free = false;

                if (ProdID != prodID)
                {
                    ProdID = prodID;
                    FrmDialogOK.Show(proName, "Promotion!");
                }

                switch (type)
                {
                    case "price":
                        if (qty >= minimum)
                        {
                            SaleDetailModel saleDetail = new SaleDetailModel
                            {
                                sale_id = SaleID,
                                fk_product_item_id = prodID,
                                item_price = dis_price,
                                item_discount = 0,
                                item_netprice = dis_price * qty,
                                fk_promo_dis_id = promoID,
                                fk_promo_free_id = 0,
                                promo_type = type,
                                points = 0
                            };
                            saleService.UpdatePromoPrice(saleDetail);
                        }
                        else
                        {
                            SaleDetailModel saleDetail = new SaleDetailModel
                            {
                                sale_id = SaleID,
                                fk_product_item_id = prodID,
                                item_price = original_price,
                                item_discount = 0,
                                item_netprice = original_price * qty,
                                fk_promo_dis_id = 0,
                                fk_promo_free_id = 0,
                                promo_type = " ",
                                points = points,
                            };
                            saleService.UpdatePromoPrice(saleDetail);
                        }
                        break;
                    case "discount":
                        if (qty >= minimum)
                        {
                            SaleDetailModel saleDetail = new SaleDetailModel
                            {
                                sale_id = SaleID,
                                fk_product_item_id = prodID,
                                item_discount = dis_price * disQty,
                                fk_promo_dis_id = promoID,
                                fk_promo_free_id = 0,
                                promo_type = type,
                            };
                            saleService.UpdatePromoDis(saleDetail);
                        }
                        else
                        {
                            SaleDetailModel saleDetail = new SaleDetailModel
                            {
                                sale_id = SaleID,
                                fk_product_item_id = prodID,
                                item_discount = 0,
                                fk_promo_dis_id = 0,
                                fk_promo_free_id = 0,
                                promo_type = " ",
                                points = points,
                            };
                            saleService.UpdatePromoDis(saleDetail);
                        }
                        break;
                    case "free":
                        RMSDataSet m = new RMSDataSet();
                        this.tbPromotion.FillByPromoID(m.Promotions, promoID);
                        string prodName = saleService.GetProdName((int)m.Promotions.Rows[0][m.Promotions.product_idColumn]);

                        int freeID = (int)m.Promotions.Rows[0][m.Promotions.product_idColumn];
                        decimal freeQty = (decimal)m.Promotions.Rows[0][m.Promotions.qtyColumn];
                        tbProductItem.FillByID(ds.ospos_product_item, freeID);
                        if (qty >= minimum)
                        {
                            saleService.DeletePromotionItem(SaleID, promoID, freeID);
                            pf.GridItem.Rows.Add(true, freeID, ds.ospos_product_item.Rows[0][ds.ospos_product_item.barcodeColumn].ToString(), prodName, freeQty * disQty, 0, type, promoID, (int)ds.ospos_product_item.Rows[0][ds.ospos_product_item.quantityColumn]);
                            is_free = true;
                        }
                        else
                        {
                            saleService.DeletePromotionItem(SaleID, promoID, freeID);
                            SaleDetailModel saleDetail = new SaleDetailModel
                            {
                                sale_id = SaleID,
                                fk_product_item_id = prodID,
                                fk_promo_free_id = 0,
                                promo_type = " ",
                                points = points,
                            };
                            saleService.UpdatePromoFree(saleDetail);
                        }
                        m.Dispose();
                        break;
                    default:
                        break;
                }
                if (is_free)
                {
                    pf.ShowDialog();
                }
            }
            UpdateSale();
            md.Dispose();
        }

        public void CheckQuantity(int prod_id)
        {
           
            RMSDataSet ds = new RMSDataSet();
            ds.EnforceConstraints = false;
            this.tbSaleDetail.FillBySaleIDProdID(ds.ospos_sale_details, SaleID, prod_id);
            if (ds.ospos_sale_details.Rows.Count > 0)
            {
                SaleDetailModel saleDetail = new SaleDetailModel
                {
                    sale_id = SaleID,
                    sale_detailseq = saleService.CreateDetailSeq(SaleID),
                    sale_datetime = DateTime.Now,
                    fk_product_item_id = (int)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.fk_product_item_idColumn],
                    product_item_name = ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.product_item_nameColumn].ToString(),
                    item_qty = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_qtyColumn],
                    qty_peice = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.qty_peiceColumn],
                    item_price = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_priceColumn],
                    item_vat = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_vatColumn],
                    item_discount = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_discountColumn],
                    item_netprice = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_netpriceColumn],
                    item_costprice = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_costpriceColumn],
                    item_priceorigin = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_priceoriginColumn],
                    item_status = ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.item_statusColumn].ToString(),
                    promo_type = ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.promo_typeColumn].ToString(),
                    points = (decimal)ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.pointsColumn],
                    interfacestatus = ds.ospos_sale_details.Rows[0][ds.ospos_sale_details.interfacestatusColumn].ToString(),
                  

            };
                int unit = (int)tbProductItem.ScalarQueryUnit(saleDetail.fk_product_item_id);
                ds.Dispose();

                if (unit == 3)
                {
                    this.tbProductItem.FillByQty(ds.ospos_product_item, Convert.ToInt32(saleDetail.item_qty), saleDetail.fk_product_item_id);
                    if (ds.ospos_product_item.Rows.Count > 0)
                    {
                        FrmUnitSize frm = new FrmUnitSize(this, saleDetail);
                        int seq = saleService.GetDetailSeq(saleDetail.fk_product_item_id, SaleID);
                        tbSaleDetail.DeleteSaleDetail(SaleID, seq);

                        foreach (RMSDataSet.ospos_product_itemRow item in ds.ospos_product_item.Rows)
                        {
                            frm.dataGridView.Rows.Add(item.id, item.barcode, item.name, Math.Floor(saleDetail.item_qty / item.quantity), item.size, item.quantity, item.price, item.custom_cost);
                        }

                        frm.ShowDialog();
                    }
                }
                else if (unit == 2)
                {
                    
                    this.tbProductItem.FillByBox(ds.ospos_product_item, Convert.ToInt32(saleDetail.item_qty), saleDetail.fk_product_item_id);
                    if (ds.ospos_product_item.Rows.Count > 0)
                    {
                        FrmUnitSize frm = new FrmUnitSize(this, saleDetail);
                        int seq = saleService.GetDetailSeq(saleDetail.fk_product_item_id, SaleID);
                        tbSaleDetail.DeleteSaleDetail(SaleID, seq);

                        foreach (RMSDataSet.ospos_product_itemRow item in ds.ospos_product_item.Rows)
                        {
                            frm.dataGridView.Rows.Add(item.id, item.barcode, item.name, Math.Floor(saleDetail.item_qty*saleDetail.qty_peice / item.quantity), item.size, item.quantity, item.price, item.custom_cost);
                        }

                        frm.ShowDialog();
                    }
                }
                else
                {
                    
                }
             
            }
            ds.Dispose();
                       
        }
    }
}
