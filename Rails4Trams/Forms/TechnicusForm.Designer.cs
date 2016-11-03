namespace Rails4Trams
{
    partial class TechnicusForm
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
            this.lbKleineDienst = new System.Windows.Forms.ListBox();
            this.lbGroteDienst = new System.Windows.Forms.ListBox();
            this.btnKleineDienstAfronden = new System.Windows.Forms.Button();
            this.btnGroteDienstAfronden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnVeranderStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTerugTechForm = new System.Windows.Forms.Button();
            this.tbTijdsindicatie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbKleineDienst
            // 
            this.lbKleineDienst.FormattingEnabled = true;
            this.lbKleineDienst.Location = new System.Drawing.Point(123, 63);
            this.lbKleineDienst.Margin = new System.Windows.Forms.Padding(2);
            this.lbKleineDienst.Name = "lbKleineDienst";
            this.lbKleineDienst.Size = new System.Drawing.Size(246, 199);
            this.lbKleineDienst.TabIndex = 0;
            // 
            // lbGroteDienst
            // 
            this.lbGroteDienst.FormattingEnabled = true;
            this.lbGroteDienst.Location = new System.Drawing.Point(612, 63);
            this.lbGroteDienst.Margin = new System.Windows.Forms.Padding(2);
            this.lbGroteDienst.Name = "lbGroteDienst";
            this.lbGroteDienst.Size = new System.Drawing.Size(237, 199);
            this.lbGroteDienst.TabIndex = 1;
            // 
            // btnKleineDienstAfronden
            // 
            this.btnKleineDienstAfronden.Location = new System.Drawing.Point(195, 285);
            this.btnKleineDienstAfronden.Margin = new System.Windows.Forms.Padding(2);
            this.btnKleineDienstAfronden.Name = "btnKleineDienstAfronden";
            this.btnKleineDienstAfronden.Size = new System.Drawing.Size(78, 40);
            this.btnKleineDienstAfronden.TabIndex = 2;
            this.btnKleineDienstAfronden.Text = "Kleine dienst afronden";
            this.btnKleineDienstAfronden.UseVisualStyleBackColor = true;
            this.btnKleineDienstAfronden.Click += new System.EventHandler(this.btnKleineDienstAfronden_Click);
            // 
            // btnGroteDienstAfronden
            // 
            this.btnGroteDienstAfronden.Location = new System.Drawing.Point(694, 293);
            this.btnGroteDienstAfronden.Margin = new System.Windows.Forms.Padding(2);
            this.btnGroteDienstAfronden.Name = "btnGroteDienstAfronden";
            this.btnGroteDienstAfronden.Size = new System.Drawing.Size(89, 40);
            this.btnGroteDienstAfronden.TabIndex = 3;
            this.btnGroteDienstAfronden.Text = "Grote dienst afronden";
            this.btnGroteDienstAfronden.UseVisualStyleBackColor = true;
            this.btnGroteDienstAfronden.Click += new System.EventHandler(this.btnGroteDienstAfronden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kleine dienst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grote dienst";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(871, 23);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(68, 35);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Afmelden";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Defect",
            "Dienst",
            "Remise"});
            this.comboBox1.Location = new System.Drawing.Point(449, 123);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // btnVeranderStatus
            // 
            this.btnVeranderStatus.Location = new System.Drawing.Point(462, 159);
            this.btnVeranderStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnVeranderStatus.Name = "btnVeranderStatus";
            this.btnVeranderStatus.Size = new System.Drawing.Size(72, 41);
            this.btnVeranderStatus.TabIndex = 8;
            this.btnVeranderStatus.Text = "Verander status";
            this.btnVeranderStatus.UseVisualStyleBackColor = true;
            this.btnVeranderStatus.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status";
            // 
            // btnTerugTechForm
            // 
            this.btnTerugTechForm.Location = new System.Drawing.Point(883, 388);
            this.btnTerugTechForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnTerugTechForm.Name = "btnTerugTechForm";
            this.btnTerugTechForm.Size = new System.Drawing.Size(56, 26);
            this.btnTerugTechForm.TabIndex = 10;
            this.btnTerugTechForm.Text = "Terug";
            this.btnTerugTechForm.UseVisualStyleBackColor = true;
            this.btnTerugTechForm.Visible = false;
            this.btnTerugTechForm.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbTijdsindicatie
            // 
            this.tbTijdsindicatie.Location = new System.Drawing.Point(458, 254);
            this.tbTijdsindicatie.Margin = new System.Windows.Forms.Padding(2);
            this.tbTijdsindicatie.Name = "tbTijdsindicatie";
            this.tbTijdsindicatie.Size = new System.Drawing.Size(76, 20);
            this.tbTijdsindicatie.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "duur reperatie in uur:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Selecteer een tram";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Selecteer een tram";
            // 
            // TechnicusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 439);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTijdsindicatie);
            this.Controls.Add(this.btnTerugTechForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVeranderStatus);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGroteDienstAfronden);
            this.Controls.Add(this.btnKleineDienstAfronden);
            this.Controls.Add(this.lbGroteDienst);
            this.Controls.Add(this.lbKleineDienst);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TechnicusForm";
            this.Text = "TechnicusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKleineDienst;
        private System.Windows.Forms.ListBox lbGroteDienst;
        private System.Windows.Forms.Button btnKleineDienstAfronden;
        private System.Windows.Forms.Button btnGroteDienstAfronden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnVeranderStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTerugTechForm;
        private System.Windows.Forms.TextBox tbTijdsindicatie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}