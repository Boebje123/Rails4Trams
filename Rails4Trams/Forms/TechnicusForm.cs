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
    public partial class TechnicusForm : Form
    {     
        private TramRepository tramRepo;
        private List<Tram> GroteDienst;
        private List<Tram> KleineDienst;
        private ActiviteitRepository activiteitRepo;
      public Medewerker IngelogdeMedewerker { get; set; }
        public TechnicusForm()
        {
          
            InitializeComponent();
            activiteitRepo = new ActiviteitRepository(new SqlActiviteitContext());
            KleineDienst = new List<Tram>();
            GroteDienst = new List<Tram>();
            UpdateForm();

        }
        public void UpdateForm()
        {
            lbGroteDienst.Items.Clear();
            lbKleineDienst.Items.Clear();
            tramRepo = new TramRepository(new SqlTramContext());
            GroteDienst = tramRepo.GetTramsGroteDienst();
            KleineDienst = tramRepo.GetTramsKleineDienst();
            foreach (Tram t in this.GroteDienst)
            {
                lbGroteDienst.Items.Add(t);
            }
            foreach (Tram t2 in this.KleineDienst)
            {
                lbKleineDienst.Items.Add(t2);
            }

        }
        private void btnGroteDienstAfronden_Click(object sender, EventArgs e)
        {
            if (lbGroteDienst.SelectedItem != null && IngelogdeMedewerker != null)
            {
                Activiteit a = new Activiteit(DateTime.Now, DateTime.Now.AddHours(3), 3, IngelogdeMedewerker, lbGroteDienst.SelectedItem as Tram);
                activiteitRepo.Insert(a);
            }
            UpdateForm();
        }

        private void btnKleineDienstAfronden_Click(object sender, EventArgs e)
        {
            if (lbKleineDienst.SelectedItem != null && IngelogdeMedewerker != null)
            {
                Activiteit a = new Activiteit(DateTime.Now, DateTime.Now.AddHours(3),4, IngelogdeMedewerker, lbKleineDienst.SelectedItem as Tram);
                activiteitRepo.Insert(a);
            }
            UpdateForm();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }

      
    }
}
