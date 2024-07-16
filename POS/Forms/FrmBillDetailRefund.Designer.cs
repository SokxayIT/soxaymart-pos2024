namespace POS.Forms
{
    partial class FrmBillDetailRefund
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbReceivePoints = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.lbChange = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbPay = new System.Windows.Forms.Label();
            this.lbPaymentType = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbVat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMember = new System.Windows.Forms.Label();
            this.lbEmp = new System.Windows.Forms.Label();
            this.lbBil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridItem = new System.Windows.Forms.DataGridView();
            this.saleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saledetailseqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtypeiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnetpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcostpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceoriginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listRefundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rMSDataSet = new POS.Models.RMSDataSet();
            this.rMS_NEWDataSet = new POS.RMS_NEWDataSet();
            this.ospossalerefunddetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ospos_sale_refund_detailsTableAdapter = new POS.RMS_NEWDataSetTableAdapters.ospos_sale_refund_detailsTableAdapter();
            this.sellListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellListTableAdapter = new POS.Models.RMSDataSetTableAdapters.SellListTableAdapter();
            this.listRefundTableAdapter = new POS.Models.RMSDataSetTableAdapters.ListRefundTableAdapter();
            this.btnCancleBill = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRefundBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMS_NEWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ospossalerefunddetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellListBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbReceivePoints
            // 
            this.lbReceivePoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReceivePoints.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceivePoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbReceivePoints.Location = new System.Drawing.Point(361, 433);
            this.lbReceivePoints.Name = "lbReceivePoints";
            this.lbReceivePoints.Size = new System.Drawing.Size(353, 45);
            this.lbReceivePoints.TabIndex = 27;
            this.lbReceivePoints.Text = "0.00";
            this.lbReceivePoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridItem, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.69555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.30445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 917);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbReceivePoints, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.lbChange, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.lbPay, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.lbPaymentType, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.lbAmount, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.lbVat, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lbDiscount, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lbSubtotal, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbMember, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbEmp, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbBil, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 322);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.73875F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.826124F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.826124F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.826124F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.826124F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.826124F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.826124F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.826124F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.826124F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.826124F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.826124F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(717, 478);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(3, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(352, 45);
            this.label11.TabIndex = 26;
            this.label11.Text = "ໄດ້ຮັບ Points:";
            // 
            // lbChange
            // 
            this.lbChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChange.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbChange.Location = new System.Drawing.Point(361, 392);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(353, 41);
            this.lbChange.TabIndex = 11;
            this.lbChange.Text = "0.00";
            this.lbChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(3, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(352, 41);
            this.label10.TabIndex = 20;
            this.label10.Text = "ທອນ:";
            // 
            // lbPay
            // 
            this.lbPay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPay.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbPay.Location = new System.Drawing.Point(361, 351);
            this.lbPay.Name = "lbPay";
            this.lbPay.Size = new System.Drawing.Size(353, 41);
            this.lbPay.TabIndex = 10;
            this.lbPay.Text = "0.00";
            this.lbPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPaymentType
            // 
            this.lbPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPaymentType.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbPaymentType.Location = new System.Drawing.Point(3, 351);
            this.lbPaymentType.Name = "lbPaymentType";
            this.lbPaymentType.Size = new System.Drawing.Size(352, 41);
            this.lbPaymentType.TabIndex = 19;
            this.lbPaymentType.Text = "ຈ່າຍ:";
            // 
            // lbAmount
            // 
            this.lbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAmount.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbAmount.Location = new System.Drawing.Point(361, 310);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(353, 41);
            this.lbAmount.TabIndex = 30;
            this.lbAmount.Text = "0.00";
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(3, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(352, 41);
            this.label8.TabIndex = 31;
            this.label8.Text = "ລວມມູນຄ່າທັງໝົດ:";
            // 
            // lbVat
            // 
            this.lbVat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVat.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbVat.Location = new System.Drawing.Point(361, 269);
            this.lbVat.Name = "lbVat";
            this.lbVat.Size = new System.Drawing.Size(353, 41);
            this.lbVat.TabIndex = 8;
            this.lbVat.Text = "0.00";
            this.lbVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(3, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 41);
            this.label7.TabIndex = 17;
            this.label7.Text = "ອມພ 7%:";
            // 
            // lbDiscount
            // 
            this.lbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiscount.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbDiscount.Location = new System.Drawing.Point(361, 228);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(353, 41);
            this.lbDiscount.TabIndex = 7;
            this.lbDiscount.Text = "0.00";
            this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(3, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 41);
            this.label6.TabIndex = 16;
            this.label6.Text = "ສ່ວນຫຼຸດ:";
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubtotal.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbSubtotal.Location = new System.Drawing.Point(361, 187);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(353, 41);
            this.lbSubtotal.TabIndex = 6;
            this.lbSubtotal.Text = "0.00";
            this.lbSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSubtotal.Click += new System.EventHandler(this.lbSubtotal_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(3, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 41);
            this.label5.TabIndex = 15;
            this.label5.Text = "ລວມເງິນ:";
            // 
            // lbMember
            // 
            this.lbMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMember.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbMember.Location = new System.Drawing.Point(361, 136);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(353, 41);
            this.lbMember.TabIndex = 5;
            this.lbMember.Text = "0.00";
            this.lbMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbEmp
            // 
            this.lbEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmp.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbEmp.Location = new System.Drawing.Point(361, 95);
            this.lbEmp.Name = "lbEmp";
            this.lbEmp.Size = new System.Drawing.Size(353, 41);
            this.lbEmp.TabIndex = 4;
            this.lbEmp.Text = "0.00";
            this.lbEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBil
            // 
            this.lbBil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBil.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbBil.Location = new System.Drawing.Point(361, 0);
            this.lbBil.Name = "lbBil";
            this.lbBil.Size = new System.Drawing.Size(353, 54);
            this.lbBil.TabIndex = 21;
            this.lbBil.Text = "0.00";
            this.lbBil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "ເລກບິນ:";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel2.SetColumnSpan(this.panel8, 2);
            this.panel8.Location = new System.Drawing.Point(3, 180);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(711, 4);
            this.panel8.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 41);
            this.label3.TabIndex = 13;
            this.label3.Text = "Emp:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 41);
            this.label4.TabIndex = 14;
            this.label4.Text = "Member:";
            // 
            // gridItem
            // 
            this.gridItem.AllowUserToAddRows = false;
            this.gridItem.AllowUserToDeleteRows = false;
            this.gridItem.AutoGenerateColumns = false;
            this.gridItem.BackgroundColor = System.Drawing.Color.White;
            this.gridItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItem.ColumnHeadersVisible = false;
            this.gridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleidDataGridViewTextBoxColumn,
            this.saledetailseqDataGridViewTextBoxColumn,
            this.product_item_name,
            this.qtypeiceDataGridViewTextBoxColumn,
            this.itemqtyDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn,
            this.itemdiscountDataGridViewTextBoxColumn,
            this.itemnetpriceDataGridViewTextBoxColumn,
            this.itemcostpriceDataGridViewTextBoxColumn,
            this.itempriceoriginDataGridViewTextBoxColumn,
            this.pointsDataGridViewTextBoxColumn,
            this.item_vat});
            this.gridItem.DataSource = this.listRefundBindingSource;
            this.gridItem.Enabled = false;
            this.gridItem.Location = new System.Drawing.Point(3, 3);
            this.gridItem.Name = "gridItem";
            this.gridItem.ReadOnly = true;
            this.gridItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridItem.RowHeadersVisible = false;
            this.gridItem.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gridItem.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridItem.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridItem.RowTemplate.Height = 30;
            this.gridItem.RowTemplate.ReadOnly = true;
            this.gridItem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItem.Size = new System.Drawing.Size(717, 313);
            this.gridItem.TabIndex = 6;
            this.gridItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItem_CellContentClick);
            // 
            // saleidDataGridViewTextBoxColumn
            // 
            this.saleidDataGridViewTextBoxColumn.DataPropertyName = "sale_id";
            this.saleidDataGridViewTextBoxColumn.HeaderText = "sale_id";
            this.saleidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.saleidDataGridViewTextBoxColumn.Name = "saleidDataGridViewTextBoxColumn";
            this.saleidDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleidDataGridViewTextBoxColumn.Visible = false;
            this.saleidDataGridViewTextBoxColumn.Width = 150;
            // 
            // saledetailseqDataGridViewTextBoxColumn
            // 
            this.saledetailseqDataGridViewTextBoxColumn.DataPropertyName = "sale_detailseq";
            this.saledetailseqDataGridViewTextBoxColumn.HeaderText = "sale_detailseq";
            this.saledetailseqDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.saledetailseqDataGridViewTextBoxColumn.Name = "saledetailseqDataGridViewTextBoxColumn";
            this.saledetailseqDataGridViewTextBoxColumn.ReadOnly = true;
            this.saledetailseqDataGridViewTextBoxColumn.Visible = false;
            this.saledetailseqDataGridViewTextBoxColumn.Width = 150;
            // 
            // product_item_name
            // 
            this.product_item_name.DataPropertyName = "product_item_name";
            this.product_item_name.HeaderText = "product_item_name";
            this.product_item_name.MinimumWidth = 8;
            this.product_item_name.Name = "product_item_name";
            this.product_item_name.ReadOnly = true;
            this.product_item_name.Width = 240;
            // 
            // qtypeiceDataGridViewTextBoxColumn
            // 
            this.qtypeiceDataGridViewTextBoxColumn.DataPropertyName = "qty_peice";
            this.qtypeiceDataGridViewTextBoxColumn.HeaderText = "qty_peice";
            this.qtypeiceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qtypeiceDataGridViewTextBoxColumn.Name = "qtypeiceDataGridViewTextBoxColumn";
            this.qtypeiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtypeiceDataGridViewTextBoxColumn.Visible = false;
            this.qtypeiceDataGridViewTextBoxColumn.Width = 40;
            // 
            // itemqtyDataGridViewTextBoxColumn
            // 
            this.itemqtyDataGridViewTextBoxColumn.DataPropertyName = "item_qty";
            this.itemqtyDataGridViewTextBoxColumn.HeaderText = "item_qty";
            this.itemqtyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemqtyDataGridViewTextBoxColumn.Name = "itemqtyDataGridViewTextBoxColumn";
            this.itemqtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemqtyDataGridViewTextBoxColumn.Width = 50;
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price";
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "item_price";
            this.itempriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            this.itempriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.itempriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // itemdiscountDataGridViewTextBoxColumn
            // 
            this.itemdiscountDataGridViewTextBoxColumn.DataPropertyName = "item_discount";
            this.itemdiscountDataGridViewTextBoxColumn.HeaderText = "item_discount";
            this.itemdiscountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemdiscountDataGridViewTextBoxColumn.Name = "itemdiscountDataGridViewTextBoxColumn";
            this.itemdiscountDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemdiscountDataGridViewTextBoxColumn.Visible = false;
            this.itemdiscountDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemnetpriceDataGridViewTextBoxColumn
            // 
            this.itemnetpriceDataGridViewTextBoxColumn.DataPropertyName = "item_netprice";
            this.itemnetpriceDataGridViewTextBoxColumn.HeaderText = "item_netprice";
            this.itemnetpriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemnetpriceDataGridViewTextBoxColumn.Name = "itemnetpriceDataGridViewTextBoxColumn";
            this.itemnetpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemnetpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemcostpriceDataGridViewTextBoxColumn
            // 
            this.itemcostpriceDataGridViewTextBoxColumn.DataPropertyName = "item_costprice";
            this.itemcostpriceDataGridViewTextBoxColumn.HeaderText = "item_costprice";
            this.itemcostpriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemcostpriceDataGridViewTextBoxColumn.Name = "itemcostpriceDataGridViewTextBoxColumn";
            this.itemcostpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemcostpriceDataGridViewTextBoxColumn.Visible = false;
            this.itemcostpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // itempriceoriginDataGridViewTextBoxColumn
            // 
            this.itempriceoriginDataGridViewTextBoxColumn.DataPropertyName = "item_priceorigin";
            this.itempriceoriginDataGridViewTextBoxColumn.HeaderText = "item_priceorigin";
            this.itempriceoriginDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itempriceoriginDataGridViewTextBoxColumn.Name = "itempriceoriginDataGridViewTextBoxColumn";
            this.itempriceoriginDataGridViewTextBoxColumn.ReadOnly = true;
            this.itempriceoriginDataGridViewTextBoxColumn.Visible = false;
            this.itempriceoriginDataGridViewTextBoxColumn.Width = 150;
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "points";
            this.pointsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            this.pointsDataGridViewTextBoxColumn.ReadOnly = true;
            this.pointsDataGridViewTextBoxColumn.Visible = false;
            this.pointsDataGridViewTextBoxColumn.Width = 150;
            // 
            // item_vat
            // 
            this.item_vat.DataPropertyName = "item_vat";
            this.item_vat.HeaderText = "item_vat";
            this.item_vat.MinimumWidth = 8;
            this.item_vat.Name = "item_vat";
            this.item_vat.ReadOnly = true;
            this.item_vat.Visible = false;
            this.item_vat.Width = 150;
            // 
            // listRefundBindingSource
            // 
            this.listRefundBindingSource.DataMember = "ListRefund";
            this.listRefundBindingSource.DataSource = this.rMSDataSet;
            // 
            // rMSDataSet
            // 
            this.rMSDataSet.DataSetName = "RMSDataSet";
            this.rMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rMS_NEWDataSet
            // 
            this.rMS_NEWDataSet.DataSetName = "RMS_NEWDataSet";
            this.rMS_NEWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ospossalerefunddetailsBindingSource
            // 
            this.ospossalerefunddetailsBindingSource.DataMember = "ospos_sale_refund_details";
            this.ospossalerefunddetailsBindingSource.DataSource = this.rMS_NEWDataSet;
            // 
            // ospos_sale_refund_detailsTableAdapter
            // 
            this.ospos_sale_refund_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // sellListBindingSource
            // 
            this.sellListBindingSource.DataMember = "SellList";
            this.sellListBindingSource.DataSource = this.rMSDataSet;
            // 
            // sellListTableAdapter
            // 
            this.sellListTableAdapter.ClearBeforeFill = true;
            // 
            // listRefundTableAdapter
            // 
            this.listRefundTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancleBill
            // 
            this.btnCancleBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCancleBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancleBill.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleBill.ForeColor = System.Drawing.Color.White;
            this.btnCancleBill.Location = new System.Drawing.Point(363, 5);
            this.btnCancleBill.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancleBill.Name = "btnCancleBill";
            this.btnCancleBill.Size = new System.Drawing.Size(169, 98);
            this.btnCancleBill.TabIndex = 23;
            this.btnCancleBill.Text = "OK";
            this.btnCancleBill.UseVisualStyleBackColor = false;
            this.btnCancleBill.Click += new System.EventHandler(this.btnCancleBill_Click);
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(182, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(73, 30);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "label1";
            this.lbTime.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(5, 5);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(169, 98);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "ແກ້ໄຂຈຳນວນ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(542, 5);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(170, 98);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "Close";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btnOk, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPrint, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbTime, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCancleBill, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 806);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(717, 108);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // FrmBillDetailRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 917);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBillDetailRefund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBillDetailRefund";
            this.Load += new System.EventHandler(this.FrmBillDetailRefund_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRefundBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMS_NEWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ospossalerefunddetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellListBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Models.RMSDataSet rMSDataSet;
        private System.Windows.Forms.Label lbReceivePoints;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbPay;
        private System.Windows.Forms.Label lbPaymentType;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbVat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.BindingSource sellListBindingSource;
        private Models.RMSDataSetTableAdapters.SellListTableAdapter sellListTableAdapter;
        private RMS_NEWDataSet rMS_NEWDataSet;
        private System.Windows.Forms.BindingSource ospossalerefunddetailsBindingSource;
        private RMS_NEWDataSetTableAdapters.ospos_sale_refund_detailsTableAdapter ospos_sale_refund_detailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saledatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkproductitemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemvatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkpromodisidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkpromofreeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn promotypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interfacestatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listRefundBindingSource;
        private Models.RMSDataSetTableAdapters.ListRefundTableAdapter listRefundTableAdapter;
        public System.Windows.Forms.DataGridView gridItem;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saledetailseqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtypeiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnetpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcostpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceoriginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_vat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnCancleBill;
    }
}