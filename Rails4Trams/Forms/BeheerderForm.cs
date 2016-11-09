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
            dgv38tm30.Rows.Add(3);
            dvg40tm44.Rows.Add(10);


        }
      public void UpdateForm()
        {
            this.trams = tramRepo.GetAllTrams();
            this.sectoren = sectorRepo.GetAllSectoren();
            this.sporen = spoorRepo.GetAllSporen();
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

                    if (s.tram != null && s.tram.id == t.id)
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

            for (int i = 38; i >= 30; i--)
            {
                simulatietestTot30(i);
            }

            for (int i = 41; i < 44; i++)
            {
                simulatietestTot44(i);
            }

            //for (int i = 57; i < 61; i++)
            //{
            //    simulatietest(i);
            //}

        }     
    }
}
