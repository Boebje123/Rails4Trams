using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rails4Trams.Forms
{ 
    public partial class OverzichtGebruikers : Form
    {
        MedewerkerRepository medewerkerRepo;
        List<Medewerker> Medewerkers;
        Medewerker ingelogdeMedewerker { get; set; }
        public OverzichtGebruikers(Medewerker medewerker)
        {
            InitializeComponent();
            medewerkerRepo = new MedewerkerRepository(new SqlMedewerkerContext());
            Medewerkers = new List<Medewerker>();
            UpdateForm();
            this.ingelogdeMedewerker = medewerker;
        }
        public void UpdateForm()
        {
            lbMedewerkers.Items.Clear();
            Medewerkers = medewerkerRepo.GetAllUsers();
            foreach (Medewerker m in this.Medewerkers)
            lbMedewerkers.Items.Add(m);
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            medewerkerRepo.Delete(lbMedewerkers.SelectedItem as Medewerker);
            UpdateForm();
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {

            int functieid = 0;
            string functie = cbFunctie.Text;
            switch (functie)
            {
                case "Beheerder":
                    functieid = 1;
                    break;
                case "Wagenparkbeheerder":
                    functieid = 2;
                    break;
                case "Technicus":
                    functieid = 3;
                    break;
                case "Schoonmaker":
                    functieid = 4;
                    break;
                case "Bestuurder":
                    functieid = 5;
                    break;
            }
            medewerkerRepo.Insert(new Medewerker(tbVoornaam.Text, tbAchternaam.Text, tbGebruikersnaam.Text, tbWachtwoord.Text), functieid);
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WagenparkBeheerderForm wagenparkForm = new WagenparkBeheerderForm(ingelogdeMedewerker);
            wagenparkForm.Show();
        }
    }
}
