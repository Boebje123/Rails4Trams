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
    public partial class BestuurderForm : Form
    {
        public Medewerker IngelogdeMedewerker { get; set; }
        private TramRepository tramrepo;

        public BestuurderForm(Medewerker ingelogdemedewerker)
        {
            this.IngelogdeMedewerker = ingelogdemedewerker;

            InitializeComponent();
            this.tramrepo =new TramRepository(new SqlTramContext());

            if (IngelogdeMedewerker is WagenparkBeheerder)
            {
                btnBestFormBack.Visible = true;
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }

        private void btnBestFormBack_Click(object sender, EventArgs e)
        {
            WagenparkBeheerderForm l = new WagenparkBeheerderForm();
            l.IngelogdeMedewerker = this.IngelogdeMedewerker;
            this.Hide();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


 
        private void tbRFID_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Tram t = tramrepo.GetTramWithRFID(tbRFID.Text);
                if (t != null)
                 lbTramnr.Text = t.id.ToString();
            }
        }

        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            string status = comboBox1.Text;
            int i = 0;
            switch (status)
            {
                case "Defect":
                    i = 1;
                    break;
                case "Vervuild":
                    i = 2;
                    break;
                case "Dienst":
                    i = 3;
                    break;
                case "Remise":
                    i = 4;
                    break;
            }
            if (i != 0)
                tramrepo.Update(Convert.ToInt32(textBox1.Text), i);
        }
    }
}
