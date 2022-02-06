using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Graafinen_henkilörekisteri_listoilla_Forms
{
    public partial class Form1 : Form
    {

        public Form1(List <Henkilö> Henkilorekisteri)

        {
            InitializeComponent();
            
            syottopalkki.Text = "Syötä näytettävän, muokattavan tai poistettavan henkilön henkilötunnus tähän.";
            henkilotietopalkki.Width = 965;
            henkilotietopalkki.Height = 302;
            //  foreach (Henkilö hlo in Henkilorekisteri) ilmoitustietopalkki.Text += "";
        }
        
        //Layoutin oletusasetukset pienennetyssä ja suurennetussa ikkunassa
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                henkilotietopalkki.Width = 865;
                henkilotietopalkki.Height = 202;
            }

            if (this.WindowState == FormWindowState.Maximized)
            {
                henkilotietopalkki.Width = 965;
                henkilotietopalkki.Height = 302;
            }
        }


        private void Naytahenkilopainike_Click(object sender, EventArgs e)
        {
            henkilotietopalkki.Text = "";
            string henkilontieto = Program.NaytaHenkilonTiedot(syottopalkki.Text);

            if (!henkilontieto.Equals(""))
            {

                ilmoitustietopalkki.Text = "\nHenkilön tiedot löytyivät\n";
                henkilotietopalkki.Text = " HENKILÖTUNNUS  ETUNIMI  SUKUNIMI   SYNTYMÄAIKA   SUKUPUOLI  OSOITE   POSTINUMERO   POSTITOIMIPAIKKA   TIETUEEN LUONTIAIKA     TIETUEEN MUOKKAUSAIKA\n\n\t\t";
                henkilotietopalkki.Text += henkilontieto;
            }
            else ilmoitustietopalkki.Text = "\nHenkilön tietoja ei löytynyt.";
        }

        private void Kaikkitiedotpainike_Click(object sender, EventArgs e)
        {
            //Oletusasetukset
            henkilotietopalkki.Text = "";
            syottopalkki.Text = "Syötä näytettävän tai poistettavan henkilön henkilötunnus tähän.";
            henkilotietopalkki.Width = 965;
            henkilotietopalkki.Height = 302;

            string[] rivit = new string [1000];
            rivit = Program.NaytaKaikkiTiedot();
            
            ilmoitustietopalkki.Text = "Kaikkien henkilöiden tiedot";
            henkilotietopalkki.Lines = rivit;
            foreach (string rivi in rivit)
            {
               
                henkilotietopalkki.Height += 5;
                            
                
            }

        }

        private void Uusihenkilopainike_Click(object sender, EventArgs e)
        {
            try
            {


                Uusihenkilölomake uusihenkilolomake = new Uusihenkilölomake();
                uusihenkilolomake.Visible = true;

            }catch(Exception uusihenkilopoikkeus)
            {
                
                ilmoitustietopalkki.Text = uusihenkilopoikkeus.ToString();
            }
        }

        //TODO: lopettaa ohjelman suorituksen ilman poikkeuksia tai virheilmoituksia
        private void Poistahenkilopainike_Click(object sender, EventArgs e)
        {
            

            try
            {

                bool henkiloolemassa = Program.PoistaHenkilo(syottopalkki.Text);
                if (henkiloolemassa) ilmoitustietopalkki.Text = "Henkilö poistettiin rekisteristä ja välimuistista.";
                else ilmoitustietopalkki.Text = " Poistettavaa henkilöä ei löytynyt rekisteristä.";

            }catch(Exception poistahenkilopoikkeus)
            {
                ilmoitustietopalkki.Text = poistahenkilopoikkeus.ToString();
            }
        }
        //TODO: Lopettaa ohjelman suorituksen ilman poikkeuksia tai virheilmoituksia
        private void Lopetaohjelmapainike_Click(object sender, EventArgs e)
        {
           
            Program.LopetaOhjelma();
        }

        private void Syottopalkki_Click(object sender, EventArgs e)
        {
            syottopalkki.Text = "";
        }

        private void Muokkaahenkiloapainike_Click(object sender, EventArgs e)
        {
            //Jos syöttöpalkki ei ole tyhjä ja tiedot löytyvät
            if (!(syottopalkki.Text == "") && !(Program.HaeHenkilonTiedot(syottopalkki.Text) == null))
            {
                Henkilötietojenmuokkauslomake uusimuokkauslomake = new Henkilötietojenmuokkauslomake(Program.HaeHenkilonTiedot(syottopalkki.Text));
                uusimuokkauslomake.Visible = true;
                
            }

            else ilmoitustietopalkki.Text = "Henkilön tietoja ei löytynyt"; 
        }

       
    }
}
