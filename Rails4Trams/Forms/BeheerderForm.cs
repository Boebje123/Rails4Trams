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
   
    public partial class BeheerderForm : Form
    {

        public Medewerker IngelogdeMedewerker { get; set; }

        //  RFID RFID = new RFID();
        public string Welkomlabel
        {
            get
            {
                return this.lbInfo.Text;
            }
            set
            {
                this.lbInfo.Text = value;
            }
        }
        public BeheerderForm(Medewerker ingelogdemedewerker)
        {
            this.IngelogdeMedewerker = ingelogdemedewerker;
            InitializeComponent();

            if (IngelogdeMedewerker is WagenparkBeheerder)
            {
                btnTerugBeheerform.Visible = true;
            }

        }
  

        private void rfid_Error(object sender, EventArgs e)
        {
            MessageBox.Show("RFID Error");
        }

        //private void rfid_Tag(object sender, TagEventArgs e)
        //{
        //    textBox1.Text = e.Tag;
        //}

        private void test_Click(object sender, EventArgs e)
        {
            ////initialize Phidgets RFID reader and hook the event handlers
            //RFID.Error += new Phidgets.Events.ErrorEventHandler(rfid_Error);

            //RFID.Tag += new TagEventHandler(rfid_Tag);

            ////open the connection
            //RFID.open();

            ////wait for an rfid
            //RFID.waitForAttachment();

            ////turn on the lights to show it is on
            //RFID.Antenna = true;
            //btnRFID.Enabled = false;
            //btnRFID.Visible = false;
            //lblRFID.Visible = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }

        private void btnTerugBeheerform_Click(object sender, EventArgs e)
        {
            WagenparkBeheerderForm l = new WagenparkBeheerderForm();
            l.IngelogdeMedewerker = this.IngelogdeMedewerker;
            this.Hide();
            l.Show();
        }
    }
}
