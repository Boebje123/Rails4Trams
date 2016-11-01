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
            System.Windows.Forms.Label lbNaarSpoor;
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBestFormBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerstuur = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.lbTramnr = new System.Windows.Forms.Label();
            this.lbSector = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            lbNaarSpoor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNaarSpoor
            // 
            lbNaarSpoor.AutoSize = true;
            lbNaarSpoor.Location = new System.Drawing.Point(140, 69);
            lbNaarSpoor.Name = "lbNaarSpoor";
            lbNaarSpoor.Size = new System.Drawing.Size(0, 17);
            lbNaarSpoor.TabIndex = 9;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(782, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 34);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Afmelden";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBestFormBack
            // 
            this.btnBestFormBack.Location = new System.Drawing.Point(782, 52);
            this.btnBestFormBack.Name = "btnBestFormBack";
            this.btnBestFormBack.Size = new System.Drawing.Size(82, 34);
            this.btnBestFormBack.TabIndex = 1;
            this.btnBestFormBack.Text = "Terug";
            this.btnBestFormBack.UseVisualStyleBackColor = true;
            this.btnBestFormBack.Visible = false;
            this.btnBestFormBack.Click += new System.EventHandler(this.btnBestFormBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tramnr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naar Spoor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sector:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Defect",
            "Vervuild",
            "Dienst",
            "Remise"});
            this.comboBox1.Location = new System.Drawing.Point(151, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerstuur);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(407, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnVerstuur
            // 
            this.btnVerstuur.Location = new System.Drawing.Point(151, 113);
            this.btnVerstuur.Name = "btnVerstuur";
            this.btnVerstuur.Size = new System.Drawing.Size(84, 30);
            this.btnVerstuur.TabIndex = 9;
            this.btnVerstuur.Text = "Verstuur";
            this.btnVerstuur.UseVisualStyleBackColor = true;
            this.btnVerstuur.Click += new System.EventHandler(this.btnVerstuur_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tramnummer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(274, 243);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(207, 22);
            this.tbRFID.TabIndex = 7;
            this.tbRFID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRFID_KeyDown_1);
            // 
            // lbTramnr
            // 
            this.lbTramnr.AutoSize = true;
            this.lbTramnr.Location = new System.Drawing.Point(140, 28);
            this.lbTramnr.Name = "lbTramnr";
            this.lbTramnr.Size = new System.Drawing.Size(0, 17);
            this.lbTramnr.TabIndex = 8;
            // 
            // lbSector
            // 
            this.lbSector.AutoSize = true;
            this.lbSector.Location = new System.Drawing.Point(140, 99);
            this.lbSector.Name = "lbSector";
            this.lbSector.Size = new System.Drawing.Size(0, 17);
            this.lbSector.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "rfid";
            // 
            // BestuurderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 402);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbSector);
            this.Controls.Add(lbNaarSpoor);
            this.Controls.Add(this.lbTramnr);
            this.Controls.Add(this.tbRFID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBestFormBack);
            this.Controls.Add(this.btnLogOut);
            this.Name = "BestuurderForm";
            this.Text = "BestuurderForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBestFormBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerstuur;
        private System.Windows.Forms.Label lbTramnr;
        private System.Windows.Forms.Label lbSector;
        private System.Windows.Forms.Label label6;
    }
}