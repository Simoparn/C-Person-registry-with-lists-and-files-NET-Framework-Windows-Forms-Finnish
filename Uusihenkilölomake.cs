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
    public partial class Uusihenkilölomake : Form
    {
        public Uusihenkilölomake()
        {
            InitializeComponent();
        }

        private void Luohenkilopainike_Click(object sender, EventArgs e)
        {
            string[] syotetyttiedot = new string[11] { uusitunnuskentta.Text, uusietunimikentta.Text, uusisukunimikentta.Text, uusisyntymapaivakentta.Text, uusisyntymakuukausikentta.Text, uusisyntymavuosikentta.Text, uusisukupuolikentta.Text, uusiosoitekentta.Text, uusipostinumerokentta.Text, uusipostitoimipaikkakentta.Text, "" };
            try
            {
                Program.UusiHenkilo(syotetyttiedot);
                this.uusihenkiloilmoitustietopalkki.Text = "Uusi henkilö tallentui onnistuneesti rekisteriin.";
            } catch (Exception exception) {
                this.uusihenkiloilmoitustietopalkki.Text = "Annetut henkilötiedot ovat virheellisessä muodossa, uutta henkilöä ei voida tallentaa rekisteriin.";
            }
                



        }
    }
}
