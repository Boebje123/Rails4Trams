namespace Rails4Trams.Forms
{
    partial class OverzichtTramsForm
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
            this.lbTrams = new System.Windows.Forms.ListBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnVeranderStatus = new System.Windows.Forms.Button();
            this.btnVerplaatsTram = new System.Windows.Forms.Button();
            this.cbVrijSpoor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVrijSector = new System.Windows.Forms.ComboBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTrams
            // 
            this.lbTrams.FormattingEnabled = true;
            this.lbTrams.ItemHeight = 16;
            this.lbTrams.Location = new System.Drawing.Point(12, 14);
            this.lbTrams.Name = "lbTrams";
            this.lbTrams.Size = new System.Drawing.Size(798, 228);
            this.lbTrams.TabIndex = 0;
            this.lbTrams.SelectedIndexChanged += new System.EventHandler(this.lbTrams_SelectedIndexChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Defect",
            "Vervuild",
            "Dienst",
            "Remise"});
            this.cbStatus.Location = new System.Drawing.Point(319, 257);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(180, 24);
            this.cbStatus.TabIndex = 1;
            // 
            // btnVeranderStatus
            // 
            this.btnVeranderStatus.Location = new System.Drawing.Point(591, 248);
            this.btnVeranderStatus.Name = "btnVeranderStatus";
            this.btnVeranderStatus.Size = new System.Drawing.Size(95, 57);
            this.btnVeranderStatus.TabIndex = 2;
            this.btnVeranderStatus.Text = "Verander Status";
            this.btnVeranderStatus.UseVisualStyleBackColor = true;
            this.btnVeranderStatus.Click += new System.EventHandler(this.btnVeranderStatus_Click);
            // 
            // btnVerplaatsTram
            // 
            this.btnVerplaatsTram.Location = new System.Drawing.Point(341, 391);
            this.btnVerplaatsTram.Name = "btnVerplaatsTram";
            this.btnVerplaatsTram.Size = new System.Drawing.Size(134, 51);
            this.btnVerplaatsTram.TabIndex = 3;
            this.btnVerplaatsTram.Text = "Rij tram naar spoor";
            this.btnVerplaatsTram.UseVisualStyleBackColor = true;
            this.btnVerplaatsTram.Click += new System.EventHandler(this.btnVerplaatsTram_Click);
            // 
            // cbVrijSpoor
            // 
            this.cbVrijSpoor.FormattingEnabled = true;
            this.cbVrijSpoor.Location = new System.Drawing.Point(319, 287);
            this.cbVrijSpoor.Name = "cbVrijSpoor";
            this.cbVrijSpoor.Size = new System.Drawing.Size(180, 24);
            this.cbVrijSpoor.TabIndex = 4;
            this.cbVrijSpoor.SelectedIndexChanged += new System.EventHandler(this.cbVrijSpoor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "vrij spoor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "vrij sector";
            // 
            // cbVrijSector
            // 
            this.cbVrijSector.FormattingEnabled = true;
            this.cbVrijSector.Location = new System.Drawing.Point(319, 325);
            this.cbVrijSector.Name = "cbVrijSector";
            this.cbVrijSector.Size = new System.Drawing.Size(180, 24);
            this.cbVrijSector.TabIndex = 10;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(874, 57);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 11;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // OverzichtTramsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 523);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.cbVrijSector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVrijSpoor);
            this.Controls.Add(this.btnVerplaatsTram);
            this.Controls.Add(this.btnVeranderStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbTrams);
            this.Name = "OverzichtTramsForm";
            this.Text = "OverzichtTramsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTrams;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnVeranderStatus;
        private System.Windows.Forms.Button btnVerplaatsTram;
        private System.Windows.Forms.ComboBox cbVrijSpoor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVrijSector;
        private System.Windows.Forms.Button btnTerug;
    }
}