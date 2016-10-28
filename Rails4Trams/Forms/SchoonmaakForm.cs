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
    public partial class SchoonmaakForm : Form
    {
        private TramRepository tramRepo;
        private ActiviteitRepository activiteitRepo;
        private List<Tram> GroteBeurt;
        private List<Tram> KleineBeurt;
        public Medewerker IngelogdeMedewerker { get; set; }
     
        public SchoonmaakForm()
        {
            InitializeComponent();
            KleineBeurt = new List<Tram>();
            GroteBeurt = new List<Tram>();
           
            tramRepo = new TramRepository(new SqlTramContext());
            activiteitRepo = new ActiviteitRepository(new SqlActiviteitContext());

            UpdateForm();

        }
        public void UpdateForm()
        {
            lbGroot.Items.Clear();
            lbKlein.Items.Clear();
            GroteBeurt = tramRepo.GetTramsGroteSchoonmaak();
            KleineBeurt = tramRepo.GetTramsKleineSchoonmaak();
            foreach (Tram t in this.GroteBeurt)
            {
                lbGroot.Items.Add(t);
            }
            foreach (Tram t2 in this.KleineBeurt)
            {
                lbKlein.Items.Add(t2);
            }

        }
        private void btnAfronden_Click(object sender, EventArgs e)
        {
            if (lbKlein.SelectedItem != null && IngelogdeMedewerker != null)
            {
              Activiteit a= new Activiteit(DateTime.Now, DateTime.Now.AddHours(3), 2, IngelogdeMedewerker, lbKlein.SelectedItem as Tram);
                activiteitRepo.Insert(a);
            }
            UpdateForm();
        }

        private void btnAfrondenGrote_Click(object sender, EventArgs e)
        {
         
            if (lbGroot.SelectedItem != null && IngelogdeMedewerker != null)
            {
                Activiteit a = new Activiteit(DateTime.Now, DateTime.Now.AddHours(6), 1, IngelogdeMedewerker, lbGroot.SelectedItem as Tram);
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
