namespace POS
{
    partial class FrmBillDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbBil = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbCheckNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEmp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMember = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbVat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbPaymentType = new System.Windows.Forms.Label();
            this.lbPay = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbChange = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbReceivePoints = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancleBill = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gridItem = new System.Windows.Forms.DataGridView();
            this.saleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saledetailseqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subsortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rMSDataSet = new POS.Models.RMSDataSet();
            this.sellListTableAdapter = new POS.Models.RMSDataSetTableAdapters.SellListTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(248, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "ເລກບິນ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbBil
            // 
            this.lbBil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBil.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbBil.Location = new System.Drawing.Point(257, 0);
            this.lbBil.Name = "lbBil";
            this.lbBil.Size = new System.Drawing.Size(248, 23);
            this.lbBil.TabIndex = 21;
            this.lbBil.Text = "0.00";
            this.lbBil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbBil.Click += new System.EventHandler(this.lbBil_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label13.Location = new System.Drawing.Point(3, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(248, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "ລຳດັບບິນ:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // lbCheckNo
            // 
            this.lbCheckNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCheckNo.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbCheckNo.Location = new System.Drawing.Point(257, 23);
            this.lbCheckNo.Name = "lbCheckNo";
            this.lbCheckNo.Size = new System.Drawing.Size(248, 23);
            this.lbCheckNo.TabIndex = 29;
            this.lbCheckNo.Text = "0.00";
            this.lbCheckNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCheckNo.Click += new System.EventHandler(this.lbCheckNo_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Emp:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbEmp
            // 
            this.lbEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmp.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbEmp.Location = new System.Drawing.Point(257, 46);
            this.lbEmp.Name = "lbEmp";
            this.lbEmp.Size = new System.Drawing.Size(248, 23);
            this.lbEmp.TabIndex = 4;
            this.lbEmp.Text = "0.00";
            this.lbEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbEmp.Click += new System.EventHandler(this.lbEmp_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Member:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbMember
            // 
            this.lbMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMember.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbMember.Location = new System.Drawing.Point(257, 69);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(248, 23);
            this.lbMember.TabIndex = 5;
            this.lbMember.Text = "0.00";
            this.lbMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMember.Click += new System.EventHandler(this.lbMember_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel2.SetColumnSpan(this.panel8, 2);
            this.panel8.Location = new System.Drawing.Point(3, 95);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(502, 4);
            this.panel8.TabIndex = 22;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(3, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "ລວມເງິນ:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubtotal.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbSubtotal.Location = new System.Drawing.Point(257, 102);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(248, 23);
            this.lbSubtotal.TabIndex = 6;
            this.lbSubtotal.Text = "0.00";
            this.lbSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSubtotal.Click += new System.EventHandler(this.lbSubtotal_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(3, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "ສ່ວນຫຼຸດ:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbDiscount
            // 
            this.lbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiscount.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbDiscount.Location = new System.Drawing.Point(257, 125);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(248, 23);
            this.lbDiscount.TabIndex = 7;
            this.lbDiscount.Text = "0.00";
            this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDiscount.Click += new System.EventHandler(this.lbDiscount_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(3, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "ອມພ 7%:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbVat
            // 
            this.lbVat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVat.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbVat.Location = new System.Drawing.Point(257, 148);
            this.lbVat.Name = "lbVat";
            this.lbVat.Size = new System.Drawing.Size(248, 23);
            this.lbVat.TabIndex = 8;
            this.lbVat.Text = "0.00";
            this.lbVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbVat.Click += new System.EventHandler(this.lbVat_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(3, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 23);
            this.label8.TabIndex = 31;
            this.label8.Text = "ລວມມູນຄ່າທັງໝົດ:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbAmount
            // 
            this.lbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAmount.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbAmount.Location = new System.Drawing.Point(257, 171);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(248, 23);
            this.lbAmount.TabIndex = 30;
            this.lbAmount.Text = "0.00";
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbAmount.Click += new System.EventHandler(this.lbAmount_Click);
            // 
            // lbPaymentType
            // 
            this.lbPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPaymentType.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbPaymentType.Location = new System.Drawing.Point(3, 194);
            this.lbPaymentType.Name = "lbPaymentType";
            this.lbPaymentType.Size = new System.Drawing.Size(248, 23);
            this.lbPaymentType.TabIndex = 19;
            this.lbPaymentType.Text = "ຈ່າຍ:";
            this.lbPaymentType.Click += new System.EventHandler(this.lbPaymentType_Click);
            // 
            // lbPay
            // 
            this.lbPay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPay.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbPay.Location = new System.Drawing.Point(257, 194);
            this.lbPay.Name = "lbPay";
            this.lbPay.Size = new System.Drawing.Size(248, 23);
            this.lbPay.TabIndex = 10;
            this.lbPay.Text = "0.00";
            this.lbPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPay.Click += new System.EventHandler(this.lbPay_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(3, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "ທອນ:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbChange
            // 
            this.lbChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChange.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbChange.Location = new System.Drawing.Point(257, 217);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(248, 23);
            this.lbChange.TabIndex = 11;
            this.lbChange.Text = "0.00";
            this.lbChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbChange.Click += new System.EventHandler(this.lbChange_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(3, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 26);
            this.label11.TabIndex = 26;
            this.label11.Text = "ໄດ້ຮັບ Points:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbReceivePoints
            // 
            this.lbReceivePoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReceivePoints.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceivePoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbReceivePoints.Location = new System.Drawing.Point(257, 240);
            this.lbReceivePoints.Name = "lbReceivePoints";
            this.lbReceivePoints.Size = new System.Drawing.Size(248, 26);
            this.lbReceivePoints.TabIndex = 27;
            this.lbReceivePoints.Text = "0.00";
            this.lbReceivePoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbReceivePoints.Click += new System.EventHandler(this.lbReceivePoints_Click);
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(130, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(73, 30);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "label1";
            this.lbTime.Visible = false;
            this.lbTime.Click += new System.EventHandler(this.lbTime_Click);
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnOk.Location = new System.Drawing.Point(386, 5);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(117, 47);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "Close";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancleBill
            // 
            this.btnCancleBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancleBill.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCancleBill.Location = new System.Drawing.Point(259, 5);
            this.btnCancleBill.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancleBill.Name = "btnCancleBill";
            this.btnCancleBill.Size = new System.Drawing.Size(117, 47);
            this.btnCancleBill.TabIndex = 23;
            this.btnCancleBill.Text = "OK";
            this.btnCancleBill.UseVisualStyleBackColor = true;
            this.btnCancleBill.Visible = false;
            this.btnCancleBill.Click += new System.EventHandler(this.btnCancleBill_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnPrint.Location = new System.Drawing.Point(5, 5);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(117, 47);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 676);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 616);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(508, 57);
            this.tableLayoutPanel3.TabIndex = 5;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
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
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbEmp, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbCheckNo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbBil, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 344);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(508, 266);
            this.tableLayoutPanel2.TabIndex = 5;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
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
            this.nameDataGridViewTextBoxColumn,
            this.itemqtyDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn,
            this.itemdiscountDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.sortbyDataGridViewTextBoxColumn,
            this.subsortDataGridViewTextBoxColumn});
            this.gridItem.DataSource = this.sellListBindingSource;
            this.gridItem.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.gridItem.Size = new System.Drawing.Size(508, 335);
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemqtyDataGridViewTextBoxColumn
            // 
            this.itemqtyDataGridViewTextBoxColumn.DataPropertyName = "item_qty";
            this.itemqtyDataGridViewTextBoxColumn.HeaderText = "item_qty";
            this.itemqtyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemqtyDataGridViewTextBoxColumn.Name = "itemqtyDataGridViewTextBoxColumn";
            this.itemqtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemqtyDataGridViewTextBoxColumn.Width = 60;
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price";
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "item_price";
            this.itempriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            this.itempriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.itempriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // itemdiscountDataGridViewTextBoxColumn
            // 
            this.itemdiscountDataGridViewTextBoxColumn.DataPropertyName = "item_discount";
            this.itemdiscountDataGridViewTextBoxColumn.HeaderText = "item_discount";
            this.itemdiscountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemdiscountDataGridViewTextBoxColumn.Name = "itemdiscountDataGridViewTextBoxColumn";
            this.itemdiscountDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemdiscountDataGridViewTextBoxColumn.Width = 90;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // sortbyDataGridViewTextBoxColumn
            // 
            this.sortbyDataGridViewTextBoxColumn.DataPropertyName = "sort_by";
            this.sortbyDataGridViewTextBoxColumn.HeaderText = "sort_by";
            this.sortbyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sortbyDataGridViewTextBoxColumn.Name = "sortbyDataGridViewTextBoxColumn";
            this.sortbyDataGridViewTextBoxColumn.ReadOnly = true;
            this.sortbyDataGridViewTextBoxColumn.Visible = false;
            this.sortbyDataGridViewTextBoxColumn.Width = 150;
            // 
            // subsortDataGridViewTextBoxColumn
            // 
            this.subsortDataGridViewTextBoxColumn.DataPropertyName = "sub_sort";
            this.subsortDataGridViewTextBoxColumn.HeaderText = "sub_sort";
            this.subsortDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.subsortDataGridViewTextBoxColumn.Name = "subsortDataGridViewTextBoxColumn";
            this.subsortDataGridViewTextBoxColumn.ReadOnly = true;
            this.subsortDataGridViewTextBoxColumn.Visible = false;
            this.subsortDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellListBindingSource
            // 
            this.sellListBindingSource.DataMember = "SellList";
            this.sellListBindingSource.DataSource = this.rMSDataSet;
            this.sellListBindingSource.CurrentChanged += new System.EventHandler(this.sellListBindingSource_CurrentChanged);
            // 
            // rMSDataSet
            // 
            this.rMSDataSet.DataSetName = "RMSDataSet";
            this.rMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellListTableAdapter
            // 
            this.sellListTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(514, 676);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "FrmBillDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBillDetail";
            this.Load += new System.EventHandler(this.FrmBillDetail_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbPaymentType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Label lbPay;
        private System.Windows.Forms.Label lbVat;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.Label lbEmp;
        private System.Windows.Forms.Label lbBil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancleBill;
        private System.Windows.Forms.Label lbReceivePoints;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbCheckNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView gridItem;
        private Models.RMSDataSetTableAdapters.SellListTableAdapter sellListTableAdapter;
        private System.Windows.Forms.BindingSource sellListBindingSource;
        private Models.RMSDataSet rMSDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saledetailseqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subsortDataGridViewTextBoxColumn;
    }
}