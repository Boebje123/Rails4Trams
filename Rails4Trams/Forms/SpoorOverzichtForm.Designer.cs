namespace Rails4Trams
{
    partial class SpoorOverzichtForm
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
            this.lbSporen = new System.Windows.Forms.ListBox();
            this.btnBlokkeerSpoor = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSporen
            // 
            this.lbSporen.FormattingEnabled = true;
            this.lbSporen.ItemHeight = 16;
            this.lbSporen.Location = new System.Drawing.Point(206, 12);
            this.lbSporen.Name = "lbSporen";
            this.lbSporen.Size = new System.Drawing.Size(470, 228);
            this.lbSporen.TabIndex = 0;
            // 
            // btnBlokkeerSpoor
            // 
            this.btnBlokkeerSpoor.Location = new System.Drawing.Point(364, 286);
            this.btnBlokkeerSpoor.Name = "btnBlokkeerSpoor";
            this.btnBlokkeerSpoor.Size = new System.Drawing.Size(142, 33);
            this.btnBlokkeerSpoor.TabIndex = 1;
            this.btnBlokkeerSpoor.Text = "Blokkeer spoor";
            this.btnBlokkeerSpoor.UseVisualStyleBackColor = true;
            this.btnBlokkeerSpoor.Click += new System.EventHandler(this.btnBlokkeerSpoor_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Vrij maken",
            "Blokkeer"});
            this.cbStatus.Location = new System.Drawing.Point(376, 246);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 2;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(845, 47);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(85, 35);
            this.btnTerug.TabIndex = 3;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // SpoorOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 457);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnBlokkeerSpoor);
            this.Controls.Add(this.lbSporen);
            this.Name = "SpoorOverzichtForm";
            this.Text = "SpoorOverzichtForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSporen;
        private System.Windows.Forms.Button btnBlokkeerSpoor;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnTerug;
    }
}