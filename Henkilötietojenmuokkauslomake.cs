using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graafinen_henkilörekisteri_listoilla_Forms
{
    public partial class Henkilötietojenmuokkauslomake : Form
    {
        Henkilö muokattavahlo;
        public Henkilötietojenmuokkauslomake(Henkilö haettuhlo)
        {
            if (haettuhlo != null)
            {
                muokattavahlo = haettuhlo;
                
                
                muokattavatunnuskentta.Text = haettuhlo.KerroTunnus();
                muokattavaetunimikentta.Text = haettuhlo.KerroEtuNimi();
                muokattavasukunimikentta.Text = haettuhlo.KerroSukuNimi();

                //TODO: Oma metodi? Toimii vain jos kellonaika on nollamuotoa eikä tunnit siis voi olla kaksinumeroisia.
                // Syntymäaika pilkotaan kenttiin.
                muokattavasyntymapaivakentta.Text = haettuhlo.KerroSyntymaaika().ToString().Split('.')[1];
                muokattavasyntymakuukausikentta.Text = haettuhlo.KerroSyntymaaika().ToString().Split('.')[2];
                muokattavasyntymavuosikentta.Text = haettuhlo.KerroSyntymaaika().ToString().Split('.')[3];

                muokattavasukupuolikentta.Text = haettuhlo.KerroSukupuoli();
                muokattavaosoitekentta.Text = haettuhlo.KerroOsoite();
                muokattavapostinumerokentta.Text = haettuhlo.KerroPostinumero();
                muokattavapostitoimipaikkakentta.Text = haettuhlo.KerroPostitoimipaikka();
                InitializeComponent();
                
            }
            
        }

        private void Vahvistamuokkauksetpainike_Click(object sender, EventArgs e)
        {

            string[] syotetyttiedot = new string[12] { muokattavatunnuskentta.Text, muokattavaetunimikentta.Text, muokattavasukunimikentta.Text, muokattavasyntymapaivakentta.Text, muokattavasyntymakuukausikentta.Text, muokattavasyntymavuosikentta.Text, muokattavasukupuolikentta.Text, muokattavaosoitekentta.Text, muokattavapostinumerokentta.Text, muokattavapostitoimipaikkakentta.Text, muokattavahlo.KerroLuontiaika().ToString(), muokattavahlo.KerroMuokkausaika().ToString()};
            Program.MuokkaaHenkiloa(syotetyttiedot);
        }
    }
}
