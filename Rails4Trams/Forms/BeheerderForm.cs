using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets.Events;
using Phidgets;

namespace Rails4Trams
{
   
    public partial class BeheerderForm : Form
    {

        RFID RFID = new RFID();


        public Medewerker IngelogdeMedewerker { get; set; }

        //  RFID RFID = new RFID();

       
        public BeheerderForm(Medewerker ingelogdemedewerker)
        {
            this.IngelogdeMedewerker = ingelogdemedewerker;
            InitializeComponent();

            if (IngelogdeMedewerker is WagenparkBeheerder)
            {
                btnTerugBeheerform.Visible = true;
            }

        }
      



        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }

        private void btnTerugBeheerform_Click(object sender, EventArgs e)
        {
            WagenparkBeheerderForm l = new WagenparkBeheerderForm(IngelogdeMedewerker);
            l.IngelogdeMedewerker = this.IngelogdeMedewerker;
            this.Hide();
            l.Show();
        }

        private void btnTestData_Click(object sender, EventArgs e)
        {
            dgv38tm30.Rows[0].Cells[0].Value = 1;
         
        }
    }
}
