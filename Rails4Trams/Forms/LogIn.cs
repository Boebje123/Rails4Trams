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
    public partial class LogIn : Form
    {
        private  MedewerkerRepository medewerkerRepo;
        BeheerderForm BeheerForm;
        BestuurderForm BestuurderForm;
        SchoonmaakForm SchoonForm;
        TechnicusForm TechnicusForm;
        WagenparkBeheerderForm WagenForm;
        public LogIn()
        {
            InitializeComponent();
            medewerkerRepo = new MedewerkerRepository(new SqlMedewerkerContext());

        }

        public void Login()
        {
            if (medewerkerRepo.LogIn(tbGebruikersnaam.Text, tbWachtwoord.Text))
            {
                Medewerker InlogGebruiker = medewerkerRepo.GetGebruiker(tbGebruikersnaam.Text);
                if (InlogGebruiker is Beheerder)
                {
                    BeheerForm = new BeheerderForm(InlogGebruiker);
                    BeheerForm.Show();
                }
                if (InlogGebruiker is Technicus)
                {
                    TechnicusForm = new TechnicusForm(InlogGebruiker);
               
                    TechnicusForm.Show();
                }
                if (InlogGebruiker is Schoonmaker)
                {
                    SchoonForm = new SchoonmaakForm(InlogGebruiker);
          
                    SchoonForm.Show();
                }
                if (InlogGebruiker is WagenparkBeheerder)
                {
                    WagenForm = new WagenparkBeheerderForm(InlogGebruiker);
         
                    WagenForm.Show();
                }
                if (InlogGebruiker is Bestuurder)
                {
                    BestuurderForm = new BestuurderForm(InlogGebruiker);
              
                    BestuurderForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Uw inlognaam en wachtwoord komen niet overeen.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }
        //login by pressing enter
        private void tbWachtwoord_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
