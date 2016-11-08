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
    public partial class SpoorOverzichtForm : Form
    {
        SpoorRepository spoorRepo;
        Medewerker ingelogdeMedewerker { get;  set; }
        List<Spoor> Sporen;
        public SpoorOverzichtForm(Medewerker medewerker)
        {
            spoorRepo = new SpoorRepository(new SqlSpoorContext());
            this.ingelogdeMedewerker = medewerker;
            InitializeComponent();
            UpdateForm();
        }
        public void UpdateForm()
        {
            lbSporen.Items.Clear();
            Sporen = spoorRepo.GetAllSporen();
            foreach(Spoor s in this.Sporen)
            {
                lbSporen.Items.Add(s);
            }
        }

        private void btnBlokkeerSpoor_Click(object sender, EventArgs e)
        {
            spoorRepo.UpdateSpoor(lbSporen.SelectedItem as Spoor, cbStatus.SelectedIndex);
            UpdateForm();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
            WagenparkBeheerderForm w = new WagenparkBeheerderForm(this.ingelogdeMedewerker);
            w.Show();
        }
    }
}
