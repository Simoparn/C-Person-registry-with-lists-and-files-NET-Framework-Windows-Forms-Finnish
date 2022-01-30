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
        public Henkilötietojenmuokkauslomake(Henkilö haettuhlo)
        {
            if (haettuhlo != null)
            {
                
                string[] haetuttiedot = new string[10] { haettuhlo.KerroTunnus(), haettuhlo.KerroEtuNimi(), haettuhlo.KerroSukuNimi(), haettuhlo.KerroSyntymaaika().ToString(), haettuhlo.KerroSukupuoli(), haettuhlo.KerroOsoite(), haettuhlo.KerroPostinumero(), haettuhlo.KerroPostitoimipaikka(), haettuhlo.KerroLuontiaika().ToString(), haettuhlo.KerroMuokkausaika().ToString() };
                
                muokattavatunnuskentta.Text = haetuttiedot[0];
                muokattavaetunimikentta.Text = haetuttiedot[1];
                muokattavasukunimikentta.Text = haetuttiedot[2];
                

                //TODO: Oma metodi? Toimii vain jos kellonaika on nollamuotoa eikä tunnit siis voi olla kaksinumeroisia. Syntymäaika pilkotaan kenttiin.

                //Jos päivä ja kuukausi ovat molemmat yksinumeroisia
                if (haetuttiedot[3].Length==16)
                {
                    muokattavasyntymapaivakentta.Text = haetuttiedot[3].Substring(0, 1);
                    muokattavasyntymakuukausikentta.Text = haetuttiedot[3].Substring(2, 1);
                    muokattavasyntymavuosikentta.Text = haetuttiedot[3].Substring(4, 4);
                }
                //Jos vain päivä on kaksinumeroinen
                else if (haetuttiedot[3].Length==17 && haetuttiedot[3].ElementAt(3)=='.')
                {
                    muokattavasyntymapaivakentta.Text = haetuttiedot[3].Substring(0, 2);
                    muokattavasyntymakuukausikentta.Text = haetuttiedot[3].Substring(3, 1);
                    muokattavasyntymavuosikentta.Text = haetuttiedot[3].Substring(5, 4);

                }
                //Jos vain kuukausi on kaksinumeroinen
                else if (haetuttiedot[3].Length == 17 && haetuttiedot[3].ElementAt(5) == '.')
                {

                    muokattavasyntymapaivakentta.Text = haetuttiedot[3].Substring(0, 1);
                    muokattavasyntymakuukausikentta.Text = haetuttiedot[3].Substring(2, 2);
                    muokattavasyntymavuosikentta.Text = haetuttiedot[3].Substring(5,4);
                }
                //Jos päivä ja kuukausi ovat molemmat kaksinumeroisia
                else
                {
                    muokattavasyntymapaivakentta.Text = haetuttiedot[3].Substring(0, 2);
                    muokattavasyntymakuukausikentta.Text = haetuttiedot[3].Substring(3, 2);
                    muokattavasyntymavuosikentta.Text = haetuttiedot[3].Substring(6, 4);

                }



                muokattavasukupuolikentta.Text = haetuttiedot[4];
                muokattavaosoitekentta.Text = haetuttiedot[5];
                muokattavapostinumerokentta.Text = haetuttiedot[6];
                muokattavapostitoimipaikkakentta.Text = haetuttiedot[7];
                InitializeComponent();
                
            }
            
        }

        private void Vahvistamuokkauksetpainike_Click(object sender, EventArgs e)
        {

            string[] syotetyttiedot = new string[11] { muokattavatunnuskentta.Text, muokattavaetunimikentta.Text, muokattavasukunimikentta.Text, muokattavasyntymapaivakentta.Text, muokattavasyntymakuukausikentta.Text, muokattavasyntymavuosikentta.Text, muokattavasukupuolikentta.Text, muokattavaosoitekentta.Text, muokattavapostinumerokentta.Text, muokattavapostitoimipaikkakentta.Text, "" };
            Program.MuokkaaHenkiloa(syotetyttiedot);
        }
    }
}
