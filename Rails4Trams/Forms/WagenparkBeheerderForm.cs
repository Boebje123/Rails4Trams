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
       
      
        public WagenparkBeheerderForm()
        {
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

        }

        private void btnOverzichtTrams_Click(object sender, EventArgs e)
        {

        }

        private void btnOverzichtSporen_Click(object sender, EventArgs e)
        {

        }

        private void btnBestuurSchema_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestuurderForm b = new BestuurderForm();
            b.Show();
        }

        private void btnSchoonmaakScheema_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchoonmaakForm s = new SchoonmaakForm(this.IngelogdeMedewerker);
            s.IngelogdeMedewerker = IngelogdeMedewerker;
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

        }
    }
}
