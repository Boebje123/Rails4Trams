using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rails4Trams
{
    public partial class WagenparkBeheerderForm : Form
    {

        public Medewerker IngelogdeMedewerker { get; set; }
      
      
        public WagenparkBeheerderForm(Medewerker medewerker)
        {
            this.IngelogdeMedewerker = medewerker;
            InitializeComponent();     
        }
      
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }

        private void btnGebBehe_Click(object sender, EventArgs e)
        {
           Forms.OverzichtGebruikers gebruikersForm = new Forms.OverzichtGebruikers(IngelogdeMedewerker);
            gebruikersForm.Show();
            this.Hide();
        }

        private void btnOverzichtTrams_Click(object sender, EventArgs e)
        {
            Forms.OverzichtTramsForm tramsForm = new Forms.OverzichtTramsForm(IngelogdeMedewerker);
            this.Hide();
            tramsForm.Show();
        }

        private void btnOverzichtSporen_Click(object sender, EventArgs e)
        {

        }

        private void btnBestuurSchema_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestuurderForm b = new BestuurderForm(this.IngelogdeMedewerker);
            b.Show();
        }

        private void btnSchoonmaakScheema_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchoonmaakForm s = new SchoonmaakForm(this.IngelogdeMedewerker);
            s.Show();
        }

        private void btnTechSchema_Click(object sender, EventArgs e)
        {

            this.Hide();
            TechnicusForm t = new TechnicusForm(this.IngelogdeMedewerker);
            t.Show();
        }

        private void btnRemiseBeheSchema_Click(object sender, EventArgs e)
        {
            this.Hide();
            BeheerderForm b = new BeheerderForm(this.IngelogdeMedewerker);
            b.Show();
        }
    }
}
