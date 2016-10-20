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
        private  Logic.SQLContext.MedewerkerRepository medewerkerRepo;
        Form1 f;
        public LogIn()
        {
            InitializeComponent();
            medewerkerRepo = new Logic.SQLContext.MedewerkerRepository(new SqlMedewerkerContext());
        }

        private LogIn mainForm = null;
        public LogIn(Form callingForm)
        {
            medewerkerRepo = new Logic.SQLContext.MedewerkerRepository(new SqlMedewerkerContext());
            mainForm = callingForm as LogIn;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (medewerkerRepo.LogIn(textBox1.Text, textBox2.Text))
            {
                f = new Form1();
                Medewerker InlogGebruiker = medewerkerRepo.GetGebruiker(textBox1.Text);
                f.Welkomlabel = InlogGebruiker.ToString();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("FAIL");
            }
        }
    }
}
