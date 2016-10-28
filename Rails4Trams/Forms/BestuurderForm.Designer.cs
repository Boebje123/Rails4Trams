namespace Rails4Trams
{
    partial class BestuurderForm
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBestFormBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(195, 13);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 34);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Afmelden";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBestFormBack
            // 
            this.btnBestFormBack.Location = new System.Drawing.Point(195, 53);
            this.btnBestFormBack.Name = "btnBestFormBack";
            this.btnBestFormBack.Size = new System.Drawing.Size(82, 34);
            this.btnBestFormBack.TabIndex = 1;
            this.btnBestFormBack.Text = "Terug";
            this.btnBestFormBack.UseVisualStyleBackColor = true;
            this.btnBestFormBack.Visible = false;
            this.btnBestFormBack.Click += new System.EventHandler(this.btnBestFormBack_Click);
            // 
            // BestuurderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnBestFormBack);
            this.Controls.Add(this.btnLogOut);
            this.Name = "BestuurderForm";
            this.Text = "BestuurderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBestFormBack;
    }
}