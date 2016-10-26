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
    public partial class TechnicusForm : Form
    {     
        private TramRepository tramRepo;
        private List<Tram> GroteDienst;
        private List<Tram> KleineDienst;
        public TechnicusForm()
        {
          
            InitializeComponent();
            KleineDienst = new List<Tram>();
            GroteDienst = new List<Tram>();
            tramRepo = new TramRepository(new SqlTramContext());
            GroteDienst = tramRepo.GetTramsGroteDienst();
            KleineDienst = tramRepo.GetTramsKleineDienst();
            foreach (Tram t in this.GroteDienst)
            {
                lbGroteDienst.Items.Add(t.ToString());
            }
            foreach (Tram t2 in this.KleineDienst)
            {
                lbKleineDienst.Items.Add(t2.ToString());
            }

        }
        private void btnGroteDienstAfronden_Click(object sender, EventArgs e)
        {

        }
    }
}
