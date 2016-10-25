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
    public partial class SchoonmaakForm : Form
    {
        private TramRepository tramRepo;
        private List<Tram> GroteBeurt;
        private List<Tram> KleineBeurt;
        public SchoonmaakForm()
        {
            KleineBeurt = new List<Tram>();
            GroteBeurt = new List<Tram>();
            InitializeComponent();
            tramRepo = new TramRepository(new SqlTramContext());
            GroteBeurt = tramRepo.GetTramsGroteSchoonmaak();
            KleineBeurt = tramRepo.GetTramsKleineSchoonmaak();
            foreach(Tram t in this.GroteBeurt)
            {
                lbGroot.Items.Add(t.ToString());
            }
            foreach (Tram t2 in this.KleineBeurt)
            {
                lbKlein.Items.Add(t2.ToString());
            }

        }

        private void btnAfronden_Click(object sender, EventArgs e)
        {

        }
    }
}
