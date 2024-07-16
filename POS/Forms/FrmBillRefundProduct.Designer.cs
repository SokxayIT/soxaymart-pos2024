namespace POS.Forms
{
    partial class FrmBillRefundProduct
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
            this.gridItem = new System.Windows.Forms.DataGridView();
            this.saleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saledetailseqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productitemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtypeiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnetpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcostpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceoriginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemvatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listRefundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rMSDataSet = new POS.Models.RMSDataSet();
            this.lbReceivePoints = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbVat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMember = new System.Windows.Forms.Label();
            this.lbEmp = new System.Windows.Forms.Label();
            this.lbBil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnclr = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listRefundTableAdapter = new POS.Models.RMSDataSetTableAdapters.ListRefundTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRefundBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.productitemnameDataGridViewTextBoxColumn,
            this.qtypeiceDataGridViewTextBoxColumn,
            this.itemqtyDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn,
            this.itemdiscountDataGridViewTextBoxColumn,
            this.itemnetpriceDataGridViewTextBoxColumn,
            this.itemcostpriceDataGridViewTextBoxColumn,
            this.itempriceoriginDataGridViewTextBoxColumn,
            this.pointsDataGridViewTextBoxColumn,
            this.itemvatDataGridViewTextBoxColumn});
            this.gridItem.DataSource = this.listRefundBindingSource;
            this.gridItem.Enabled = false;
            this.gridItem.Location = new System.Drawing.Point(12, 6);
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
            this.gridItem.Size = new System.Drawing.Size(1115, 328);
            this.gridItem.TabIndex = 8;
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
            // productitemnameDataGridViewTextBoxColumn
            // 
            this.productitemnameDataGridViewTextBoxColumn.DataPropertyName = "product_item_name";
            this.productitemnameDataGridViewTextBoxColumn.HeaderText = "product_item_name";
            this.productitemnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productitemnameDataGridViewTextBoxColumn.Name = "productitemnameDataGridViewTextBoxColumn";
            this.productitemnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productitemnameDataGridViewTextBoxColumn.Width = 250;
            // 
            // qtypeiceDataGridViewTextBoxColumn
            // 
            this.qtypeiceDataGridViewTextBoxColumn.DataPropertyName = "qty_peice";
            this.qtypeiceDataGridViewTextBoxColumn.HeaderText = "qty_peice";
            this.qtypeiceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qtypeiceDataGridViewTextBoxColumn.Name = "qtypeiceDataGridViewTextBoxColumn";
            this.qtypeiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtypeiceDataGridViewTextBoxColumn.Visible = false;
            this.qtypeiceDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemqtyDataGridViewTextBoxColumn
            // 
            this.itemqtyDataGridViewTextBoxColumn.DataPropertyName = "item_qty";
            this.itemqtyDataGridViewTextBoxColumn.HeaderText = "item_qty";
            this.itemqtyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemqtyDataGridViewTextBoxColumn.Name = "itemqtyDataGridViewTextBoxColumn";
            this.itemqtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemqtyDataGridViewTextBoxColumn.Width = 80;
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price";
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "item_price";
            this.itempriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            this.itempriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.itempriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemdiscountDataGridViewTextBoxColumn
            // 
            this.itemdiscountDataGridViewTextBoxColumn.DataPropertyName = "item_discount";
            this.itemdiscountDataGridViewTextBoxColumn.HeaderText = "item_discount";
            this.itemdiscountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemdiscountDataGridViewTextBoxColumn.Name = "itemdiscountDataGridViewTextBoxColumn";
            this.itemdiscountDataGridViewTextBoxColumn.ReadOnly = true;
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
            // itemvatDataGridViewTextBoxColumn
            // 
            this.itemvatDataGridViewTextBoxColumn.DataPropertyName = "item_vat";
            this.itemvatDataGridViewTextBoxColumn.HeaderText = "item_vat";
            this.itemvatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemvatDataGridViewTextBoxColumn.Name = "itemvatDataGridViewTextBoxColumn";
            this.itemvatDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemvatDataGridViewTextBoxColumn.Visible = false;
            this.itemvatDataGridViewTextBoxColumn.Width = 150;
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
            // lbReceivePoints
            // 
            this.lbReceivePoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReceivePoints.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceivePoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbReceivePoints.Location = new System.Drawing.Point(282, 641);
            this.lbReceivePoints.Name = "lbReceivePoints";
            this.lbReceivePoints.Size = new System.Drawing.Size(246, 35);
            this.lbReceivePoints.TabIndex = 69;
            this.lbReceivePoints.Text = "0.00";
            this.lbReceivePoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(30, 642);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 35);
            this.label11.TabIndex = 68;
            this.label11.Text = "Points:";
            // 
            // lbAmount
            // 
            this.lbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAmount.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.Red;
            this.lbAmount.Location = new System.Drawing.Point(282, 591);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(246, 47);
            this.lbAmount.TabIndex = 70;
            this.lbAmount.Text = "0.00";
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(30, 594);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 44);
            this.label8.TabIndex = 71;
            this.label8.Text = "ຈຳນວນເງິນສົ່ງຄືນ:";
            // 
            // lbVat
            // 
            this.lbVat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVat.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbVat.Location = new System.Drawing.Point(282, 541);
            this.lbVat.Name = "lbVat";
            this.lbVat.Size = new System.Drawing.Size(246, 45);
            this.lbVat.TabIndex = 56;
            this.lbVat.Text = "0.00";
            this.lbVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(30, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 45);
            this.label7.TabIndex = 64;
            this.label7.Text = "ອມພ 7%:";
            // 
            // lbDiscount
            // 
            this.lbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiscount.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbDiscount.Location = new System.Drawing.Point(282, 492);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(246, 48);
            this.lbDiscount.TabIndex = 55;
            this.lbDiscount.Text = "0.00";
            this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(30, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 48);
            this.label6.TabIndex = 63;
            this.label6.Text = "ສ່ວນຫຼຸດ:";
            // 
            // lbMember
            // 
            this.lbMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMember.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbMember.Location = new System.Drawing.Point(282, 444);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(246, 46);
            this.lbMember.TabIndex = 53;
            this.lbMember.Text = "0.00";
            this.lbMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbEmp
            // 
            this.lbEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmp.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbEmp.Location = new System.Drawing.Point(282, 394);
            this.lbEmp.Name = "lbEmp";
            this.lbEmp.Size = new System.Drawing.Size(246, 48);
            this.lbEmp.TabIndex = 52;
            this.lbEmp.Text = "0.00";
            this.lbEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBil
            // 
            this.lbBil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBil.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbBil.Location = new System.Drawing.Point(282, 342);
            this.lbBil.Name = "lbBil";
            this.lbBil.Size = new System.Drawing.Size(246, 42);
            this.lbBil.TabIndex = 67;
            this.lbBil.Text = "0.00";
            this.lbBil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(30, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 59;
            this.label1.Text = "ເລກບິນ:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(30, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 46);
            this.label3.TabIndex = 60;
            this.label3.Text = "Emp:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(30, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 48);
            this.label4.TabIndex = 61;
            this.label4.Text = "Member:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(633, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 46);
            this.label2.TabIndex = 87;
            this.label2.Text = "Enter Item Quatity";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Noto Sans Lao", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(631, 391);
            this.txtQty.MaxLength = 3;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(450, 86);
            this.txtQty.TabIndex = 72;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btnclr.FlatAppearance.BorderSize = 0;
            this.btnclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclr.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnclr.Location = new System.Drawing.Point(817, 695);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(88, 64);
            this.btnclr.TabIndex = 84;
            this.btnclr.Text = "CLR";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.button37.FlatAppearance.BorderSize = 0;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button37.Location = new System.Drawing.Point(817, 624);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(88, 64);
            this.button37.TabIndex = 81;
            this.button37.Text = "9";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.Number_Click);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.button34.FlatAppearance.BorderSize = 0;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button34.Location = new System.Drawing.Point(817, 554);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(88, 64);
            this.button34.TabIndex = 78;
            this.button34.Text = "6";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.Number_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Noto Sans Lao", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(911, 624);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(170, 135);
            this.btncancel.TabIndex = 86;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Sans Lao", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(911, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 135);
            this.button1.TabIndex = 85;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.button31.FlatAppearance.BorderSize = 0;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button31.Location = new System.Drawing.Point(817, 483);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(88, 64);
            this.button31.TabIndex = 75;
            this.button31.Text = "3";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.Number_Click);
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.button39.FlatAppearance.BorderSize = 0;
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button39.Location = new System.Drawing.Point(723, 695);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(88, 64);
            this.button39.TabIndex = 82;
            this.button39.Text = "0";
            this.button39.UseVisualStyleBackColor = false;
            this.button39.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnback.Location = new System.Drawing.Point(629, 695);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(88, 64);
            this.btnback.TabIndex = 83;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button36.Location = new System.Drawing.Point(723, 624);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(88, 64);
            this.button36.TabIndex = 80;
            this.button36.Text = "8";
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.Number_Click);
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.button35.FlatAppearance.BorderSize = 0;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button35.Location = new System.Drawing.Point(629, 624);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(88, 64);
            this.button35.TabIndex = 79;
            this.button35.Text = "7";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.Number_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.button33.FlatAppearance.BorderSize = 0;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button33.Location = new System.Drawing.Point(723, 554);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(88, 64);
            this.button33.TabIndex = 77;
            this.button33.Text = "5";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.Number_Click);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.button32.FlatAppearance.BorderSize = 0;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button32.Location = new System.Drawing.Point(629, 554);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(88, 64);
            this.button32.TabIndex = 76;
            this.button32.Text = "4";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.Number_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.button30.FlatAppearance.BorderSize = 0;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button30.Location = new System.Drawing.Point(723, 483);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(88, 64);
            this.button30.TabIndex = 74;
            this.button30.Text = "2";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.Number_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.button29.FlatAppearance.BorderSize = 0;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button29.Location = new System.Drawing.Point(629, 483);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(88, 64);
            this.button29.TabIndex = 73;
            this.button29.Text = "1";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.Number_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Noto Sans Lao", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(37, 695);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(491, 78);
            this.button2.TabIndex = 88;
            this.button2.Text = "ຍົກເລີກລາຍການ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listRefundTableAdapter
            // 
            this.listRefundTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBillRefundProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 892);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.lbReceivePoints);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbVat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbMember);
            this.Controls.Add(this.lbEmp);
            this.Controls.Add(this.lbBil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBillRefundProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBillRefundProduct";
            this.Load += new System.EventHandler(this.FrmBillRefundProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRefundBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView gridItem;
        private System.Windows.Forms.Label lbReceivePoints;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbVat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.Label lbEmp;
        private System.Windows.Forms.Label lbBil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource listRefundBindingSource;
        private Models.RMSDataSet rMSDataSet;
        private Models.RMSDataSetTableAdapters.ListRefundTableAdapter listRefundTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saledetailseqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productitemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtypeiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnetpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcostpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceoriginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemvatDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox txtQty;
    }
}