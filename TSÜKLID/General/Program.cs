using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.Serialization;

namespace General
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #n1. "Tervitus"
            // kirjuta programm mis,
            // - küsib tsükliga kasutajalt tema eesnime
            // - - küsitakse uuesti tühja sisendi korral
            // - küsib kasutajalt tema keskmist nime
            // - - küsitakse uuesti tühja sisendi korral
            // - küsib kasutajalt tema perekonnanime
            // - - küsitakse uuesti tühja sisendi korral
            // - tema vanust
            // - - küsitakse uuesti tühja sisendi korral
            // - ning väljastab talle tervituslause, kasutades kõiki muutujaid

            //string eesNimi = string.Empty;
            //while (eesNimi == string.Empty)
            //{
            //    Console.WriteLine("Palun sisesta oma nimi siia");
            //    eesNimi = Console.ReadLine();
            //}
            //string keskmineNimi = string.Empty;
            //while (keskmineNimi == string.Empty)
            //{
            //    Console.WriteLine("Palun sisesta oma kesmine nimi siia");
            //    keskmineNimi = Console.ReadLine();
            //}
            //string perekonnaNimi = string.Empty;
            //while (perekonnaNimi == string.Empty)
            //{
            //    Console.WriteLine("Palun sisesta oma perekonnanimi siia");
            //    perekonnaNimi= Console.ReadLine();
            //}
            //int vanus = 0;
            //while (vanus < 1)
            //{
            //    Console.WriteLine("Palun sisesta oma vanus");
            //    vanus = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"Tere {eesNimi} {perekonnaNimi}! Või kutsun teid kui {keskmineNimi}? Oled tublisti kasvanud, oled {vanus} aastane.");

            // #n2. "Minu lemmiksnäkk"
            // kirjuta programm mis
            // küsib kasutajalt mis on ta lemmiksnäkk
            // programm kontrollib tsükliga kas järjendis on snäkk olemas
            // kui tsüklis leitakse snäkk, kuva tekst koos kasutajasisendiga, "jaa :D tean seda, {snäkk} on hea"
            // kui tsükkel lõppeb ilma snäkki leidmata, kuva tekst "ei tunne kahjuks {snäkk}i :C"

            //List<string> snäkid = new List<string>() {"krõpsud", "kummikommid", "präänikud" };
            //string kasutajaleMeeldib = string.Empty;
            //bool isPresent = false;
            //while (isPresent != true)
            //{
            //    Console.WriteLine("Sisesta oma lemmiksnäkk");
            //    kasutajaleMeeldib = Console.ReadLine();
            //    foreach (var snäkk in snäkid)
            //    {
            //        if (snäkk == kasutajaleMeeldib)
            //        {
            //            isPresent = true;
            //        }
            //    }
            //    if (isPresent == true)
            //    {
            //        Console.WriteLine($"jaa :D tean seda, {kasutajaleMeeldib} on hea");
            //    }
            //    else { Console.WriteLine($"ei tunne kahjuks {kasutajaleMeeldib} :c"); }
            //}

            // #n3. "Metsataimede välimääraja"
            // kirjuta programm mis
            // küsib kasutajalt kas ta otsib mingit seent või marja (tsüklis)
            // kui seent, siis programm esitab seeneloendis olevad seened
            // ja küsib millise seene kohta infot infojärjendist kuvada
            // tsükkel siis käib ja otsib teisest järjendis seene infot ja kuvab selle
            // kui marja, siis programm esitab marjaloendis olevad marja
            // ja küsib millise marja kohta infot infojärjendist kuvada
            // tsükkel siis käib ja otsib teisest järjendis marja infot ja kuvab selle
            // siis küsitakse kas kasutaja tahab mõne marja kohta veel infot, ning tsükkel jätkub
            // ⭐iseseisvalt lisa juurde puude tuvastamine ⭐

            //bool anuddaJuan = true;
            //string mida = string.Empty;
            //List<string> valikud = new List<string>() { "seent", "marja","puud"};
            //List<string> seeneNimed = new List<string> { "kukeseen", "puravik", "sitaseen" };
            //List<string> seeneInfod = new List<string>
            //{
            //    "kukeseen on kollane ja maitsev",
            //    "puravik on pruun ja maitse poolest halvem kui kukeseen",
            //    "sitaseen ei ole hea, ära korja"
            //};
            //List<string> marjaNimed = new List<string> { "maasikas", "vaarikas", "mustikas" };
            //List<string> marjaInfod = new List<string>
            //{
            //    "Maasikas on magus ja punane",
            //    "Vaarikas on magushapu ja maitse, kuid tal on seemned",
            //    "Mustikas on sinine ja magus ning pehme"
            //};
            //List<string> puudeNimed = new List<string> { "kask", "kuusk", "tamm" };
            //List<string> puudeInfod = new List<string>
            //{
            //    "kask on valge ja huvitav",
            //    "kuusk on jõuludeks väga tore puu :)",
            //    "tamm on suur ja tume"
            //};
            //while (anuddaJuan == true)
            //{
            //    do
            //    {
            //        Console.WriteLine("Kas sa otsid seent, marja või puud? Valimiseks palun sisestage 'seent', 'marja' või 'puud'.");
            //        mida = Console.ReadLine();
            //    }
            //    //while (mida != "seent")
            //    //while (!new List<string>() { "seent", "marja", "seeni", "marju"}.Contains(mida));
            //    while (!valikud.Contains(mida));
            //    {
            //        if (mida == "seent")
            //        {
            //            List<int> seeneValikud = new List<int>() { 1, 2, 3 };
            //            int seeneArv = 0;
            //            do
            //            {
            //                Console.WriteLine("Palun vali seen, mille kohta tahad infot, valikus on " + seeneNimed.Count + " tükki. Valimiseks sisestage vastav number.");
            //                for (int i = 0; i < seeneInfod.Count; i++)
            //                {
            //                    Console.WriteLine(i + 1 + ". " + seeneNimed.ElementAt(i));
            //                }
            //                seeneArv = int.Parse(Console.ReadLine());
            //            } while (!seeneValikud.Contains(seeneArv));

            //            Console.WriteLine(seeneInfod.ElementAt(seeneArv - 1));
            //        }
            //        else if (mida == "marja")
            //        {
            //            List<int> marjaValikud = new List<int>() { 1, 2, 3 };
            //            int marjaArv = 0;
            //            do
            //            {
            //                Console.WriteLine("Palun vali seen, mille kohta tahad infot, valikus on " + marjaNimed.Count + " tükki. Valimiseks sisestage vastav number.");
            //                for (int i = 0; i < marjaInfod.Count; i++)
            //                {
            //                    Console.WriteLine(i + 1 + ". " + marjaNimed.ElementAt(i));
            //                }
            //                marjaArv = int.Parse(Console.ReadLine());
            //            } while (!marjaValikud.Contains(marjaArv));

            //            Console.WriteLine(marjaInfod.ElementAt(marjaArv - 1));
            //        }
            //        else
            //        {
            //            List<int> puudeValikud = new List<int>() { 1, 2, 3 };
            //            int puudeArv = 0;
            //            do
            //            {
            //                Console.WriteLine("Palun vali seen, mille kohta tahad infot, valikus on " + puudeNimed.Count + " tükki. Valimiseks sisestage vastav number.");
            //                for (int i = 0; i < puudeInfod.Count; i++)
            //                {
            //                    Console.WriteLine(i + 1 + ". " + puudeNimed.ElementAt(i));
            //                }
            //                puudeArv = int.Parse(Console.ReadLine());
            //            } while (!puudeValikud.Contains(puudeArv));

            //            Console.WriteLine(puudeInfod.ElementAt(puudeArv - 1));
            //        }
            //    }
            //    Console.WriteLine("Kas soovite veel mingit infot? jah/ei");
            //    string kasutajaVastus = Console.ReadLine();
            //    if (kasutajaVastus == "jah")
            //    {
            //        anuddaJuan = true;
            //    }
            //    else
            //    {  anuddaJuan = false; }
            //}

            // #n4. "Stonksid"
            // kirjuta programm mis töötab tsüklis ja omab tehtavat koodi mis:
            // küsib kasutajalt temapoolse investeeritava summa
            // küsib kolme firma kohta millesse ta investeerida soovib (Tesla, TransferWise või Macro$lop)
            // valitud firma kohta otsustab programm kordaja.
            // kui selleks on Tesla, siis on kordaja fikseeritud -1.15
            // kui selleks on TransferWise, siis on kordajaks valemi tuleumus kus juhuarvu abil otsustatakse arv vahemikus 1 ja 100, juhuarv jagatakse 1000ga ja sinna liidetakse 1 juurde
            // kui selleks on Macro$lop, siis kasutatakse sama valemit TransferWise puhul, aga arv ise on alati negatiivne.
            // programm küsib ka kasutajalt kui pikaks ajaks (mitu päeva) investeering turul olla lasta
            // tsükkel kirjutab välja iga päeva kohta firmanime, hetkekordaja, kasutajaportfelliväärtuse
            // kui kasutaja portfell pole jõudnud alla nulli, siis kasutaja saab valida kas investeerida uuesti või mitte
            // kui aga portfell on nullis, öeldakse kasutajale et on pankrotis
            // kuvatakse kasutajale tema portfelli lõppväärtus.

            //bool investeeringUuesti = true;
            //float portfell = 1;
            //float summa = 0;
            //List<string> firmad = new List<string> { "Tesla", "TransferWise", "Microslop" };
            //Random juhuArv = new Random();
            //string investment = string.Empty;
            //while (investeeringUuesti != false && portfell > 0)
            //{
            //    int firmaNumber = 0;
            //    int päevad = 0;
            //    Console.WriteLine("Palun sisestage oma investeeritav summa.");
            //    summa = int.Parse(Console.ReadLine());
            //    portfell = summa;
            //    Console.WriteLine("Kuhu soovite investeerida?");
            //    for (int i = 0; i < firmad.Count; i++)
            //    {
            //        Console.WriteLine(i + 1 + ". " + firmad.ElementAt(i));
            //    }
            //    firmaNumber = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Kui pikaks ajaks soovite investeerida?");
            //    päevad = int.Parse(Console.ReadLine());
            //    if (firmad.Contains(firmad.ElementAt(firmaNumber-1)))
            //        while (päevad > 0)
            //        if (investment == "Tesla")
            //            {
            //                float Tesla = -1.15f;

            //                portfell = portfell - (portfell * Tesla);
            //                Console.WriteLine($"Tänane  kordaja on {firmad[0]} ja teie hetke portfelli seis on {portfell}");
            //                päevad--;
            //            }
            //        else if (investment == "TransferWise")
            //            {
            //                int TransferWise = (juhuArv.Next(1, 100) / 1000) + 1;
            //                portfell = portfell / TransferWise;
            //                Console.WriteLine($"Tänane {firmad[1]} kordaja on {TransferWise} ja teie hetke portfelli seis on {portfell}");
            //                päevad--;
            //            }
            //        else
            //            {
            //                int MicroSlop = (juhuArv.Next(-100, -1) / 1000) + 1;
            //                portfell = portfell / MicroSlop;
            //                Console.WriteLine($"Tänane {firmad[2]} kordaja on {MicroSlop} ja teie hetke portfelli seis on {portfell}");
            //                päevad--;
            //            }
            //    if (portfell > 0)
            //    {
            //        Console.WriteLine($"Teie hetke portfelli summa on {portfell}");
            //        Console.WriteLine("Kas soovite uuesti investeerida?");
            //        string vastus = "";
            //        vastus = Console.ReadLine();
            //        if (vastus == "jah")
            //        { investeeringUuesti = true; }
            //        else
            //        { investeeringUuesti = false; }
            //}
            //}

            float investment = 1.0f;
            Random generator = new Random();
            float teslaRate = -1.15f;
            float msRate = 0f;
            float wiseRate = 0f;
            bool reinvest = true;
            string kasutajaVastus = "jah";
            while (reinvest != false && investment > 0)
            {
                do
                {
                    Console.WriteLine("Palun sisesta summa mida soovid investeerida.");
                    investment = float.Parse(Console.ReadLine());
                } while (investment <= 0f);
                List<string> companies = new List<string>() { "Tesla", "Transferwise", "Microslop"};
                string userOption = "";
                do
                {
                    Console.WriteLine( "Palun sisesta ka firma mille aktsasse soovid investeerida, kirjuta firma nimi.");
                    foreach (var company in companies)
                    {
                        Console.WriteLine(" - "+company);
                    }
                    userOption = Console.ReadLine();

                } while (companies.Contains(userOption));
                int investmentDays = 0;
                do
                {
                    Console.WriteLine("Palun sisesta mitu päeva soovid oma investeeringut portfellis hoida");
                    investmentDays = int.Parse(Console.ReadLine());
                } while (investmentDays < 0);
                int i = 0;
                float cycleRate = 0f;
                
                while (i < investmentDays)
                {
                    int fixture = generator.Next(1,100);
                    float result = fixture / 1000 + 1;
                    wiseRate = result;
                    msRate = result - result * 2;
                switch (userOption)
                {
                    case "tesla":
                        cycleRate = teslaRate;
                        break;
                    case "microslop":
                        cycleRate = msRate;
                        break;
                    case "transferwise":
                        cycleRate = wiseRate;
                        break;
                }
                    investment *= cycleRate;
                    Console.WriteLine((i+1)+". päeva tulemus: Firma - "+ userOption+" aktsia muutus kordajaga: "+cycleRate+"\n Sinu portfellist on alles "+investment+" eurot.");
                    i++;
                }
                if (investment > 0)
                {
                    Console.WriteLine("Kas tahad uuesti investeerida? Sinu portfell on hetkel väärt: " + investment);
                    kasutajaVastus = Console.ReadLine();
                    if (kasutajaVastus == "jah")
                    {
                        reinvest = true;
                    }
                    else
                    {
                        reinvest = false;
                    }
                }
                else
                {
                    Console.WriteLine("Oled BROKE");
                }
            }
        }
    }
}
