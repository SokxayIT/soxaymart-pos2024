
namespace POS
{
    partial class FrmCustomerDetail
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRedeem = new System.Windows.Forms.Button();
            this.lbPoints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbCusName = new System.Windows.Forms.Label();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRedeem);
            this.panel2.Controls.Add(this.lbPoints);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(41, 189);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 117);
            this.panel2.TabIndex = 1;
            // 
            // btnRedeem
            // 
            this.btnRedeem.BackColor = System.Drawing.Color.Orange;
            this.btnRedeem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedeem.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedeem.ForeColor = System.Drawing.Color.White;
            this.btnRedeem.Location = new System.Drawing.Point(252, 26);
            this.btnRedeem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRedeem.Name = "btnRedeem";
            this.btnRedeem.Size = new System.Drawing.Size(133, 65);
            this.btnRedeem.TabIndex = 4;
            this.btnRedeem.Text = "ແລກຂອງແຖມ";
            this.btnRedeem.UseVisualStyleBackColor = false;
            this.btnRedeem.Click += new System.EventHandler(this.btnRedeem_Click);
            // 
            // lbPoints
            // 
            this.lbPoints.BackColor = System.Drawing.Color.Transparent;
            this.lbPoints.Font = new System.Drawing.Font("Noto Sans Lao", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbPoints.Location = new System.Drawing.Point(3, 54);
            this.lbPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(193, 37);
            this.lbPoints.TabIndex = 2;
            this.lbPoints.Text = "0.00";
            this.lbPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(45, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "ຄະແນນທັງໝົດ";
            // 
            // btnUse
            // 
            this.btnUse.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUse.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUse.ForeColor = System.Drawing.Color.White;
            this.btnUse.Location = new System.Drawing.Point(41, 341);
            this.btnUse.Margin = new System.Windows.Forms.Padding(2);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(105, 65);
            this.btnUse.TabIndex = 2;
            this.btnUse.Text = "ນຳໃຊ້";
            this.btnUse.UseVisualStyleBackColor = false;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Red;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(342, 341);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(105, 65);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.Text = "ຍົກເລີກ";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.BackgroundImage = global::POS.Properties.Resources._3173677;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lbCusName);
            this.panel1.Controls.Add(this.lbCustomerID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 161);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(428, 11);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(48, 52);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // lbCusName
            // 
            this.lbCusName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCusName.BackColor = System.Drawing.Color.Transparent;
            this.lbCusName.Font = new System.Drawing.Font("Noto Sans Lao", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCusName.ForeColor = System.Drawing.Color.White;
            this.lbCusName.Location = new System.Drawing.Point(9, 103);
            this.lbCusName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCusName.Name = "lbCusName";
            this.lbCusName.Size = new System.Drawing.Size(469, 40);
            this.lbCusName.TabIndex = 2;
            this.lbCusName.Text = "Empty";
            this.lbCusName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.lbCustomerID.Font = new System.Drawing.Font("Noto Sans Lao", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerID.ForeColor = System.Drawing.Color.White;
            this.lbCustomerID.Location = new System.Drawing.Point(9, 47);
            this.lbCustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(469, 55);
            this.lbCustomerID.TabIndex = 1;
            this.lbCustomerID.Text = "Empty";
            this.lbCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ລາຍລະອຽດສະມາຊິກ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(487, 435);
            this.panel3.TabIndex = 5;
            // 
            // FrmCustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::POS.Properties.Resources._5622975;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 435);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCustomerDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCustomerDetail";
            this.Load += new System.EventHandler(this.FrmCustomerDetail_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCusName;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRedeem;
        private System.Windows.Forms.Panel panel3;
    }
}