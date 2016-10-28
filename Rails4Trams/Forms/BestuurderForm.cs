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
        private TramRepository tramRepo;
  
        public BestuurderForm()
        {
            InitializeComponent();
            tramRepo = new TramRepository(new SqlTramContext());
        }
        public void UpdateForm()
        {
            //lbTramNr.Text = gettramnr;
            //lb
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }

        private void tbRFID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
               Tram t = tramRepo.GetTramWithRFID(tbRFID.Text);
                if(t != null)
                lbTramNr.Text = t.id.ToString();
            }
        }

        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            string status = cbStatus.Text;
            int i = 0;
            switch(status)
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
            if(i != 0)
            tramRepo.Update(Convert.ToInt32(tbID.Text), i);
        }
    }
}
