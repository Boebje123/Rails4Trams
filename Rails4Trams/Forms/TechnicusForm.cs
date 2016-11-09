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
            if (tbTijdsindicatie.Text == null)
            {
                MessageBox.Show("vul een tijdsindicatie in");
            }
            else
        if (lbGroteDienst.SelectedItem != null && IngelogdeMedewerker != null)
            {
                if (activiteitRepo.CountTramsKleineDienst() > 1)
                {
                    MessageBox.Show("er is al 1 grote dienst aan de gang");
                }
                else
                {
                    Activiteit a = new Activiteit(DateTime.Now, DateTime.Now.AddHours(Convert.ToInt32(tbTijdsindicatie.Text)), 3, IngelogdeMedewerker, lbGroteDienst.SelectedItem as Tram);
                    activiteitRepo.Insert(a);
                    tramRepo.Update(a.Tram.id, 4);
                }
            }
            UpdateForm();
        }

        private void btnKleineDienstAfronden_Click(object sender, EventArgs e)
        {
            if (tbTijdsindicatie.Text == null)
            {
              
                MessageBox.Show("vul een tijdsindicatie in");
            }
            else
            if (lbKleineDienst.SelectedItem != null && IngelogdeMedewerker != null)
            {

                if (activiteitRepo.CountTramsKleineDienst() > 4)
                {
                    MessageBox.Show("er zijn al 4 kleine diensten aan de gang");
                }
                else
                {
                    Activiteit a = new Activiteit(DateTime.Now, DateTime.Now.AddHours(Convert.ToInt32(tbTijdsindicatie.Text)), 4, IngelogdeMedewerker, lbKleineDienst.SelectedItem as Tram);
                    activiteitRepo.Insert(a);
                    tramRepo.Update(a.Tram.id, 4);
                }
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
            WagenparkBeheerderForm l = new WagenparkBeheerderForm(IngelogdeMedewerker);
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WagenparkBeheerderForm w = new WagenparkBeheerderForm(IngelogdeMedewerker);

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
