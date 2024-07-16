namespace POS
{
    partial class FrmQRPayment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDiaplayName = new System.Windows.Forms.Label();
            this.btnCanCel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnECard = new System.Windows.Forms.Button();
            this.btnOnePay = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 47);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 441);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbDiaplayName);
            this.panel3.Controls.Add(this.btnCanCel);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Controls.Add(this.btnECard);
            this.panel3.Controls.Add(this.btnOnePay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 394);
            this.panel3.TabIndex = 0;
            // 
            // lbDiaplayName
            // 
            this.lbDiaplayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDiaplayName.Location = new System.Drawing.Point(21, 257);
            this.lbDiaplayName.Name = "lbDiaplayName";
            this.lbDiaplayName.Size = new System.Drawing.Size(578, 49);
            this.lbDiaplayName.TabIndex = 2;
            this.lbDiaplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCanCel
            // 
            this.btnCanCel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnCanCel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanCel.Font = new System.Drawing.Font("Saysettha OT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanCel.ForeColor = System.Drawing.Color.White;
            this.btnCanCel.Location = new System.Drawing.Point(320, 316);
            this.btnCanCel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCanCel.Name = "btnCanCel";
            this.btnCanCel.Size = new System.Drawing.Size(279, 66);
            this.btnCanCel.TabIndex = 1;
            this.btnCanCel.Text = "CANCEL";
            this.btnCanCel.UseVisualStyleBackColor = false;
            this.btnCanCel.Click += new System.EventHandler(this.btnCanCel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Saysettha OT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(12, 316);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(279, 66);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnECard
            // 
            this.btnECard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnECard.BackgroundImage = global::POS.Properties.Resources.Inkedlogo_LI;
            this.btnECard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnECard.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnECard.Location = new System.Drawing.Point(320, 15);
            this.btnECard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnECard.Name = "btnECard";
            this.btnECard.Size = new System.Drawing.Size(279, 228);
            this.btnECard.TabIndex = 0;
            this.btnECard.UseVisualStyleBackColor = false;
            this.btnECard.Click += new System.EventHandler(this.btnECard_Click);
            // 
            // btnOnePay
            // 
            this.btnOnePay.BackColor = System.Drawing.Color.White;
            this.btnOnePay.BackgroundImage = global::POS.Properties.Resources.bcel_onepay_6d112631d9a7416d250b1095cef73db0ae26925465dd751f2912236718622ba1;
            this.btnOnePay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnePay.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnePay.Location = new System.Drawing.Point(12, 15);
            this.btnOnePay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnePay.Name = "btnOnePay";
            this.btnOnePay.Size = new System.Drawing.Size(279, 228);
            this.btnOnePay.TabIndex = 0;
            this.btnOnePay.UseVisualStyleBackColor = false;
            this.btnOnePay.Click += new System.EventHandler(this.btnOnePay_Click);
            // 
            // FrmQRPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 441);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmQRPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQRPayment";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnECard;
        private System.Windows.Forms.Button btnOnePay;
        private System.Windows.Forms.Label lbDiaplayName;
        private System.Windows.Forms.Button btnCanCel;
        private System.Windows.Forms.Button btnOK;
    }
}