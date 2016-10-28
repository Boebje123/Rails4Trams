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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTramNr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSpoor = new System.Windows.Forms.Label();
            this.lbSector = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerstuur = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(835, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 34);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Afmelden";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tramnr.";
            // 
            // lbTramNr
            // 
            this.lbTramNr.AutoSize = true;
            this.lbTramNr.Location = new System.Drawing.Point(112, 18);
            this.lbTramNr.Name = "lbTramNr";
            this.lbTramNr.Size = new System.Drawing.Size(21, 17);
            this.lbTramNr.TabIndex = 2;
            this.lbTramNr.Text = "nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naar spoor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sector:";
            // 
            // lbSpoor
            // 
            this.lbSpoor.AutoSize = true;
            this.lbSpoor.Location = new System.Drawing.Point(112, 77);
            this.lbSpoor.Name = "lbSpoor";
            this.lbSpoor.Size = new System.Drawing.Size(58, 17);
            this.lbSpoor.TabIndex = 5;
            this.lbSpoor.Text = "Tramnr.";
            // 
            // lbSector
            // 
            this.lbSector.AutoSize = true;
            this.lbSector.Location = new System.Drawing.Point(112, 133);
            this.lbSector.Name = "lbSector";
            this.lbSector.Size = new System.Drawing.Size(58, 17);
            this.lbSector.TabIndex = 6;
            this.lbSector.Text = "Tramnr.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerstuur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(437, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 196);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnVerstuur
            // 
            this.btnVerstuur.Location = new System.Drawing.Point(115, 127);
            this.btnVerstuur.Name = "btnVerstuur";
            this.btnVerstuur.Size = new System.Drawing.Size(91, 32);
            this.btnVerstuur.TabIndex = 7;
            this.btnVerstuur.Text = "Versturen";
            this.btnVerstuur.UseVisualStyleBackColor = true;
            this.btnVerstuur.Click += new System.EventHandler(this.btnVerstuur_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Defect",
            "Vervuild",
            "Dienst",
            "Remise"});
            this.cbStatus.Location = new System.Drawing.Point(115, 73);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 5;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(115, 27);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tramnr.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbTramNr);
            this.groupBox2.Controls.Add(this.lbSector);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbSpoor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(30, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 176);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "rfid";
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(357, 301);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(100, 22);
            this.tbRFID.TabIndex = 10;
            this.tbRFID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRFID_KeyDown);
            // 
            // BestuurderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 511);
            this.Controls.Add(this.tbRFID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogOut);
            this.Name = "BestuurderForm";
            this.Text = "BestuurderForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTramNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSpoor;
        private System.Windows.Forms.Label lbSector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerstuur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRFID;
    }
}