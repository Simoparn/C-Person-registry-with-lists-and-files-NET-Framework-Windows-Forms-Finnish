using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Graafinen_henkilörekisteri_listoilla_Forms
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>




        
        static string[] sarakkeidennnimet = new string[10] { "HENKILÖTUNNUS", "ETUNIMI", "SUKUNIMI", "SYNTYMÄAIKA", "SUKUPUOLI", "OSOITE", "POSTINUMERO", "POSTITOIMIPAIKKA", "TIETUEEN LUONTIAIKA", "TIETUEEN MUOKKAUSAIKA"};
        static string tiedostopolku = @"../../henkilorekisterintiedot.txt";
        public static List<Henkilö> Henkilorekisteri;

        static void Main()
        {
            try
            {

                Henkilorekisteri = LataaHenkilorekisteri(tiedostopolku);
                DateTime tanaan = DateTime.Today;
                DateTime kellonaika = DateTime.Now;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(Henkilorekisteri));
                
                





              







                


















            }

            catch (Exception)
            {
                //TODO: Virheilmoitus ikkunaan: Virhe ohjelmaa suoritettaessa. Todennäköisesti syötettiin tieto virheellisessä muodossa tai poistettavaa tietoa ei ollut olemassa."

                
            }


        }






        public static string NaytaHenkilonTiedot(string syotettyhenkilotunnus)
        {

            
           
            

            using (StreamReader lukija = File.OpenText(tiedostopolku))
            {
             
                string rivi;
                while ((rivi = lukija.ReadLine()) != null)
                {
                    if (rivi.Contains(syotettyhenkilotunnus))
                    {
                 
                      
                        return rivi.Replace(";", "\t");
                    }

                }
                return "";

            }

        }


        public static string [] NaytaKaikkiTiedot()
        {
            string tiedot="";
            string [] tiedottaulukkona;

          
            tiedot += "Henkilörekisterissä on yhteensä " + Henkilorekisteri.Count + " henkilön tiedot.\n\n";
            tiedot += "\n";
           
            
            using (StreamReader lukija = File.OpenText(tiedostopolku))
            {
                string rivi;
                int[] sarakkeidenpituudet = new int[10];
                int[] kenttienpituudet = new int[10];
                bool[] sisennasarakkeet = new bool[10];
                int indeksi = 0;
                string sisennys = "";

                foreach (string sarake in sarakkeidennnimet)
                {



                    sarakkeidenpituudet[indeksi] = sarake.Length;
                    indeksi++;
                }
               
                indeksi = 0;

                while ((rivi = lukija.ReadLine()) != null)
                {


                    string[] naytettavarivitaulukkona = rivi.Split(';');


                    foreach (string kentta in naytettavarivitaulukkona)
                    {
                        kenttienpituudet[indeksi] = kentta.Length;

                        indeksi++;
                    }

                    indeksi = 0;

                   

                    for (int i = 0; i < sarakkeidenpituudet.Length; i++)
                    {
                        if (naytettavarivitaulukkona[i].Length > sarakkeidenpituudet[i])
                            sisennasarakkeet[i] = true;
                        else sisennasarakkeet[i] = false;

                        indeksi++;
                    }

                    indeksi = 0;
                    sisennys = "";

                    foreach (string sarake in sarakkeidennnimet)
                    {


                        if (sisennasarakkeet[indeksi])
                        {
                            for (int i = 0; i < (naytettavarivitaulukkona[i].Length - sarake.Length) / 2; i++)
                            {

                                sisennys += " ";
                            }
                            tiedot += sisennys + " | " + sarake + " | " + sisennys;

                        }
                        else tiedot += " | " + sarake + " | ";


                        sisennys = "";
                    }

                    tiedot += "\n";


                    indeksi = 0;
                    sisennys = "";

                    foreach (String kentta in naytettavarivitaulukkona)
                    {


                        if (sisennasarakkeet[indeksi])
                            tiedot += " | " + kentta + " | ";
                        else
                        {
                            for (int i = 0; i < (sarakkeidenpituudet[i] - kentta.Length) / 2; i++)
                                sisennys += " ";
                            tiedot += sisennys + " | " + kentta + " | " + sisennys;
                        }
                        sisennys = "";
                        indeksi++;
                    }

                    indeksi = 0;
                    sisennys = "";

                    tiedot += "\n";


                }

                /* testausta varten 
                foreach (Henkilo hlo in Henkilorekisteri) Console.WriteLine(hlo.KerroTunnus());    
                */
                tiedot += "\n\n\n";
                tiedottaulukkona = tiedot.Split('\n');
                return tiedottaulukkona;

            }





        }



        public static void UusiHenkilo(string[] syotetyttiedot)
        {


            syotetyttiedot[10] = DateTime.Now.ToString();

            try
            {
                Henkilorekisteri.Add(new Henkilö(false, true, syotetyttiedot));
            }
            catch (Exception e) { throw new Exception("Poikkeus henkilöä luotaessa."); }

            int rekisterinindeksi = 0;

            //Poistetaan mahdollinen kahdennos listan alusta

            foreach (Henkilö hlo in Henkilorekisteri)
            {
                if (hlo.KerroTunnus().Equals(Henkilorekisteri[0].KerroTunnus()) && !(rekisterinindeksi == 0))
                {

                    Henkilorekisteri[0].PoistaHenkiloTiedostosta();
                    Henkilorekisteri.Remove(Henkilorekisteri[0]);

                }
                rekisterinindeksi++;

            }
           
        }



        public static Henkilö HaeHenkilonTiedot(string syotettytunnus)
        {

            string[] tiedot = new String[10];

            foreach (Henkilö hlo in Henkilorekisteri)
            {


                if (hlo.KerroTunnus().Equals(syotettytunnus))
                {

                    try
                    {
                        return hlo;
                    }
                    catch (InvalidOperationException)
                    {
                        // TODO: Varoitusilmoitus "InvalidOperationException henkilöä muokattaessa"
                    }




                }
                else return null;

            }

            return null;
        }

        public static void MuokkaaHenkiloa(string [] henkilontiedot)
        {




            PoistaHenkilo(henkilontiedot[0]);
            Henkilorekisteri.Add(new Henkilö(true, true, henkilontiedot));




            


        }

        public static bool PoistaHenkilo(string syotettytunnus)
        {







            foreach (Henkilö hlo in Henkilorekisteri) {

                if (hlo.KerroTunnus().Equals(syotettytunnus))
                {

                    try
                    {
                        hlo.PoistaHenkiloTiedostosta();
                    }
                    catch (InvalidOperationException) {
                        // TODO: Varoitusilmoitus "InvalidOperationException henkilöä poistettaessa"
                    }
                    
                   
                    Henkilorekisteri.Remove(hlo);
                    
                   
                    return true;

                }

            }


            return false;


        }
    



    public static void LopetaOhjelma()
    {
        Application.Exit();
    }



    private static List<Henkilö> LataaHenkilorekisteri(string tiedostopolku)
    {
        Henkilorekisteri = new List<Henkilö>();
        // Ladataan henkilörekisteritiedosto

        using (StreamReader lukija = File.OpenText(tiedostopolku))
        {
            string alkulatausrivi;

            while ((alkulatausrivi = lukija.ReadLine()) != null)
            {
                
                string[] rivintiedot = alkulatausrivi.Split(';');
                Henkilorekisteri.Add(new Henkilö(true, false, rivintiedot));


            }

               
        }
        return Henkilorekisteri;

    }
    }
   }


 
