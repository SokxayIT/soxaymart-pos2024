namespace POS
{
    partial class FrmPaidIn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Grids = new System.Windows.Forms.DataGridView();
            this.c_CashName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_TenderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnclr = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbAmount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Grids)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ຈຳນວນເງິນ:";
            // 
            // Grids
            // 
            this.Grids.AllowUserToAddRows = false;
            this.Grids.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grids.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grids.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grids.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grids.ColumnHeadersHeight = 35;
            this.Grids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grids.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_CashName,
            this.c_qty,
            this.c_Amount,
            this.c_TenderID,
            this.c_Value});
            this.Grids.Location = new System.Drawing.Point(12, 64);
            this.Grids.Name = "Grids";
            this.Grids.ReadOnly = true;
            this.Grids.RowHeadersVisible = false;
            this.Grids.RowHeadersWidth = 51;
            this.Grids.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.Grids.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Grids.RowTemplate.Height = 30;
            this.Grids.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Grids.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grids.Size = new System.Drawing.Size(511, 369);
            this.Grids.TabIndex = 1;
            this.Grids.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grids_CellContentClick);
            // 
            // c_CashName
            // 
            this.c_CashName.HeaderText = "Cash Name";
            this.c_CashName.MinimumWidth = 6;
            this.c_CashName.Name = "c_CashName";
            this.c_CashName.ReadOnly = true;
            this.c_CashName.Width = 180;
            // 
            // c_qty
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.c_qty.DefaultCellStyle = dataGridViewCellStyle3;
            this.c_qty.HeaderText = "Quantity";
            this.c_qty.MinimumWidth = 6;
            this.c_qty.Name = "c_qty";
            this.c_qty.ReadOnly = true;
            this.c_qty.Width = 125;
            // 
            // c_Amount
            // 
            this.c_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "N0";
            this.c_Amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.c_Amount.HeaderText = "Amount";
            this.c_Amount.MinimumWidth = 6;
            this.c_Amount.Name = "c_Amount";
            this.c_Amount.ReadOnly = true;
            // 
            // c_TenderID
            // 
            this.c_TenderID.HeaderText = "ID";
            this.c_TenderID.MinimumWidth = 6;
            this.c_TenderID.Name = "c_TenderID";
            this.c_TenderID.ReadOnly = true;
            this.c_TenderID.Visible = false;
            this.c_TenderID.Width = 125;
            // 
            // c_Value
            // 
            this.c_Value.HeaderText = "Value";
            this.c_Value.MinimumWidth = 6;
            this.c_Value.Name = "c_Value";
            this.c_Value.ReadOnly = true;
            this.c_Value.Visible = false;
            this.c_Value.Width = 125;
            // 
            // btnclr
            // 
            this.btnclr.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnclr.Location = new System.Drawing.Point(703, 276);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(80, 64);
            this.btnclr.TabIndex = 39;
            this.btnclr.Text = "CLR";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn9.Location = new System.Drawing.Point(703, 205);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 64);
            this.btn9.TabIndex = 36;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn6.Location = new System.Drawing.Point(703, 135);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 64);
            this.btn6.TabIndex = 33;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn3.Location = new System.Drawing.Point(703, 64);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 64);
            this.btn3.TabIndex = 30;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn0.Location = new System.Drawing.Point(617, 276);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(80, 64);
            this.btn0.TabIndex = 37;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnback.Location = new System.Drawing.Point(531, 276);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(80, 64);
            this.btnback.TabIndex = 38;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn8.Location = new System.Drawing.Point(617, 205);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 64);
            this.btn8.TabIndex = 35;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn7.Location = new System.Drawing.Point(531, 205);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 64);
            this.btn7.TabIndex = 34;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn5.Location = new System.Drawing.Point(617, 135);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 64);
            this.btn5.TabIndex = 32;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn4.Location = new System.Drawing.Point(531, 135);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 64);
            this.btn4.TabIndex = 31;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn2.Location = new System.Drawing.Point(617, 64);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 64);
            this.btn2.TabIndex = 29;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn1.Location = new System.Drawing.Point(531, 64);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 64);
            this.btn1.TabIndex = 28;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSave.Location = new System.Drawing.Point(531, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 87);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCancel.Location = new System.Drawing.Point(663, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 87);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbAmount
            // 
            this.lbAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbAmount.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbAmount.Location = new System.Drawing.Point(213, 13);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(307, 38);
            this.lbAmount.TabIndex = 0;
            this.lbAmount.Text = "0";
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 46);
            this.panel1.TabIndex = 40;
            // 
            // FrmPaidIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 446);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Grids);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "FrmPaidIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaidIn";
            this.Load += new System.EventHandler(this.FrmPaidIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grids)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grids;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_CashName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_TenderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Value;
    }
}