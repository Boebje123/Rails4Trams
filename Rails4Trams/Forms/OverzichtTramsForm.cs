using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rails4Trams.Forms
{
    public partial class OverzichtTramsForm : Form
    {
        TramRepository tramRepo;
        Logic.SQLContext.SectorRepository sectorRepo;
        List<Spoor> sporen;
        public OverzichtTramsForm()
        {
            InitializeComponent();
            tramRepo = new TramRepository(new SqlTramContext());
            sectorRepo = new Logic.SQLContext.SectorRepository(new Logic.Context.SqlSectorContext());
        }

        public void UpdateForm()
        {
            lbTrams.Items.Clear();
            List<Tram> trams = tramRepo.GetAllTrams();
            foreach(Tram t in trams)
            {
                lbTrams.Items.Add(t);
            }
         //   List<Spoor> sporen = sectorRepo.ZoekVrijSector(lbTrams.SelectedItem as Tram);
            foreach (Spoor s in this.sporen)
            {
                cbVrijSpoor.Items.Add(s);
            }
        }

        private void btnVeranderStatus_Click(object sender, EventArgs e)
        {
            string status = cbStatus.Text;
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
            Tram updateTram = lbTrams.SelectedItem as Tram;
            if (i != 0 && updateTram != null)
                tramRepo.Update(updateTram.id, i);
        }

        private void lbTrams_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
