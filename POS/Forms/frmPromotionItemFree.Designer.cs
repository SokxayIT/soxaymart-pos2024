namespace POS
{
    partial class frmPromotionItemFree
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridItem = new System.Windows.Forms.DataGridView();
            this.c_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_peice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridItem
            // 
            this.GridItem.AllowUserToAddRows = false;
            this.GridItem.AllowUserToDeleteRows = false;
            this.GridItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GridItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.GridItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridItem.ColumnHeadersHeight = 40;
            this.GridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_check,
            this.c_id,
            this.Barcode,
            this.c_name,
            this.c_qty,
            this.c_price,
            this.c_type,
            this.promo_id,
            this.qty_peice});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridItem.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridItem.EnableHeadersVisualStyles = false;
            this.GridItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.GridItem.Location = new System.Drawing.Point(12, 63);
            this.GridItem.Margin = new System.Windows.Forms.Padding(2);
            this.GridItem.Name = "GridItem";
            this.GridItem.ReadOnly = true;
            this.GridItem.RowHeadersVisible = false;
            this.GridItem.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.GridItem.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.GridItem.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.GridItem.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.GridItem.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.GridItem.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.GridItem.RowTemplate.Height = 34;
            this.GridItem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridItem.Size = new System.Drawing.Size(841, 346);
            this.GridItem.TabIndex = 0;
            this.GridItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridItem_CellClick);
            this.GridItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridItem_CellContentClick);
            // 
            // c_check
            // 
            this.c_check.HeaderText = "";
            this.c_check.MinimumWidth = 6;
            this.c_check.Name = "c_check";
            this.c_check.ReadOnly = true;
            this.c_check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c_check.Width = 50;
            // 
            // c_id
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.c_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.c_id.HeaderText = "Item ID";
            this.c_id.MinimumWidth = 6;
            this.c_id.Name = "c_id";
            this.c_id.ReadOnly = true;
            this.c_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.c_id.Width = 80;
            // 
            // Barcode
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Barcode.DefaultCellStyle = dataGridViewCellStyle3;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 140;
            // 
            // c_name
            // 
            this.c_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_name.HeaderText = "Item Name";
            this.c_name.MinimumWidth = 6;
            this.c_name.Name = "c_name";
            this.c_name.ReadOnly = true;
            this.c_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // c_qty
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "-";
            this.c_qty.DefaultCellStyle = dataGridViewCellStyle4;
            this.c_qty.HeaderText = "Quantity";
            this.c_qty.MinimumWidth = 6;
            this.c_qty.Name = "c_qty";
            this.c_qty.ReadOnly = true;
            this.c_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c_qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.c_qty.Width = 80;
            // 
            // c_price
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.c_price.DefaultCellStyle = dataGridViewCellStyle5;
            this.c_price.HeaderText = "Price";
            this.c_price.MinimumWidth = 6;
            this.c_price.Name = "c_price";
            this.c_price.ReadOnly = true;
            this.c_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c_price.Width = 120;
            // 
            // c_type
            // 
            this.c_type.HeaderText = "Type";
            this.c_type.Name = "c_type";
            this.c_type.ReadOnly = true;
            this.c_type.Visible = false;
            // 
            // promo_id
            // 
            this.promo_id.HeaderText = "PromoID";
            this.promo_id.Name = "promo_id";
            this.promo_id.ReadOnly = true;
            this.promo_id.Visible = false;
            // 
            // qty_peice
            // 
            this.qty_peice.HeaderText = "Qty Peice";
            this.qty_peice.Name = "qty_peice";
            this.qty_peice.ReadOnly = true;
            this.qty_peice.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "ສິນຄ້າແຖມ";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(664, 414);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 46);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(761, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 46);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 469);
            this.panel1.TabIndex = 3;
            // 
            // frmPromotionItemFree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 469);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.GridItem);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmPromotionItemFree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPromotionItemFree";
            this.Load += new System.EventHandler(this.frmPromotionItemFree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.DataGridView GridItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn promo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_peice;
        private System.Windows.Forms.Panel panel1;
    }
}