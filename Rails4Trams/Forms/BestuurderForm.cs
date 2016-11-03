using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace Rails4Trams
{
    public partial class BestuurderForm : Form
    {
        RFID RFID = new RFID();
        public Medewerker IngelogdeMedewerker { get; set; }
        private TramRepository tramrepo;

        public BestuurderForm(Medewerker beheerder)
        {
            this.IngelogdeMedewerker = beheerder;
            InitializeComponent();
            StartRFID();
            tramrepo = new TramRepository(new SqlTramContext());
        }
  
       public void StartRFID()
        {
            //  initialize Phidgets RFID reader and hook the event handlers
            RFID.Error += new Phidgets.Events.ErrorEventHandler(rfid_Error);

            RFID.Tag += new TagEventHandler(rfid_Tag);

            //open the connection
            RFID.open();

            //wait for an rfid
            RFID.waitForAttachment();

            RFID.Antenna = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }

        private void btnBestFormBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            WagenparkBeheerderForm l = new WagenparkBeheerderForm();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


 
        public void GetTram()
        {
            Tram t = tramrepo.GetTramWithRFID(tbRFID.Text);
            if (t != null)
                lbTramnr.Text = t.id.ToString();
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
        private void rfid_Tag(object sender, TagEventArgs e)
        {
            tbRFID.Text = e.Tag;
            GetTram();
        }

        private void rfid_Error(object sender, EventArgs e)
        {
            MessageBox.Show("RFID Error");
        }

        private void tbRFID_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetTram();
            }
        }
    }
}
