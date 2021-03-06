﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rails4Trams
{
    public partial class SchoonmaakForm : Form
    {
        private TramRepository tramRepo;
        private ActiviteitRepository activiteitRepo;
        private List<Tram> GroteBeurt;
        private List<Tram> KleineBeurt;
        public Medewerker IngelogdeMedewerker { get; set; }
     
        public SchoonmaakForm(Medewerker ingelogdemedewerker)
        {

            this.IngelogdeMedewerker = ingelogdemedewerker;
            InitializeComponent();
            KleineBeurt = new List<Tram>();
            GroteBeurt = new List<Tram>();

            if (IngelogdeMedewerker is WagenparkBeheerder)
            {
                btnSchoonmaakTerug.Visible = true;
            }

            tramRepo = new TramRepository(new SqlTramContext());
            activiteitRepo = new ActiviteitRepository(new SqlActiviteitContext());

            UpdateForm();

        }
        public void UpdateForm()
        {
            lbGroot.Items.Clear();
            lbKlein.Items.Clear();
            GroteBeurt = tramRepo.GetTramsGroteSchoonmaak();
            KleineBeurt = tramRepo.GetTramsKleineSchoonmaak();
            foreach (Tram t in this.GroteBeurt)
            {
                lbGroot.Items.Add(t);
            }
            foreach (Tram t2 in this.KleineBeurt)
            {
                lbKlein.Items.Add(t2);
            }

        }
        private void btnAfronden_Click(object sender, EventArgs e)
        {
            if (tbTijdsindicatie.Text == null)
            {
                MessageBox.Show("vul een tijdsindicatie in");
            }
            else
             if (lbKlein.SelectedItem != null && IngelogdeMedewerker != null)
             {
                if (activiteitRepo.CountTramsKleineSchoonmaak() > 10)
                {
                    MessageBox.Show("er zijn al 10 kleine schoonmaakbeurten aan de gang");
                }
                else
                {
                    Activiteit a = new Activiteit(DateTime.Now, DateTime.Now.AddHours(Convert.ToInt32(tbTijdsindicatie.Text)), 2, IngelogdeMedewerker, lbKlein.SelectedItem as Tram);
                    activiteitRepo.Insert(a);
                    tramRepo.Update(a.Tram.id, 4);
                }
            }
            UpdateForm();
        }

        private void btnAfrondenGrote_Click(object sender, EventArgs e)
        {
            if (tbTijdsindicatie.Text == null)
            {
                MessageBox.Show("vul een tijdsindicatie in");
            }
            else
           if (lbGroot.SelectedItem != null && IngelogdeMedewerker != null)
            {
                if (activiteitRepo.CountTramsGroteSchoonmaak() > 5)
                {
                    MessageBox.Show("er zijn al 5 grote schoonmaakbeurten aan de gang");
                }
                else
                {
                    Activiteit a = new Activiteit(DateTime.Now, DateTime.Now.AddHours(Convert.ToInt32(tbTijdsindicatie.Text)), 1, IngelogdeMedewerker, lbGroot.SelectedItem as Tram);
                    activiteitRepo.Insert(a);
                    tramRepo.Update(a.Tram.id, 4);
                }
            }
            UpdateForm();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }

        private void btnSchoonmaakTerug_Click(object sender, EventArgs e)
        {
            WagenparkBeheerderForm w = new WagenparkBeheerderForm(IngelogdeMedewerker);
            w.IngelogdeMedewerker = this.IngelogdeMedewerker;
            this.Hide();
            w.Show();
        }

        private void btnSchoonmaaklijstAanvragen_Click(object sender, EventArgs e)
        {
            List<Activiteit> schoonmaaklijst = activiteitRepo.VraagSchoonmaaklijstAan();
            SaveFileDialog file;      

            string actitiveit = "";

            try
            {
                file = new SaveFileDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {

                    using (StreamWriter sw = new StreamWriter(file.FileName))
                        foreach (Activiteit a in schoonmaaklijst)
                        {
                            int i = a.ActiviteitiD;

                            switch (i)
                            {
                                case 1:
                                    actitiveit = "Grote schoonmaak";
                                    break;
                                case 2:
                                    actitiveit = "Kleine Schoonmaak";
                                    break;
                            }
                            sw.WriteLine("Voornaam Schoonmaker: " + a.medewerker.Voornaam);
                            sw.WriteLine("Tram id: " + a.Tram.id);
                            sw.WriteLine(actitiveit);
                            sw.WriteLine("BeginTijd: " + a.BeginDatum);
                            sw.WriteLine("EindTijd: " + a.EindDatum);
                            sw.WriteLine(" ");
                        }
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
