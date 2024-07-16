namespace POS
{
    partial class FrmConfirmPayment
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
            this.lbmessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCaption = new System.Windows.Forms.Label();
            this.pic_error = new System.Windows.Forms.PictureBox();
            this.pic_loading = new System.Windows.Forms.PictureBox();
            this.pic_complete = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_complete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbmessage);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pic_error);
            this.panel1.Controls.Add(this.pic_loading);
            this.panel1.Controls.Add(this.pic_complete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 327);
            this.panel1.TabIndex = 0;
            // 
            // lbmessage
            // 
            this.lbmessage.Font = new System.Drawing.Font("Saysettha OT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmessage.Location = new System.Drawing.Point(11, 210);
            this.lbmessage.Name = "lbmessage";
            this.lbmessage.Size = new System.Drawing.Size(616, 46);
            this.lbmessage.TabIndex = 6;
            this.lbmessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Noto Sans Lao", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(332, 258);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(292, 55);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Noto Sans Lao", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(11, 258);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(292, 55);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "CONFIRM";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lbCaption);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 54);
            this.panel2.TabIndex = 0;
            // 
            // lbCaption
            // 
            this.lbCaption.AutoSize = true;
            this.lbCaption.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaption.Location = new System.Drawing.Point(11, 7);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(299, 38);
            this.lbCaption.TabIndex = 5;
            this.lbCaption.Text = "Confirm Payment Online";
            // 
            // pic_error
            // 
            this.pic_error.Image = global::POS.Properties.Resources.x1;
            this.pic_error.Location = new System.Drawing.Point(165, 60);
            this.pic_error.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_error.Name = "pic_error";
            this.pic_error.Size = new System.Drawing.Size(307, 150);
            this.pic_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_error.TabIndex = 4;
            this.pic_error.TabStop = false;
            this.pic_error.Visible = false;
            // 
            // pic_loading
            // 
            this.pic_loading.Image = global::POS.Properties.Resources.loading;
            this.pic_loading.Location = new System.Drawing.Point(165, 60);
            this.pic_loading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_loading.Name = "pic_loading";
            this.pic_loading.Size = new System.Drawing.Size(307, 150);
            this.pic_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_loading.TabIndex = 2;
            this.pic_loading.TabStop = false;
            this.pic_loading.Visible = false;
            // 
            // pic_complete
            // 
            this.pic_complete.Image = global::POS.Properties.Resources.checked1;
            this.pic_complete.Location = new System.Drawing.Point(165, 60);
            this.pic_complete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_complete.Name = "pic_complete";
            this.pic_complete.Size = new System.Drawing.Size(307, 150);
            this.pic_complete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_complete.TabIndex = 3;
            this.pic_complete.TabStop = false;
            this.pic_complete.Visible = false;
            // 
            // FrmConfirmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 327);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmConfirmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfirmPayment";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_complete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_loading;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pic_complete;
        private System.Windows.Forms.Label lbCaption;
        private System.Windows.Forms.PictureBox pic_error;
        private System.Windows.Forms.Label lbmessage;
        private System.Windows.Forms.Button btnCancel;
    }
}