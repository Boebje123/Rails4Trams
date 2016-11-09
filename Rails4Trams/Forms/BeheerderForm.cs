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
        List<Tram> trams;
        List<Sector> sectoren;
        List<Spoor> sporen;

        List<Sector> vrijsectoren;

        SpoorRepository spoorRepo;
        TramRepository tramRepo;
        Logic.SQLContext.SectorRepository sectorRepo;

        public BeheerderForm(Medewerker ingelogdemedewerker)
        {
            spoorRepo = new SpoorRepository(new SqlSpoorContext());
            tramRepo = new TramRepository(new SqlTramContext());
            sectorRepo = new Logic.SQLContext.SectorRepository(new SqlSectorContext());
            this.IngelogdeMedewerker = ingelogdemedewerker;
            InitializeComponent();

            if (IngelogdeMedewerker is WagenparkBeheerder)
            {
                btnTerugBeheerform.Visible = true;
            }
            UpdateForm();
         

        }
      public void UpdateForm()
        {
            cbTram.Items.Clear();
            cbSpoor.Items.Clear();
            this.trams = tramRepo.GetAllTrams();
            this.sporen = spoorRepo.ZoekSpoor();
            this.sectoren = sectorRepo.GetAllSectoren();
            foreach(Spoor s in this.sporen)
            {
                cbSpoor.Items.Add(s);
            }
            foreach(Tram t in this.trams)
            {
                cbTram.Items.Add(t);
            }

        }
        public void UpdateSelectedIndexChange()
        {
            cbSector.Items.Clear();
            this.vrijsectoren = sectorRepo.ZoekVrijSector(cbSpoor.SelectedItem as Spoor);
            foreach(Sector s in this.sectoren)
            {
                cbSector.Items.Add(s);
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
            Simulatie();
           
         
        }
        public void simulatietestTot44(int i)
        {
            foreach (Tram t in this.trams)
            {
                foreach (Sector s in this.sectoren)
                {
                    int cellid = 0;
                    switch (s.spoor.id)
                    {
                       
                        case 41:
                            cellid = 0;
                            break;
                        case 42:
                            cellid = 1;
                            break;
                        case 43:
                            cellid = 2;
                            break;
                        case 44:
                            cellid = 3;
                            break;

                    }
                    if (s.tram == null && s.spoor.id == i)
                    {
                        dvg40tm44.Rows[s.rowNumber - 1].Cells[cellid].Value = "leeg";
                    }

                    if (s.tram != null && s.tram.id == t.id&&s.spoor.id == i)
                    {
                        dvg40tm44.Rows[s.rowNumber - 1].Cells[cellid].Value = s.tram.id;

                    }
                    if (s.Blokkade)
                    {
                        dvg40tm44.Rows[s.rowNumber - 1].Cells[cellid].Value = "xxxxxxx";
                    }
                }
            }

        }
        public void simulatietest40(int i)
        {
            foreach (Tram t in this.trams)
            {
                foreach (Sector s in this.sectoren)
                {
                    int cellid = 0;
                    switch (s.spoor.id)
                    {

                        case 40:
                            cellid = 0;
                            break;

                    }
                    if (s.tram == null && s.spoor.id == i)
                    {
                        dvg40.Rows[s.rowNumber - 1].Cells[cellid].Value = "leeg";
                    }

                    if (s.tram != null && s.tram.id == t.id && s.spoor.id == i)
                    {
                        dvg40.Rows[s.rowNumber - 1].Cells[cellid].Value = s.tram.id;

                    }
                    if (s.Blokkade)
                    {
                        dvg40.Rows[s.rowNumber - 1].Cells[cellid].Value = "xxxxxxx";
                    }
                }
            }

        }
        public void simulatietestTot30(int i)
        {
          

            foreach (Tram t in this.trams)
            {
                foreach (Sector s in this.sectoren)
                {
                    int cellid = 0;
                    switch (s.spoor.id)
                    {
                        case 38:
                            cellid = 0;
                            break;
                        case 37:
                            cellid = 1;
                            break;
                        case 36:                       
                            cellid = 2;
                            break;
                        case 35:            
                            cellid = 3;
                            break;
                        case 34:
                            cellid = 4;
                            break;
                        case 33:
                            cellid = 5;
                            break;
                        case 32:
                            cellid = 6;
                            break;
                        case 31:
                            cellid = 7;
                            break;
                        case 30:
                            cellid = 8;
                            break;
                    }
                    if (s.tram == null && s.spoor.id == i)
                    {                      
                        dgv38tm30.Rows[s.rowNumber - 1].Cells[cellid].Value = "leeg";
                    }
                  
                    if (s.tram != null && s.tram.id == t.id)
                    {
                        dgv38tm30.Rows[s.rowNumber - 1].Cells[cellid].Value = s.tram.id;

                    }
                    if (s.Blokkade)
                    {
                        dgv38tm30.Rows[s.rowNumber - 1].Cells[cellid].Value = "xxxxxxx";
                    }
                }
            }

        }
        public void Simulatie()
        {
            dgv38tm30.Rows.Clear();
            dvg40.Rows.Clear();
            dvg40tm44.Rows.Clear();
            dgv38tm30.Rows.Add(3);
            dvg40tm44.Rows.Add(3);
            dvg40.Rows.Add(10);
            for (int i = 38; i >= 30; i--)
            {
                simulatietestTot30(i);
            }

            for (int i = 41; i <= 44; i++)
            {
                simulatietestTot44(i);
            }
            simulatietest40(40);
            //for (int i = 57; i < 61; i++)
            //{
            //    simulatietest(i);
            //}

        }

        private void btnInvoerTramNr_Click(object sender, EventArgs e)
        {
            sectorRepo.TramInrijden(cbTram.SelectedItem as Tram, cbSpoor.SelectedItem as Spoor, cbSector.SelectedItem as Sector);
            UpdateForm();
            Simulatie();
        }

        private void BeheerderForm_Load(object sender, EventArgs e)
        {

        }

        private void cbSpoor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedIndexChange();
        }
    }
}
