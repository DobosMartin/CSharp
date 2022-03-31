using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gyakorlás2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello valaki,mi a neved?!");
            string s = Console.ReadLine();
            Console.WriteLine("Szia " + s);

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Írj egy számot és én kiírom a kétszeresét");
            string c = Console.ReadLine();
            double szam = Convert.ToDouble(c);
            szam *= 2.00;
            Console.WriteLine("Tessék: " + szam);
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("Kérek két számot és annak ki fogom irní az összegét,külömbségét,szorzatát és hányadosát...Ide alá írd az első számot!");
            int szam1;
            int szam2;
            int osszeg;
            int kulombseg;
            int szorzat;
            int hanyados;
            szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Első szám: " + szam1);
            Console.WriteLine("Kérem a második számot!");
            szam2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Második szám: " + szam2);
            osszeg = szam1 + szam2;
            kulombseg = szam1 - szam2;
            szorzat = szam1 * szam2;
            hanyados = szam1 / szam2;
            Console.WriteLine("A két szám összege: {0}",osszeg);
            Console.WriteLine("A két szám külömbsége: {0}",kulombseg);
            Console.WriteLine("A két szám szorzata: {0}",szorzat);
            Console.WriteLine("A két szám hányadosa: {0}",hanyados);

            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Most két számot kérek tőled és kiírom neked ,hogy melyik szám a nagyobb");
            int szamegy;
            int szamketto;
            szamegy = int.Parse(Console.ReadLine());
            szamketto = int.Parse(Console.ReadLine());
            if (szamegy>szamketto)
            {
                Console.WriteLine("Ez a nagyobb szám: " + szamegy);
            }
            else
            {
                Console.WriteLine("Ez a nagyobb szám: " + szamketto);
            }

            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("írj ide egy zöldséget vagy gyümölcsöt és én eldöntöm,hogy tényleg zöldség vagy gyümölcs-e,(lehetőleg nagy betűvel kezd)");
            string str = Console.ReadLine();
            switch (str)
            {
                case "alma":
                case "Alaszkai áfonya":
                case "Amerikai berkenye":
                case "Amerikai gesztenye":
                case "Amerikai tőzegáfonya":
                case "Ananász":
                case "Arany ribiszke":
                case "Áfonya":
                case "Avokádó":
                case "Banán":
                case "Bérci ribiszke":
                case "Birs":
                case "Bortermő szőlő":
                case "Citrom":
                case "Csillaggyümölcs":
                case "Csipkebogyó":
                case "Csirimojó":
                case "Csonthéjas termések":
                case "Datolyaszilva":
                case "Dió":
                case "Durián":
                case "Édes granadilla":
                case "Egres":
                case "Eper":
                case "Erdei szamóca":
                case "Európai homoktövis":
                case "Fekete áfonya":
                case "Fekete bodza":
                case "Fekete datolyaszilva":
                case "Fekete ribiszke":
                case "Fekete törpeberkenye":
                case "Földicseresznye":
                case "Goji bogyó":
                case "Gránátalma":
                case "Grépfrút":
                case "Havasi boróka":
                case "Húsos som":
                case "Jákafa":
                case "Japán kajszi":
                case "Japán körte":
                case "Japán kumkvat":
                case "Japánnaspolya":
                case "Josta":
                case "Jujuba":
                case "Kajszibarack":
                case "Kaktuszfüge":
                case "Kalamondin":
                case "Kései meggy":
                case "Keserű narancs":
                case "Kínai gesztenye":
                case "Kivi":
                case "Kopasz kivi":
                case "Kökény":
                case "Kumkvat":
                case "Kuruba":
                case "Licsi":
                case "Lime":
                case "Málna":
                case "Mandarin":
                case "Mandula":
                case "Mangó":
                case "Mangosztán":
                case "Maracuja":
                case "Mazsola":
                case "Medjool":
                case "Meggy":
                case "Narancs":
                case "Naranjilla":
                case "Naspolya":
                case "Nemes alma":
                case "Nemes körte":
                case "Nemes szilva":
                case "Óriás passiógyümölcs":
                case "Orosz citrusfajták":
                case "Öreg szőlő":
                case "Őszibarack":
                case "Papaja":
                case "Perui földicseresznye":
                case "Pineberry":
                case "Pitaja":
                case "Pomelo":
                case "Rambután":
                case "Ribiszke":
                case "Sárgadinnye":
                case "Szedermálna":
                case "Szelídgesztenye":
                case "Szőlő":
                case "Szőlőtörköly":
                case "Termesztett ananász":
                case "Tojásdinnye":
                case "Törpe banán":
                case "Tüskétlen szeder":
                case "Vadalma":
                case "Vadcitrom":
                case "Vadcseresznye":
                case "Vadkörte":
                case "Vadszeder":
                case "Nektarin":
                case "Vörös áfonya":
                case "Vörös ribiszke":
                case "Görögdinnye":

                    Console.WriteLine("Gyümölcs");
                    break;

                case "Karalábé":
                case "Articsóka":
                case " Bell paprika":
                case "Bimbós kel":
                case "Bordáskel":
                case "Borsó":
                case "Brokkoli":
                case "Burgonya":
                case "Carolina Reaper":
                case "Cékla":
                case "Cikória":
                case "Csemegekukorica":
                case "Csemegepaprika":
                case "Csicseriborsó":
                case "Csicsóka  ":
                case "Csillagtök":
                case "Csomósbab":
                case "Dioscorea polystachya":
                case "Édesburgonya":
                case "Endívia":
                case "Fejes káposzta":
                case "Feketegyökér":
                case "Fodros kel":
                case "Fokhagyma":
                case "Főzeléklencse":
                case "Hajdúsági torma":
                case "Hónapos retek":
                case "Jamsz":
                case "Juhsóska":
                case "Karalábe":
                case "Karfiol":
                case "Karórépa":
                case "Kék paradicsom":
                case "Kelkáposzta":
                case "Kerti saláta":
                case "Kerti zsázsa":
                case "Kínai kel":
                case "Kövér porcsin":
                case "Közönséges paprika":
                case "Közönséges spárga":
                case "Levélpetrezselyem":
                case "Lila burgonya":
                case "Makói vöröshagyma":
                case "Mángold":
                case "Metélőhagyma":
                case "Mexikói földicseresznye":
                case "Mezei sóska":
                case "Mogyoróhagyma":
                case "Osztottlevelű őzsaláta":
                case "Padlizsán":
                case "Pagodakarfiol":
                case "Paprika":
                case "Paradicsom":
                case "Pepper X":
                case "Petrezselyem":
                case "Petroselinum crispum":
                case "Pézsmatök":
                case "Pimiento paprika":
                case "Rebarbara":
                case "Retek":
                case "Réti bakszakáll":
                case "Rheum rhabarbarum":
                case "Salátagalambbegy":
                case "Sárgarépa":
                case "Spagettitök":
                case "Spárgasaláta":
                case "Spenót":
                case "Sütőtök":
                case "Takarmánylucerna":
                case "Tarlórépa":
                case "Tök ":
                case "Torma":
                case "Uborka":
                case "Vadkáposzta":
                case "Veteménybab":
                case "Vörös káposzta":
                case "Vöröshagyma":
                case "Zeller":
                case "Zöldpaprika":
                case "Zsomborlevelű csucsor":
                    Console.WriteLine("Zöldség");
                    break;

                default:
                    Console.WriteLine("Ez sem zöldség ,sem gyümölcs vagy rosszul írtad a nevét!");
                    break;
            }


            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Menjünk vissza a számok világába. Írj le egy számot és megondom neked,hogy ez pozitív vagy negatív.");
            float num;
            num = Int32.Parse(Console.ReadLine());
            if (num <= 0)
            {
            if (num == 0)
            {
            Console.WriteLine("Amit beírtál nulla.");
            }
            else
            {
            Console.WriteLine(num + " Negatív.");
            }
            }
            else
            {
            Console.WriteLine(num + " Pozitív.");
            }
            
            Console.ReadKey();
        }
    }
}
