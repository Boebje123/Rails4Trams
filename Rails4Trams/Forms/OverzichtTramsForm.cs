﻿using System;
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
        SpoorRepository spoorrepo;
        List<Spoor> sporen;
       
       private Medewerker IngelogdeMedeweker;
        public OverzichtTramsForm(Medewerker medewerker)
        {
        
            this.IngelogdeMedeweker = medewerker;
            InitializeComponent();
            tramRepo = new TramRepository(new SqlTramContext());
            sectorRepo = new Logic.SQLContext.SectorRepository(new SqlSectorContext());
            spoorrepo = new SpoorRepository(new SqlSpoorContext());
            sporen = new List<Spoor>();
            UpdateForm();
        }

        public void UpdateForm()
        {
            lbTrams.Items.Clear();
            cbVrijSpoor.Items.Clear();
            List<Tram> trams = tramRepo.GetAllTrams();
           
            foreach (Tram t in trams)
            {
                lbTrams.Items.Add(t);
            }
     
            foreach (Spoor sp in this.sporen)
            {
                cbVrijSpoor.Items.Add(sp);
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
            UpdateForm();
        }

        private void lbTrams_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbVrijSpoor.Items.Clear();
            this.sporen = spoorrepo.ZoekSpoor();
            foreach (Spoor sp in this.sporen)
            {
                cbVrijSpoor.Items.Add(sp);
            }
        }

        private void cbVrijSpoor_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Sector> sector = sectorRepo.ZoekVrijSector(cbVrijSpoor.SelectedItem as Spoor);
            cbVrijSector.Items.Clear();
            foreach (Sector s in sector)
            {
                cbVrijSector.Items.Add(s);
            }
        }

        private void btnVerplaatsTram_Click(object sender, EventArgs e)
        {
            if (sectorRepo.CheckTram(lbTrams.SelectedItem as Tram) == false)
            {
                sectorRepo.TramInrijden(lbTrams.SelectedItem as Tram, cbVrijSpoor.SelectedItem as Spoor, cbVrijSector.SelectedItem as Sector);
            }
            else MessageBox.Show("rijd deze tram eerst uit");
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            WagenparkBeheerderForm wagenForm = new WagenparkBeheerderForm(IngelogdeMedeweker);
            this.Hide();
            wagenForm.Show();
        }
    }
}
