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
            this.SuspendLayout();
            // 
            // lbKlein
            // 
            this.lbKlein.FormattingEnabled = true;
            this.lbKlein.ItemHeight = 16;
            this.lbKlein.Location = new System.Drawing.Point(169, 48);
            this.lbKlein.Name = "lbKlein";
            this.lbKlein.Size = new System.Drawing.Size(182, 212);
            this.lbKlein.TabIndex = 0;
            // 
            // btnAfrondenKleine
            // 
            this.btnAfrondenKleine.Location = new System.Drawing.Point(169, 310);
            this.btnAfrondenKleine.Name = "btnAfrondenKleine";
            this.btnAfrondenKleine.Size = new System.Drawing.Size(182, 63);
            this.btnAfrondenKleine.TabIndex = 3;
            this.btnAfrondenKleine.Text = "Afronden kleine beurt";
            this.btnAfrondenKleine.UseVisualStyleBackColor = true;
            this.btnAfrondenKleine.Click += new System.EventHandler(this.btnAfronden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecteer een tram";
            // 
            // btnAfrondenGrote
            // 
            this.btnAfrondenGrote.Location = new System.Drawing.Point(562, 310);
            this.btnAfrondenGrote.Name = "btnAfrondenGrote";
            this.btnAfrondenGrote.Size = new System.Drawing.Size(174, 63);
            this.btnAfrondenGrote.TabIndex = 5;
            this.btnAfrondenGrote.Text = "Afronden grote beurt";
            this.btnAfrondenGrote.UseVisualStyleBackColor = true;
            // 
            // lbGroot
            // 
            this.lbGroot.FormattingEnabled = true;
            this.lbGroot.ItemHeight = 16;
            this.lbGroot.Location = new System.Drawing.Point(562, 48);
            this.lbGroot.Name = "lbGroot";
            this.lbGroot.Size = new System.Drawing.Size(182, 212);
            this.lbGroot.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toe aan een kleine beurt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Toe aan een grote beurt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Selecteer een tram";
            // 
            // SchoonmaakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGroot);
            this.Controls.Add(this.btnAfrondenGrote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAfrondenKleine);
            this.Controls.Add(this.lbKlein);
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
    }
}