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

        private LogIn mainForm = null;
        public LogIn(Form callingForm)
        {
            medewerkerRepo = new MedewerkerRepository(new SqlMedewerkerContext());
            mainForm = callingForm as LogIn;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (medewerkerRepo.LogIn(textBox1.Text, textBox2.Text))
            {
                Medewerker InlogGebruiker = medewerkerRepo.GetGebruiker(textBox1.Text);
                if(InlogGebruiker is Beheerder)
                { 
                        BeheerForm = new BeheerderForm();
                        BeheerForm.Welkomlabel = InlogGebruiker.ToString();
                        BeheerForm.Show();                  
                }
                if (InlogGebruiker is Technicus)
                {
                    TechnicusForm = new TechnicusForm();
                    TechnicusForm.Show();
                }
                if (InlogGebruiker is Schoonmaker)
                {
                    SchoonForm = new SchoonmaakForm();
                    SchoonForm.Show();
                }
                if (InlogGebruiker is WagenparkBeheerder)
                {
                    WagenForm = new WagenparkBeheerderForm();
                    WagenForm.Show();
                }
                if (InlogGebruiker is Bestuurder)
                {
                    BestuurderForm = new BestuurderForm();
                    BestuurderForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Uw inlognaam en wachtwoord komen niet overeen.");
            }
        }
    }
}
