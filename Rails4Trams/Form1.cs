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
    public partial class Form1 : Form
    {
      //  RFID RFID = new RFID();

        public Form1()
        {
            InitializeComponent();
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
    }
}
