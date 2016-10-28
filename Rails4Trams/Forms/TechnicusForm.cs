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
        public TechnicusForm(Medewerker ingelogdemedewerker)
        {

            this.IngelogdeMedewerker = ingelogdemedewerker;
            InitializeComponent();
            activiteitRepo = new ActiviteitRepository(new SqlActiviteitContext());
            KleineDienst = new List<Tram>();
            GroteDienst = new List<Tram>();

            if (IngelogdeMedewerker is WagenparkBeheerder)
            {
                btnTerugTechForm.Visible = true;
            }

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

        private void btnTerugTechForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            WagenparkBeheerderForm l = new WagenparkBeheerderForm();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WagenparkBeheerderForm w = new WagenparkBeheerderForm();
            w.IngelogdeMedewerker = this.IngelogdeMedewerker;
            this.Hide();
            w.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tram tram1 = lbGroteDienst.SelectedItem as Tram;
            Tram tram2 = lbKleineDienst.SelectedItem as Tram;
            string status = comboBox1.Text;
            int i = 0;
            switch (status)
            {
                case "Defect":
                    i = 1;
                    break;
                case "Dienst":
                    i = 3;
                    break;
                case "Remise":
                    i = 4;
                    break;
            }
            if (i != 0)
                if(tram2!=null && i != 0)
                tramRepo.Update(tram2.id, i);
                if(tram1!=null&& i !=0)
                tramRepo.Update(tram1.id, i);
        }
    }
}
