using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Graafinen_henkilörekisteri_listoilla_Forms
{
    public class Henkilö
    {


            string henkilotunnus;
            string etunimi;
            string sukunimi;
            DateTime syntymaaika;
            DateTime luontiaika;
            DateTime muokkausaika;
            string sukupuoli;
            string osoite;
            string postinumero;
            string postitoimipaikka;
            string tiedostopolku = @"../../henkilorekisterintiedot.txt";



            //TODO: oma metodi henkilötiedon luontiajalle? 
            // kellonajat: " vuotta vanha, tänään on " + tanaan.ToString("d") + " klo " + kellonaika.ToString("HHmmss")));

            public Henkilö(bool luetaantiedostosta, bool kirjoitetaantiedostoon, String[] rivintiedot)
            {



                if (luetaantiedostosta)
                {



                    //Jos henkilötietoja muokataan, eli luetaan tiedostosta ja kirjoitetaan tiedostoon, luodaan henkilö uudelleen

                    if(kirjoitetaantiedostoon)
                    {


                    AsetaTunnus(rivintiedot[0], false);
                    AsetaNimi(rivintiedot[1], rivintiedot[2], false);
                    AsetaSyntymaaika(null, rivintiedot[3], rivintiedot[4], rivintiedot[5], false);
                    AsetaSukupuoli(rivintiedot[4], false);
                    AsetaOsoite(rivintiedot[5], true);
                    AsetaPostinumero(rivintiedot[6], true);
                    AsetaPostitoimipaikka(rivintiedot[7], true);
                    this.luontiaika = DateTime.Parse(rivintiedot[8]);
                    this.muokkausaika = DateTime.Parse(rivintiedot[9]);

                    TallennaTiedostoon(rivintiedot);

                }


                    //Jos henkilötiedot halutaan vain näyttää


                    if (!kirjoitetaantiedostoon)
                    {








                      AsetaTunnus(rivintiedot[0], true);
                      AsetaNimi(rivintiedot[1], rivintiedot[2], true);
                      AsetaSyntymaaika(rivintiedot[3], null, null, null, true);
                      AsetaSukupuoli(rivintiedot[4], true);
                      AsetaOsoite(rivintiedot[5], true);
                      AsetaPostinumero(rivintiedot[6], true);
                      AsetaPostitoimipaikka(rivintiedot[7], true);
                      this.luontiaika = DateTime.Parse(rivintiedot[8]);
                      this.muokkausaika = DateTime.Parse(rivintiedot[9]);




                    }    


                }


              

                if (!luetaantiedostosta)
                {

                    //Tarvitaan, jos tallennetaan käyttäjän antamat henkilötiedot väliaikaisesti ohjelmaan

                    if (!kirjoitetaantiedostoon)
                    {
                        AsetaTunnus(null, false);
                        AsetaNimi(null, null, false);
                        AsetaSyntymaaika(null, null, null, null, false);
                        AsetaSukupuoli(null, false);
                        AsetaOsoite(null, false);
                        AsetaPostinumero(null, false);
                        AsetaPostitoimipaikka(null, false);

                        this.luontiaika = DateTime.Now;
                        this.muokkausaika = DateTime.Now;



                }

                    //Uudet käyttäjätiedot tiedostoon luonnin yhteydessä

                    else
                    {
                        

                        AsetaTunnus(rivintiedot[0], false);
                        AsetaNimi(rivintiedot[1], rivintiedot[2], false);
                        AsetaSyntymaaika(null, rivintiedot[3], rivintiedot[4], rivintiedot[5], false);
                        AsetaSukupuoli(rivintiedot[6], false);
                        AsetaOsoite(rivintiedot[7], false);
                        AsetaPostinumero(rivintiedot[8], false);
                        AsetaPostitoimipaikka(rivintiedot[9], false);

                        this.luontiaika = DateTime.Now;
                        this.muokkausaika = DateTime.Now;
                        string[] syotetytrivintiedot= {"","","","","","","",""};

                        syotetytrivintiedot[0] = KerroTunnus();
                        syotetytrivintiedot[1] = KerroEtuNimi();
                        syotetytrivintiedot[2] = KerroSukuNimi();
                        syotetytrivintiedot[3] = KerroSyntymaaika().ToString();
                        syotetytrivintiedot[4] = KerroSukupuoli();
                        syotetytrivintiedot[5] = KerroOsoite();
                        syotetytrivintiedot[6] = KerroPostinumero();
                        syotetytrivintiedot[7] = KerroPostitoimipaikka();
                       

                        TallennaTiedostoon(syotetytrivintiedot);
                    }


                    
                }


            }





           




            //TODO: tarkistukset henkilötunnuksen muodolle
            public void AsetaTunnus(string tunnus, bool tiedostosta)
            {
                if (tiedostosta)
                {

                    this.henkilotunnus = tunnus;

                }
                else if (!tiedostosta)
                {


                this.henkilotunnus = tunnus;

                }




            }
            public void AsetaNimi(string etunimi, string sukunimi, bool tiedostosta)
            {

                if (tiedostosta)
                {
                    this.etunimi = etunimi;
                    this.sukunimi = sukunimi;
                }

                else if (!tiedostosta)
                {
                    
                    this.etunimi = etunimi;
                    this.sukunimi = sukunimi;

                }


            }

        // Ei saa antaa nollia kuukausien ja päivien alussa
        // TODO: lisää kyselyt kellonajalle.

        public void AsetaSyntymaaika(string syntymaaika, string syntymapaiva, string syntymakuukausi, string syntymavuosi, bool tiedostosta)
            {

            if (tiedostosta)
            {
                this.syntymaaika = DateTime.Parse(syntymaaika);


            }

            else if (!tiedostosta)
            {

                
                


                if (!syntymapaiva.Contains("0") && !syntymakuukausi.Contains("0"))
                {
                    this.syntymaaika = new DateTime(int.Parse(syntymavuosi), int.Parse(syntymakuukausi), int.Parse(syntymapaiva));

                }

                else
                    throw new FormatException("Virheellinen päivämäärä, henkilötietoja ei voida tallentaa.");
                //TODO: varoitusilmoitus ikkunaan?
                


                }



            }




            public void AsetaSukupuoli(string sukupuoli, bool tiedostosta)
            {

                if (tiedostosta)
                {

                    this.sukupuoli = sukupuoli;


                }

                else if (!tiedostosta)
                {


                   
                    if (sukupuoli != "n" && sukupuoli != "m" && sukupuoli != "nainen" && sukupuoli != "mies" && sukupuoli != "Nainen" && sukupuoli != "Mies")
                    {
                      
                        /*"TODO: Varoitusikkuna:\n Et ole mies tai nainen. Sukupuoleksesi asetettiin 'muu'");*/
                        this.sukupuoli = "muu";

                    }
                    else if (sukupuoli == "nainen" || sukupuoli == "n")
                        this.sukupuoli = "nainen";
                    else if (sukupuoli == "mies" || sukupuoli == "m")
                        this.sukupuoli = "mies";



                }


            }


            public void AsetaOsoite(string osoite, bool tiedostosta)
            {

                if (tiedostosta)
                {

                    this.osoite = osoite;

                }

                else if (!tiedostosta)
                {
                    
                    this.osoite = osoite;

                }



            }


            public void AsetaPostinumero(string postinumero, bool tiedostosta)
            {
                if (tiedostosta)
                {
                    this.postinumero = postinumero;


                }

                else if (!tiedostosta)
                {
                  
                    this.postinumero = postinumero;

                }



            }


            public void AsetaPostitoimipaikka(string postitoimipaikka, bool tiedostosta)
            {

                if (tiedostosta)
                {

                    this.postitoimipaikka = postitoimipaikka;

                }

                else if (!tiedostosta)
                {
                   
                    this.postitoimipaikka = postitoimipaikka;

                }




            }


            //TODO: tarkistukset henkilötunnuksen muodolle
            public string KerroTunnus()
            {

                return henkilotunnus;

            }

            public string KerroEtuNimi()
            {

                return etunimi;


            }

            public string KerroSukuNimi()
            {

                return sukunimi;


            }

            public DateTime KerroSyntymaaika()
            {
                return syntymaaika;


            }



            public string KerroSukupuoli()
            {

                return sukupuoli;

            }







          


            public string KerroOsoite()
            {


                return osoite;
            }

            public string KerroPostinumero()
            {

                return postinumero;
            }

            public string KerroPostitoimipaikka()
            {

                return postitoimipaikka;
            }

            public DateTime KerroLuontiaika()
            {
                return this.luontiaika;
            }

            public DateTime KerroMuokkausaika()
            {
                return this.muokkausaika;
            }

        public void TallennaTiedostoon(string[] rivintiedot)
            {




            //Kirjoitetaan tiedostoon 

            string rivi;
            bool henkiloolemassa = false;

            using (StreamReader lukija = File.OpenText(tiedostopolku))
            {

                

                while ((rivi = lukija.ReadLine()) != null)
                {

                    //Tarkistetaan, onko tietue jo olemassa.


                    if (rivi.Contains(henkilotunnus))
                    {

                        henkiloolemassa = true;
                        break;
                    }


                }

            }
                if (!henkiloolemassa)
                {
                  
                    // TODO varoitusikkuna: "\nHenkilön tietoja ei löytynyt, tallennus tiedostoon sallitaan.\n:";

                    //Tarkistetaan, onko rekisteriin tallennettavassa tietuerivissä oikea määrä kenttiä

                    if (rivintiedot.Length == 8)
                    {




                        try
                        {
                            using (StreamWriter kirjoittaja = File.AppendText(tiedostopolku))
                            {
                                kirjoittaja.WriteLine(KerroTunnus() + ";" + KerroEtuNimi() + ";" + KerroSukuNimi() + ";" + KerroSyntymaaika() + ";" + KerroSukupuoli() + ";" + KerroOsoite() + ";" + KerroPostinumero() + ";" + KerroPostitoimipaikka() + ";" + KerroLuontiaika()+";"+KerroMuokkausaika());
                                kirjoittaja.Close();
                            }

                        }
                        catch (IOException) { /*TODO: varoitusikkuna "Ei voitu tallentaa uutta henkilöä rekisteriin, koska rekisteritiedostoa käytetään muualta."; */ }



                    }




                    //TODO: else varoitusikkuna "Henkilötietokenttiä on väärä määrä, henkilötietuetta ei voitu tallentaa.";
                }



                else
                    {
                       //TODO: varoitusikkuna "Henkilö on jo olemassa, tietoja ei voitu tallentaa.";

                    }

                
            }




            //TODO
            public void PoistaHenkiloTiedostosta()
            {



                try
                {


                    string rivi;
                    string kopioitavarivi;
                    string korjattutiedosto = "";
                    bool loytyipoistettava = false;

                
                    using (StreamReader lukija = File.OpenText(tiedostopolku))
                    {

                        while ((rivi = lukija.ReadLine()) != null)
                        {



                            if (rivi.Contains(KerroTunnus()))
                            {



                                loytyipoistettava = true;
                            }

                        }




                    }

                    if (loytyipoistettava)
                    {
                        using (StreamReader kopiolukija = File.OpenText(tiedostopolku))
                        {

                            while ((kopioitavarivi = kopiolukija.ReadLine()) != null)
                            {

                                if (!kopioitavarivi.Contains(KerroTunnus()))
                                {
                                
                                 // TODO: Ilmoitusviesti "Säilytettävä rivi: " + kopioitavarivi);
                                 // TODO: Ilmoitusviesti "\nKopioitiin säilytettävä rivi tiedostoon.");
                                
                                    korjattutiedosto = string.Concat(korjattutiedosto, kopioitavarivi + "\n");
                                }



                            }
                            //TODO: Ilmoitusviesti "Korjattu tiedosto: " + korjattutiedosto);


                        }


                        File.WriteAllText(tiedostopolku, korjattutiedosto);





                    }




                }

                catch (IOException) {

                // TODO: Virheilmoitus "Virhe poistettaessa yhden henkilön tietoja, rekisteritiedostoa käytetään muualta."; 
                }

            }

    }






    
}
