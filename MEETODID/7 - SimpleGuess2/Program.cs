using System.ComponentModel.Design;
using System.Xml;
using System.IO;

namespace _7_SimpleGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Lisa juurde raha muutuja ja kolm eventi mis muudavad raha seisu - MEETODITEGA
             */
            /*
            Lisa juurde veritsemine.
            - Selle jaoks on vaja booleani, mis mäletab kas sa veritsed või mitte
            - Ning peale igat eventi, on teine, täisarvu muutuja, mis mäletab palju ühest elust alles on, peale igat eventi 
            võetakse maha 10st punkt, ja kui summa on 0, siis võetakse maha 1 elu.
            - Lisa üks event mis tervendab veritsemise, lisa veritsemisomadus juurde nendele olukordadele kus kasutaja ka tavaliselt elusid kaotab
             */




            /* salvestus ja laadimine*/
            /*
             * kasutades erinevaid failioperatsioone, tee mängule juurde salvestus, mis jätab meelde palju mängijal on:
             * - raha
             * - elusid
             * - seljakoti sisu
             * - kas ta veritseb
             * - ning mitu hetke elupunkti tal alles on
             * 
             * teguviis:
             * 
             * salvestamine - 
             * kui mängija tahab väljuda, peab iga event tuvastama sisestusena sõna "exit", 
             * selle puhul mängu tsükli jooksev tingimus seatakse "false" väärtusele, ning küsitakse kas kasutaja soovib mängu salvestada,
             * kui ei, programm lihtsalt lõppeb
             * kui jah, kutsutakse esile salvestusmeetod:
             * 
             * meetod peaks tegutsema nii:
             * salvesta igaüks eraldi reale. 
             * igal real on kaks väärtust, ise otsustad kuidas neid eraldatakse,
             * esimene väärtus kirjeldab mida real hoitakse,
             * teine on selle hoitava väärtuse tegelik olek.
             * näiteks rida sisaldab "elud 2"
             * salvestusfunktsioon vajab kõiki viite muutujat parameetritena, või pakituna ühte tuplesse,
             * funktsioon sees kirjutab iga parameetri/tuple elemendi kohta uue rea uude, meetodi sees eksisteerivasse listi
             * list kirjutatakse failioperatsiooniga kinlda nimega failiks, näiteks "savegame.txt" vms.
             * 
             * laadimine - 
             * programmi alguses, kontrollib kas salvestatud kindla nimega fail eksisteerib.
             * kui on, küsitakse kasutajalt kas ta soovib mängu jätkata salvestatud infoga või mitte.
             * Kui ei, faili ei loeta, ja algab uus mäng
             * kui jah, kutsutakse esile laadimismeetod:
             * 
             * meetod peaks tegutsema nii:
             * tekitatakse viis muutujat, üks iga mängu parameetri jaoks, muutujad jäetakse tühjaks.
             * eraldab failist loetud info ridadeks
             * võetakse ette esimene rida, jaotatakse osadeks, ning loetakse rea esimene väärtus, ning 
             * olenevalt väärtusest, seatakse vastavasse muutujasse rea teise elemendi väärtus
             * käiakse läbi kõik read nii
             * ja meetod tagastab Tuple.
             * 
             * Meetodist väljaspool omistatakse tuplest vastavad väärtused erinevaisse muutujaisse.
             * ning mäng algab failist loetud andmetega.
             * 
             */




            int moni = 10;
            int elud = 3;
            List<string> seljaKott = new List<string>();

            if (File.Exists("savegame.txt"))
            {
                Console.WriteLine("Save file found, load save?");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    var stat = File.ReadAllLines("savegame.txt");

                    elud = int.Parse(stat[0]);
                    moni = int.Parse(stat[1]);

                    string[] splitItems = stat[2].Split(new char[] { ',' });
                    seljaKott = new List<string>();

                    foreach (string item in splitItems)
                    {
                        seljaKott.Add(item.Trim());
                    }
                }
            }

                string userInput = "";
            Random juhuArv = new Random(); //tee random generaator
            string mängijaMängib = "jah"; // vastus küsimusele kas mängija mängib
            do //tsükkel
            {
                do
                {
                    Console.Clear();
                    int järgmineEvent = juhuArv.Next(1, 7);
                    switch (järgmineEvent)
                    {
                        case 1:
                            Console.WriteLine("Kõnnid külatee peal ja vastu tuleb elukas.");
                            Stats(moni, elud, seljaKott, userInput);
                            Tuple<Random, int, List<string>, int, string> data3 = new Tuple<Random, int, List<string>, int, string>(juhuArv, elud, seljaKott, moni, userInput);
                            data3 = KratiM6istatus(data3);
                            moni = data3.Item4;
                            elud = data3.Item2;
                            seljaKott = data3.Item3;
                            break;
                        case 2:
                            Console.WriteLine("Kõnnid külatee peal ja vastu tuleb nõid.");
                            Stats(moni, elud, seljaKott, userInput);
                            elud = Nõid(juhuArv, elud, moni, seljaKott);
                            break;
                        case 3:
                            Console.WriteLine("Kõnnid metsas ja vastu tuleb seen.");
                            Stats(moni, elud, seljaKott, userInput);
                            elud = Seen(juhuArv, elud, moni, seljaKott);
                            break;
                        case 4:
                            Console.WriteLine("Kõnnid tänaval ja näed maas midagi helkimas:");
                            Stats(moni, elud, seljaKott, userInput);
                            seljaKott = Nuga(seljaKott, moni, elud);
                            break;
                        case 5:
                            Console.WriteLine("Kõnnid mööda teed ja midagi tuleb ette.");
                            Stats(moni, elud, seljaKott, userInput);
                            List<int> data = new List<int> { moni, elud};
                            data = Mätas(data, userInput, seljaKott);
                            moni = data[0];
                            elud = data[1];
                            break;
                        case 6:
                            Console.WriteLine("Kõnnid poetänaval ja ette tuleb vanakraami pood, astud sisse ja näed:");
                            Stats(moni, elud, seljaKott, userInput);
                            var p = Pood(moni, elud, seljaKott);
                            moni = p.Item1;
                            seljaKott = p.Item2;
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("\nVajuta ükskõik mis klahvi et jätkata");
                    string cont = Console.ReadLine();
                    if (cont == "exit")
                    {
                        KasSave(moni, elud, seljaKott);
                    }
                } while (elud > 0);

                if (elud <= 0)
                {
                    Console.WriteLine("--== Kas soovid uuesti mängida, sul on elusi 0 ==--"); //kas kasutaja soovib uuesti mängida
                    mängijaMängib = Console.ReadLine(); //saa vastus
                    if (mängijaMängib == "exit")
                    {
                        KasSave(moni, elud, seljaKott);
                    }
                    if (mängijaMängib == "jah")
                    {
                        elud = 3;
                    }
                }

            } while (mängijaMängib == "jah"); //tsükkel teeb järgmise ringi kui kasutaja vastab jah, kõige muu puhul katkeb
        }

        private static Tuple<int, List<string>> Pood(int rahakott, int elud, List<string> seljaKott)
        {
            List<string> riiul = new List<string>()
            {
                "katkine saabas",
                "mingi lambipirn",
                "DDR5 32GB 2x16 kit",
                "Juustukera",
                "Kotitäis lambasoolikaid"
            };
            List<int> hinnad = new List<int>()
            {
                1000,
                12,
                1600,
                3,
                -6,
            };
            for (int i = 0; i < riiul.Count; i++)
            {
                //kuva kasutajale asi, selle hind
                Console.WriteLine($"Riiulil paistab {riiul[i]} ning see maksab {hinnad[i]}.");
                Console.WriteLine("Kas sa tahad seda osta? (jah/ei) Lahkumiseks kirjuta 'exit'");
                string vastus = Console.ReadLine();
                if (vastus == "exit")
                {
                    KasSave(rahakott, elud, seljaKott);
                }

                if (vastus == "jah")
                {
                    if (hinnad[i] <= rahakott)
                    {
                        seljaKott.Add(riiul[i]);
                        rahakott -= hinnad[i];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sul pole piisavalt raha selle jaoks, vaata midagi muud.");
                    }
                }
                else
                {
                    Console.WriteLine("Vaatad järgmist asja");
                }
            }
            Console.WriteLine("Lahkusid poest");
            return new Tuple<int, List<string>>(rahakott, seljaKott);

        }

        private static void Stats(int moni, int elud, List<string> seljaKott, string userInput)
        {
            Console.WriteLine("Sul on alles " + elud + " elu.");
            Console.WriteLine("Sul on rahakotis " + moni + " raha.");
            Console.WriteLine("Sul on seljakotis " + seljaKott.Count + " asja.");
            string sisu = "";
            foreach (string s in seljaKott)
            {
                sisu += s + ", ";
            }
            Console.WriteLine("Seljakotis on:" + sisu);
            userInput = "";
        }

        private static List<int> Mätas(List<int> datas, string userInput, List<string> seljaKott)
        {
            int moni = datas[0];
            int elud = datas[1];
            Console.WriteLine("Kõnnid mööda teed, ja vastu tuleb huvtava kujuga põlvekõrgune mätas");
            Console.WriteLine("Mätas on keset teed ees, ei saa ei üle ega ümber sest oled laisk, mida teed?");
            Console.WriteLine("1 - ronin üle\n2 - kaevan lahti\n3 - pööran ringi ja lähen tagasi");
            Console.WriteLine("kirjuta vastava valiku number");
            string vastus = Console.ReadLine();
            if (vastus == "exit")
            {
                KasSave(moni, elud, seljaKott);
            }
            switch (vastus)
            {
                case "1":
                    Console.WriteLine("Ronid mättast üle, ja jätkad oma teed");
                    break;
                case "2":
                    moni += 5;
                    Console.WriteLine("Kaevasid mätta lahti, ja leidsid väikese rahapaja, seal oli viis münti.");
                    break;
                default:
                    Console.WriteLine("Hakkasid kannapealt ringi pöörama, kui sellel hetkel kargas mätta\n" +
                        "tagant tuttav kratt, ja peksis sind natuke, kaotasid ühe elu.");
                    elud -= 1;
                    break;
            }

            return new List<int> { moni, elud };
        }

        private static List<string> Nuga(List<string> seljaKott, int moni, int elud)
        {
            Console.WriteLine("Leiad maast noa, ta on verine, kas sa võtad selle üles?:");
            string vastus = Console.ReadLine();
            if (vastus == "exit")
            {
                KasSave(moni, elud, seljaKott);
            }
            if (vastus == "jah")
            {
                Console.WriteLine("Panid noa seljakotti");
                seljaKott.Add("nuga");
            }
            else
            {
                Console.WriteLine("Kõndisid minema, las politsei uurib");
            }
            return seljaKott;
        }

        private static int Seen(Random juhuArv, int elud, int moni, List<string> seljaKott)
        {
            int seeneEffekt = juhuArv.Next(-4, 4);
            Console.WriteLine("Leiad seene, kas tahad seda maitsta?:");
            string vastus = Console.ReadLine();
            if (vastus == "exit")
            {
                KasSave(moni, elud, seljaKott);
            }
            if (vastus == "jah")
            {
                if (seeneEffekt >= 0)
                {
                    Console.WriteLine("Seen maitses hästi, said juurde " + seeneEffekt + " elu.");
                    return elud + seeneEffekt;
                }
                else
                {
                    Console.WriteLine("Kurat, sitaseen oli, tunned ennast väga pahasti ja kaotasid " + (-seeneEffekt) + " elu.");
                    return elud + seeneEffekt;
                }
            }
            else
            {
                Console.WriteLine("Jätad seene maha nagu oma abusivi eksi.");
                return elud;
            }
        }

        private static int Nõid(Random juhuArv, int elud, int moni, List<string> seljaKott)
        {
            Console.WriteLine("NYEH! Oled eksinud minu koju! Mis sul - sissetungijal - öelda on!!!");
            string vastus = Console.ReadLine();
            if (vastus == "exit")
            {
                KasSave(moni, elud, seljaKott);
            }
            if (vastus.ToLower() == "palun vabandust")
            {
                Console.WriteLine("No olgu, eks sa mine siis...");
                return elud;
            }
            else if (vastus.ToLower() == "tahtsin sulle kooki tuua")
            {
                Console.WriteLine("Oi aitäh, anna sulle ühe elu selle koogi vastu");
                return elud + 1;
            }
            else
            {
                Console.WriteLine("MISASJA!?!?!?? KUIDAS SA JULGED?!?! KÄI ISE " + vastus);
                return elud - 1;
            }
        }

        private static Tuple<Random, int, List<string>, int, string> KratiM6istatus(Tuple<Random, int, List<string>, int, string> data)
        {
            Random juhuArv = data.Item1;
            int seeJuhuArv = juhuArv.Next(1, 10); //suvaline täisarv vahemikus 1-10
            int elud = data.Item2;
            List<string> seljaKott = data.Item3;
            int moni = data.Item4;
            string userInput = data.Item5;

            if (!seljaKott.Contains("nuga"))
            {
                Console.WriteLine("Hahaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!"); //flavourtext
                Console.WriteLine("Arva:"); //oota kasutajalt sisestust
                string s = Console.ReadLine();
                if (s == "exit")
                {
                    KasSave(moni, elud, seljaKott);
                }

                int kasutajaArv;
                if (int.TryParse(s, out kasutajaArv))
                {
                    if (seeJuhuArv == kasutajaArv) // kontrolli sisestust tingimuslauses
                    {
                        Console.WriteLine("AIAIAIAAA, Y U DIS TO ME *sureb*"); //kui on õige
                    }
                    else
                    {
                        Console.WriteLine("HJEHJEHJEH - õige vastus oli " + seeJuhuArv + "!!!! sa kaotasid!"); //kui on vale
                        elud -= 1;
                    }
                }
                else
                {
                    // mitte-numbriline vastus loetakse valeks
                    Console.WriteLine("Vale vastus!");
                    elud -= 1;
                }
            }
            else
            {
                Console.WriteLine("Vastu tuleb kuri kratt, aga sul on nuga. Kratt ütleb:");
                Console.WriteLine("\"Hahaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!\"");
                Console.WriteLine("Mida sa teed? Kas vastad (1) või ründad noaga (2)?");
                string vastus = Console.ReadLine();
                if (vastus == "exit")
                {
                    KasSave(moni, elud, seljaKott);
                }

                if (vastus == "1")
                {
                    Console.WriteLine("Arva:"); //oota kasutajalt sisestust
                    string s = Console.ReadLine();
                    if (s == "exit")
                    {
                        KasSave(moni, elud, seljaKott);
                    }

                    int kasutajaArv;
                    if (int.TryParse(s, out kasutajaArv))
                    {
                        if (seeJuhuArv == kasutajaArv) // kontrolli sisestust tingimuslauses
                        {
                            Console.WriteLine("AIAIAIAAA, Y U DIS TO ME *sureb*"); //kui on õige
                        }
                        else
                        {
                            Console.WriteLine("HJEHJEHJEH - õige vastus oli " + seeJuhuArv + "!!!! sa kaotasid!"); //kui on vale
                            elud -= 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vale vastus!");
                        elud -= 1;
                    }
                }
                else
                {
                    Console.WriteLine("Lõikasid krati lõhki, ta maost voolas välja 25 münti!\nAga nuga murdus...");
                    moni += 25;
                    seljaKott.Remove("nuga");
                }
            }
            return new Tuple<Random, int, List<string>, int, string>(juhuArv, elud, seljaKott, moni, userInput);
        }

        private static void KasSave(int moni, int elud, List<string> seljaKott)
        {
            string vastus = "";
            Console.WriteLine("Kas soovid salvestada?");
            vastus = Console.ReadLine();
            if (vastus == "jah")
            {
                if (!File.Exists("savegame.txt"))
                {
                    File.AppendAllText("savegame.txt", moni.ToString() + "\n");
                    File.AppendAllText("savegame.txt", elud.ToString() + "\n");
                    File.AppendAllText("savegame.txt", string.Join(",", seljaKott));
                    Environment.Exit(0);
                }
                else if (File.Exists("savegame.txt"))
                {
                    Console.WriteLine("Twin u wanna overwrite? U have a save file lol");
                    vastus = Console.ReadLine();
                    if (vastus == "jah")
                    {
                        Console.WriteLine("Davai");
                        File.Create("savegame.txt").Close();
                        File.AppendAllText("savegame.txt", moni.ToString()+"\n");
                        File.AppendAllText("savegame.txt", elud.ToString()+"\n");
                        File.AppendAllText("savegame.txt", string.Join(",", seljaKott));
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
