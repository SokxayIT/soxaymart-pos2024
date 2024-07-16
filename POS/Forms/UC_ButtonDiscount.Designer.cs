namespace POS
{
    partial class UC_ButtonDiscount
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
            this.btnDis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDis
            // 
            this.btnDis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnDis.FlatAppearance.BorderSize = 0;
            this.btnDis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDis.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDis.Location = new System.Drawing.Point(0, 0);
            this.btnDis.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(92, 50);
            this.btnDis.TabIndex = 0;
            this.btnDis.UseVisualStyleBackColor = false;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // UC_ButtonDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDis);
            this.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "UC_ButtonDiscount";
            this.Size = new System.Drawing.Size(92, 50);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnDis;
    }
}
