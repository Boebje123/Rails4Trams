﻿namespace Rails4Trams
{
    partial class SchoonmaakForm
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
            this.lbKlein = new System.Windows.Forms.ListBox();
            this.btnAfrondenKleine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAfrondenGrote = new System.Windows.Forms.Button();
            this.lbGroot = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSchoonmaakTerug = new System.Windows.Forms.Button();
            this.btnSchoonmaaklijstAanvragen = new System.Windows.Forms.Button();
            this.tbTijdsindicatie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbKlein
            // 
            this.lbKlein.FormattingEnabled = true;
            this.lbKlein.Location = new System.Drawing.Point(98, 55);
            this.lbKlein.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbKlein.Name = "lbKlein";
            this.lbKlein.Size = new System.Drawing.Size(198, 173);
            this.lbKlein.TabIndex = 0;
            // 
            // btnAfrondenKleine
            // 
            this.btnAfrondenKleine.Location = new System.Drawing.Point(123, 268);
            this.btnAfrondenKleine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAfrondenKleine.Name = "btnAfrondenKleine";
            this.btnAfrondenKleine.Size = new System.Drawing.Size(136, 51);
            this.btnAfrondenKleine.TabIndex = 3;
            this.btnAfrondenKleine.Text = "Afronden kleine beurt";
            this.btnAfrondenKleine.UseVisualStyleBackColor = true;
            this.btnAfrondenKleine.Click += new System.EventHandler(this.btnAfronden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecteer een tram";
            // 
            // btnAfrondenGrote
            // 
            this.btnAfrondenGrote.Location = new System.Drawing.Point(533, 268);
            this.btnAfrondenGrote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAfrondenGrote.Name = "btnAfrondenGrote";
            this.btnAfrondenGrote.Size = new System.Drawing.Size(130, 51);
            this.btnAfrondenGrote.TabIndex = 5;
            this.btnAfrondenGrote.Text = "Afronden grote beurt";
            this.btnAfrondenGrote.UseVisualStyleBackColor = true;
            this.btnAfrondenGrote.Click += new System.EventHandler(this.btnAfrondenGrote_Click);
            // 
            // lbGroot
            // 
            this.lbGroot.FormattingEnabled = true;
            this.lbGroot.Location = new System.Drawing.Point(486, 55);
            this.lbGroot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbGroot.Name = "lbGroot";
            this.lbGroot.Size = new System.Drawing.Size(226, 173);
            this.lbGroot.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toe aan een kleine beurt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Toe aan een grote beurt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Selecteer een tram";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(751, 13);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(69, 35);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Afmelden";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSchoonmaakTerug
            // 
            this.btnSchoonmaakTerug.Location = new System.Drawing.Point(751, 383);
            this.btnSchoonmaakTerug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSchoonmaakTerug.Name = "btnSchoonmaakTerug";
            this.btnSchoonmaakTerug.Size = new System.Drawing.Size(69, 22);
            this.btnSchoonmaakTerug.TabIndex = 11;
            this.btnSchoonmaakTerug.Text = "Terug";
            this.btnSchoonmaakTerug.UseVisualStyleBackColor = true;
            this.btnSchoonmaakTerug.Visible = false;
            this.btnSchoonmaakTerug.Click += new System.EventHandler(this.btnSchoonmaakTerug_Click);
            // 
            // btnSchoonmaaklijstAanvragen
            // 
            this.btnSchoonmaaklijstAanvragen.Location = new System.Drawing.Point(334, 268);
            this.btnSchoonmaaklijstAanvragen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSchoonmaaklijstAanvragen.Name = "btnSchoonmaaklijstAanvragen";
            this.btnSchoonmaaklijstAanvragen.Size = new System.Drawing.Size(100, 53);
            this.btnSchoonmaaklijstAanvragen.TabIndex = 12;
            this.btnSchoonmaaklijstAanvragen.Text = "Schoonmaaklijst aanvragen";
            this.btnSchoonmaaklijstAanvragen.UseVisualStyleBackColor = true;
            this.btnSchoonmaaklijstAanvragen.Click += new System.EventHandler(this.btnSchoonmaaklijstAanvragen_Click);
            // 
            // tbTijdsindicatie
            // 
            this.tbTijdsindicatie.Location = new System.Drawing.Point(345, 163);
            this.tbTijdsindicatie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTijdsindicatie.Name = "tbTijdsindicatie";
            this.tbTijdsindicatie.Size = new System.Drawing.Size(76, 20);
            this.tbTijdsindicatie.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "duur schoonmaak in uur:";
            // 
            // SchoonmaakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 431);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTijdsindicatie);
            this.Controls.Add(this.btnSchoonmaaklijstAanvragen);
            this.Controls.Add(this.btnSchoonmaakTerug);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGroot);
            this.Controls.Add(this.btnAfrondenGrote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAfrondenKleine);
            this.Controls.Add(this.lbKlein);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SchoonmaakForm";
            this.Text = "SchoonmaakForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKlein;
        private System.Windows.Forms.Button btnAfrondenKleine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAfrondenGrote;
        private System.Windows.Forms.ListBox lbGroot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSchoonmaakTerug;
        private System.Windows.Forms.Button btnSchoonmaaklijstAanvragen;
        private System.Windows.Forms.TextBox tbTijdsindicatie;
        private System.Windows.Forms.Label label5;
    }
}