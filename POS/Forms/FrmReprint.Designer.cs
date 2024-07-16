namespace POS
{
    partial class FrmReprint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBill = new System.Windows.Forms.RadioButton();
            this.radioMoney = new System.Windows.Forms.RadioButton();
            this.radioDateMoney = new System.Windows.Forms.RadioButton();
            this.radioDate = new System.Windows.Forms.RadioButton();
            this.Grids = new System.Windows.Forms.DataGridView();
            this.saleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opendateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netpriceamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salestatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rePrintInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rMSDataSet = new POS.Models.RMSDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.rePrintInvoiceTableAdapter = new POS.Models.RMSDataSetTableAdapters.RePrintInvoiceTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rePrintInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnclr);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCurrent);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioBill);
            this.panel1.Controls.Add(this.radioMoney);
            this.panel1.Controls.Add(this.radioDateMoney);
            this.panel1.Controls.Add(this.radioDate);
            this.panel1.Controls.Add(this.Grids);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 588);
            this.panel1.TabIndex = 0;
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btnclr.FlatAppearance.BorderSize = 0;
            this.btnclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclr.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnclr.Location = new System.Drawing.Point(1171, 397);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(88, 64);
            this.btnclr.TabIndex = 41;
            this.btnclr.Text = "CLR";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn9.Location = new System.Drawing.Point(1171, 326);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(88, 64);
            this.btn9.TabIndex = 38;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.EnterValue);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn6.Location = new System.Drawing.Point(1171, 256);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(88, 64);
            this.btn6.TabIndex = 35;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.EnterValue);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn3.Location = new System.Drawing.Point(1171, 185);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(88, 64);
            this.btn3.TabIndex = 32;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.EnterValue);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn0.Location = new System.Drawing.Point(1076, 397);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(88, 64);
            this.btn0.TabIndex = 39;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.EnterValue);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnback.Location = new System.Drawing.Point(982, 397);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(88, 64);
            this.btnback.TabIndex = 40;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn8.Location = new System.Drawing.Point(1076, 326);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(88, 64);
            this.btn8.TabIndex = 37;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.EnterValue);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn7.Location = new System.Drawing.Point(982, 326);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(88, 64);
            this.btn7.TabIndex = 36;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.EnterValue);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn5.Location = new System.Drawing.Point(1076, 256);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(88, 64);
            this.btn5.TabIndex = 34;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.EnterValue);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn4.Location = new System.Drawing.Point(982, 256);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(88, 64);
            this.btn4.TabIndex = 33;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.EnterValue);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn2.Location = new System.Drawing.Point(1076, 185);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(88, 64);
            this.btn2.TabIndex = 31;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.EnterValue);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btn1.Location = new System.Drawing.Point(982, 185);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(88, 64);
            this.btn1.TabIndex = 30;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.EnterValue);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(255, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 2);
            this.panel3.TabIndex = 9;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Noto Sans Lao", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(982, 467);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(277, 110);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Lao", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(467, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "ການປິ້ນບິນຍ້ອນຫລັງ";
            // 
            // btnCurrent
            // 
            this.btnCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnCurrent.FlatAppearance.BorderSize = 0;
            this.btnCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrent.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrent.ForeColor = System.Drawing.Color.White;
            this.btnCurrent.Location = new System.Drawing.Point(723, 142);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(120, 35);
            this.btnCurrent.TabIndex = 8;
            this.btnCurrent.Text = "ວັນທີ່ປັດຈຸບັນ";
            this.btnCurrent.UseVisualStyleBackColor = false;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(597, 142);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(120, 35);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "ຄົ້ນຫາ";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "dd-MM-yyyy";
            this.dtp.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(442, 142);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(139, 47);
            this.dtp.TabIndex = 6;
            this.dtp.Value = new System.DateTime(2024, 6, 17, 0, 0, 0, 0);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(176, 142);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(206, 47);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(388, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "ວັນທີ່:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(7, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "ຈຳນວນເງິນ / ເລກບິນ:";
            // 
            // radioBill
            // 
            this.radioBill.AutoSize = true;
            this.radioBill.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.radioBill.Location = new System.Drawing.Point(508, 95);
            this.radioBill.Name = "radioBill";
            this.radioBill.Size = new System.Drawing.Size(148, 43);
            this.radioBill.TabIndex = 3;
            this.radioBill.Text = "ຕາມເລກບິນ";
            this.radioBill.UseVisualStyleBackColor = true;
            // 
            // radioMoney
            // 
            this.radioMoney.AutoSize = true;
            this.radioMoney.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.radioMoney.Location = new System.Drawing.Point(374, 95);
            this.radioMoney.Name = "radioMoney";
            this.radioMoney.Size = new System.Drawing.Size(178, 43);
            this.radioMoney.TabIndex = 3;
            this.radioMoney.Text = "ຕາມຈຳນວນເງິນ";
            this.radioMoney.UseVisualStyleBackColor = true;
            // 
            // radioDateMoney
            // 
            this.radioDateMoney.AutoSize = true;
            this.radioDateMoney.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDateMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.radioDateMoney.Location = new System.Drawing.Point(177, 95);
            this.radioDateMoney.Name = "radioDateMoney";
            this.radioDateMoney.Size = new System.Drawing.Size(260, 43);
            this.radioDateMoney.TabIndex = 3;
            this.radioDateMoney.Text = "ຕາມວັນທີ່ແລະຈຳນວນເງິນ";
            this.radioDateMoney.UseVisualStyleBackColor = true;
            // 
            // radioDate
            // 
            this.radioDate.AutoSize = true;
            this.radioDate.Checked = true;
            this.radioDate.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.radioDate.Location = new System.Drawing.Point(81, 95);
            this.radioDate.Name = "radioDate";
            this.radioDate.Size = new System.Drawing.Size(127, 43);
            this.radioDate.TabIndex = 3;
            this.radioDate.TabStop = true;
            this.radioDate.Text = "ຕາມວັນທີ່";
            this.radioDate.UseVisualStyleBackColor = true;
            // 
            // Grids
            // 
            this.Grids.AllowUserToAddRows = false;
            this.Grids.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grids.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grids.AutoGenerateColumns = false;
            this.Grids.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grids.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grids.ColumnHeadersHeight = 30;
            this.Grids.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleidDataGridViewTextBoxColumn,
            this.salenoDataGridViewTextBoxColumn,
            this.opendateDataGridViewTextBoxColumn,
            this.receiptnoDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.subtotalamountDataGridViewTextBoxColumn,
            this.vatamountDataGridViewTextBoxColumn,
            this.discountamountDataGridViewTextBoxColumn,
            this.netpriceamountDataGridViewTextBoxColumn,
            this.salestatusDataGridViewTextBoxColumn});
            this.Grids.DataSource = this.rePrintInvoiceBindingSource;
            this.Grids.EnableHeadersVisualStyles = false;
            this.Grids.Location = new System.Drawing.Point(11, 183);
            this.Grids.Name = "Grids";
            this.Grids.ReadOnly = true;
            this.Grids.RowHeadersVisible = false;
            this.Grids.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Grids.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Grids.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.Grids.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Grids.RowTemplate.Height = 30;
            this.Grids.RowTemplate.ReadOnly = true;
            this.Grids.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Grids.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grids.Size = new System.Drawing.Size(965, 392);
            this.Grids.TabIndex = 2;
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
            // salenoDataGridViewTextBoxColumn
            // 
            this.salenoDataGridViewTextBoxColumn.DataPropertyName = "sale_no";
            this.salenoDataGridViewTextBoxColumn.HeaderText = "NO";
            this.salenoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salenoDataGridViewTextBoxColumn.Name = "salenoDataGridViewTextBoxColumn";
            this.salenoDataGridViewTextBoxColumn.ReadOnly = true;
            this.salenoDataGridViewTextBoxColumn.Width = 150;
            // 
            // opendateDataGridViewTextBoxColumn
            // 
            this.opendateDataGridViewTextBoxColumn.DataPropertyName = "opendate";
            this.opendateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.opendateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.opendateDataGridViewTextBoxColumn.Name = "opendateDataGridViewTextBoxColumn";
            this.opendateDataGridViewTextBoxColumn.ReadOnly = true;
            this.opendateDataGridViewTextBoxColumn.Width = 150;
            // 
            // receiptnoDataGridViewTextBoxColumn
            // 
            this.receiptnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receiptnoDataGridViewTextBoxColumn.DataPropertyName = "receipt_no";
            this.receiptnoDataGridViewTextBoxColumn.HeaderText = "Receipt NO";
            this.receiptnoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.receiptnoDataGridViewTextBoxColumn.Name = "receiptnoDataGridViewTextBoxColumn";
            this.receiptnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // subtotalamountDataGridViewTextBoxColumn
            // 
            this.subtotalamountDataGridViewTextBoxColumn.DataPropertyName = "subtotal_amount";
            this.subtotalamountDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalamountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.subtotalamountDataGridViewTextBoxColumn.Name = "subtotalamountDataGridViewTextBoxColumn";
            this.subtotalamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.subtotalamountDataGridViewTextBoxColumn.Width = 150;
            // 
            // vatamountDataGridViewTextBoxColumn
            // 
            this.vatamountDataGridViewTextBoxColumn.DataPropertyName = "vat_amount";
            this.vatamountDataGridViewTextBoxColumn.HeaderText = "VAT";
            this.vatamountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vatamountDataGridViewTextBoxColumn.Name = "vatamountDataGridViewTextBoxColumn";
            this.vatamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.vatamountDataGridViewTextBoxColumn.Width = 150;
            // 
            // discountamountDataGridViewTextBoxColumn
            // 
            this.discountamountDataGridViewTextBoxColumn.DataPropertyName = "discount_amount";
            this.discountamountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountamountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.discountamountDataGridViewTextBoxColumn.Name = "discountamountDataGridViewTextBoxColumn";
            this.discountamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountamountDataGridViewTextBoxColumn.Width = 150;
            // 
            // netpriceamountDataGridViewTextBoxColumn
            // 
            this.netpriceamountDataGridViewTextBoxColumn.DataPropertyName = "netprice_amount";
            this.netpriceamountDataGridViewTextBoxColumn.HeaderText = "Total";
            this.netpriceamountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.netpriceamountDataGridViewTextBoxColumn.Name = "netpriceamountDataGridViewTextBoxColumn";
            this.netpriceamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.netpriceamountDataGridViewTextBoxColumn.Width = 150;
            // 
            // salestatusDataGridViewTextBoxColumn
            // 
            this.salestatusDataGridViewTextBoxColumn.DataPropertyName = "sale_status";
            this.salestatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.salestatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salestatusDataGridViewTextBoxColumn.Name = "salestatusDataGridViewTextBoxColumn";
            this.salestatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.salestatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // rePrintInvoiceBindingSource
            // 
            this.rePrintInvoiceBindingSource.DataMember = "RePrintInvoice";
            this.rePrintInvoiceBindingSource.DataSource = this.rMSDataSet;
            // 
            // rMSDataSet
            // 
            this.rMSDataSet.DataSetName = "RMSDataSet";
            this.rMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 38);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1225, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rePrintInvoiceTableAdapter
            // 
            this.rePrintInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 588);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmReprint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReprint";
            this.Load += new System.EventHandler(this.FrmReprint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rePrintInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioMoney;
        private System.Windows.Forms.RadioButton radioDateMoney;
        private System.Windows.Forms.RadioButton radioDate;
        private System.Windows.Forms.DataGridView Grids;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.RadioButton radioBill;
        private Models.RMSDataSet rMSDataSet;
        private Models.RMSDataSetTableAdapters.RePrintInvoiceTableAdapter rePrintInvoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saledateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opendateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netpriceamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salestatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rePrintInvoiceBindingSource;
    }
}