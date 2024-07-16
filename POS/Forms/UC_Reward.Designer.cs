namespace POS
{
    partial class UC_Reward
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRedeem = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnBottom.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnClose.Location = new System.Drawing.Point(772, 20);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 48);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "ກັບ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.pnBottom.BackgroundImage = global::POS.Properties.Resources._3173677;
            this.pnBottom.Controls.Add(this.panel4);
            this.pnBottom.Controls.Add(this.btnClose);
            this.pnBottom.Controls.Add(this.btnRedeem);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 523);
            this.pnBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(901, 84);
            this.pnBottom.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(231)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbPoints);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(13, 12);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 61);
            this.panel4.TabIndex = 5;
            // 
            // lbPoints
            // 
            this.lbPoints.Font = new System.Drawing.Font("Noto Sans", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbPoints.ForeColor = System.Drawing.Color.Red;
            this.lbPoints.Location = new System.Drawing.Point(75, 14);
            this.lbPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(134, 33);
            this.lbPoints.TabIndex = 1;
            this.lbPoints.Text = "0";
            this.lbPoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ຄະແນນ:";
            // 
            // btnRedeem
            // 
            this.btnRedeem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRedeem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(95)))), ((int)(((byte)(87)))));
            this.btnRedeem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedeem.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedeem.ForeColor = System.Drawing.Color.White;
            this.btnRedeem.Location = new System.Drawing.Point(376, 18);
            this.btnRedeem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRedeem.Name = "btnRedeem";
            this.btnRedeem.Size = new System.Drawing.Size(146, 51);
            this.btnRedeem.TabIndex = 4;
            this.btnRedeem.Text = "ແລກສິນຄ້າ";
            this.btnRedeem.UseVisualStyleBackColor = false;
            this.btnRedeem.Click += new System.EventHandler(this.btnRedeem_Click);
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.flowLayoutPanel1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(901, 523);
            this.pnMain.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(231)))));
            this.flowLayoutPanel1.BackgroundImage = global::POS.Properties.Resources._5622975;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(901, 523);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // UC_Reward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnBottom);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_Reward";
            this.Size = new System.Drawing.Size(901, 607);
            this.Load += new System.EventHandler(this.UC_Reward_Load);
            this.pnBottom.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRedeem;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label lbPoints;
    }
}
