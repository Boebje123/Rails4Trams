namespace Rails4Trams
{
    partial class WagenparkBeheerderForm
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
            this.btnGebBehe = new System.Windows.Forms.Button();
            this.btnOverzichtTrams = new System.Windows.Forms.Button();
            this.btnOverzichtSporen = new System.Windows.Forms.Button();
            this.btnBestuurSchema = new System.Windows.Forms.Button();
            this.btnSchoonmaakScheema = new System.Windows.Forms.Button();
            this.btnTechSchema = new System.Windows.Forms.Button();
            this.btnRemiseBeheSchema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(619, 37);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(107, 44);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Afmelden";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnGebBehe
            // 
            this.btnGebBehe.Location = new System.Drawing.Point(12, 12);
            this.btnGebBehe.Name = "btnGebBehe";
            this.btnGebBehe.Size = new System.Drawing.Size(133, 50);
            this.btnGebBehe.TabIndex = 1;
            this.btnGebBehe.Text = "Gebruikers beheren";
            this.btnGebBehe.UseVisualStyleBackColor = true;
            this.btnGebBehe.Click += new System.EventHandler(this.btnGebBehe_Click);
            // 
            // btnOverzichtTrams
            // 
            this.btnOverzichtTrams.Location = new System.Drawing.Point(12, 68);
            this.btnOverzichtTrams.Name = "btnOverzichtTrams";
            this.btnOverzichtTrams.Size = new System.Drawing.Size(133, 50);
            this.btnOverzichtTrams.TabIndex = 2;
            this.btnOverzichtTrams.Text = "Overzicht trams";
            this.btnOverzichtTrams.UseVisualStyleBackColor = true;
            this.btnOverzichtTrams.Click += new System.EventHandler(this.btnOverzichtTrams_Click);
            // 
            // btnOverzichtSporen
            // 
            this.btnOverzichtSporen.Location = new System.Drawing.Point(12, 124);
            this.btnOverzichtSporen.Name = "btnOverzichtSporen";
            this.btnOverzichtSporen.Size = new System.Drawing.Size(133, 50);
            this.btnOverzichtSporen.TabIndex = 3;
            this.btnOverzichtSporen.Text = "Overzicht sporen";
            this.btnOverzichtSporen.UseVisualStyleBackColor = true;
            this.btnOverzichtSporen.Click += new System.EventHandler(this.btnOverzichtSporen_Click);
            // 
            // btnBestuurSchema
            // 
            this.btnBestuurSchema.Location = new System.Drawing.Point(12, 180);
            this.btnBestuurSchema.Name = "btnBestuurSchema";
            this.btnBestuurSchema.Size = new System.Drawing.Size(133, 50);
            this.btnBestuurSchema.TabIndex = 4;
            this.btnBestuurSchema.Text = "Bestuurder schema";
            this.btnBestuurSchema.UseVisualStyleBackColor = true;
            this.btnBestuurSchema.Click += new System.EventHandler(this.btnBestuurSchema_Click);
            // 
            // btnSchoonmaakScheema
            // 
            this.btnSchoonmaakScheema.Location = new System.Drawing.Point(12, 236);
            this.btnSchoonmaakScheema.Name = "btnSchoonmaakScheema";
            this.btnSchoonmaakScheema.Size = new System.Drawing.Size(133, 50);
            this.btnSchoonmaakScheema.TabIndex = 5;
            this.btnSchoonmaakScheema.Text = "Schoonmaker schema";
            this.btnSchoonmaakScheema.UseVisualStyleBackColor = true;
            this.btnSchoonmaakScheema.Click += new System.EventHandler(this.btnSchoonmaakScheema_Click);
            // 
            // btnTechSchema
            // 
            this.btnTechSchema.Location = new System.Drawing.Point(12, 292);
            this.btnTechSchema.Name = "btnTechSchema";
            this.btnTechSchema.Size = new System.Drawing.Size(133, 50);
            this.btnTechSchema.TabIndex = 6;
            this.btnTechSchema.Text = "Technicus schema";
            this.btnTechSchema.UseVisualStyleBackColor = true;
            this.btnTechSchema.Click += new System.EventHandler(this.btnTechSchema_Click);
            // 
            // btnRemiseBeheSchema
            // 
            this.btnRemiseBeheSchema.Location = new System.Drawing.Point(12, 348);
            this.btnRemiseBeheSchema.Name = "btnRemiseBeheSchema";
            this.btnRemiseBeheSchema.Size = new System.Drawing.Size(133, 50);
            this.btnRemiseBeheSchema.TabIndex = 7;
            this.btnRemiseBeheSchema.Text = "Remise beheerder schema";
            this.btnRemiseBeheSchema.UseVisualStyleBackColor = true;
            this.btnRemiseBeheSchema.Click += new System.EventHandler(this.btnRemiseBeheSchema_Click);
            // 
            // WagenparkBeheerderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 418);
            this.Controls.Add(this.btnRemiseBeheSchema);
            this.Controls.Add(this.btnTechSchema);
            this.Controls.Add(this.btnSchoonmaakScheema);
            this.Controls.Add(this.btnBestuurSchema);
            this.Controls.Add(this.btnOverzichtSporen);
            this.Controls.Add(this.btnOverzichtTrams);
            this.Controls.Add(this.btnGebBehe);
            this.Controls.Add(this.btnLogOut);
            this.Name = "WagenparkBeheerderForm";
            this.Text = "WagenparkBeheerderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnGebBehe;
        private System.Windows.Forms.Button btnOverzichtTrams;
        private System.Windows.Forms.Button btnOverzichtSporen;
        private System.Windows.Forms.Button btnBestuurSchema;
        private System.Windows.Forms.Button btnSchoonmaakScheema;
        private System.Windows.Forms.Button btnTechSchema;
        private System.Windows.Forms.Button btnRemiseBeheSchema;
    }
}