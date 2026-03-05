
namespace _6___MethodBasic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////On meetod mid kuvab kasutajale ühe sõnumi.
            //KuvaSõnum();
            ////on meetod, mis tahab teada kui palav õues on : temperatuur
            //KuiPalavOn(14);
            ////on meetod mis arvutab järjendi kõikide elementide keskmise, hoiab muutujas meeles ja kuvab eraldi real välja peaprogrammis, mitte meetodis, meetod ainult tagastab väärtuse
            //double scores = ArvutaKeskmine(new List<double> { 3, 5, 6, 7, 5.5});
            //Console.WriteLine(scores);

            //Õnneennustaja
            //Vaja on:
            // - kasutajanime
            // - sünniaastat
            // - lemmik vääriskivi
            // - lemmiklooma liik
            Console.WriteLine("Tere õhtust, eksind rändaja, kas sa soovid oma tulevikkua vaadata?\n Kui jah, siis kirjuta oma nimi");
            string eksinuNimi = Console.ReadLine();
            Console.WriteLine("Mis aastal oled siia ilma eksinud?");
            string eksinuAasta = Console.ReadLine();
            Console.WriteLine("Mis on su lemmik vääriskivi?");
            string eksinuKivi = Console.ReadLine();
            Console.WriteLine("Mis on su lemmik loomaliik?");
            string eksinuLoom = Console.ReadLine();

            int nimeTähed = eksinuNimi.Length;
            int viimaneAastaArv = int.Parse(eksinuAasta.Substring(eksinuAasta.Length-1,1));
            RahaÕnn(nimeTähed,viimaneAastaArv);
            string iseloom = LapseÕnn(eksinuLoom);
            if (iseloom == "ei-tea")
            {
                Console.WriteLine("OI ÕUDUST, SELLIST ELAJAT EI TOHI VALLA LASTA!!!! \n congrats oled incel");
            }
            else
            {
                Console.WriteLine("Kallis "+eksinuNimi+", sinu laps, ma näen, saab olema "+iseloom+".");
            }
            KaitseÕnn(eksinuKivi);
        }
        /// <summary>
        /// Kuvab kasutajale olenevalt tema lemmikkivist tema õnne
        /// </summary>
        /// <param name="kivi">Kasutaja poolt kirjutatud vääriskivi</param>
        public static void KaitseÕnn(string kivi)
        {
            List<string> vargus = new List<string>() { "ahhaat", "graniit", "topaas" };
            List<string> vigastus = new List<string>() { "smaragd", "rubiin", "jaspis" };
            List<string> hullumus = new List<string>() { "tiigrisilm", "kvarts", "amazoniit" };
            if (vargus.Contains(kivi))
            {
                Console.WriteLine("Sinu kivi - "+kivi+" - kaitseb sind hästi varguste eest");
            }
            else if (vigastus.Contains(kivi))
            {
                Console.WriteLine("Sinu kivi - " + kivi + " - kaitseb sind hästi vigastuste eest");
            }
            else if (hullumus.Contains(kivi))
            {
                Console.WriteLine("Sinu kivi - " + kivi + " - kaitseb sind hästi mentaalselt tasakaalus");
            }
            else
            {
                Console.WriteLine("Puhast praht, viska minema.");
            }
        }
        /// <summary>
        /// Olenevalt kasutaja poolt sisestatud lemmiku loomaliigipõhjal ennustab milline tema järgmine laps oma iseloomult on
        /// </summary>
        /// <param name="loom">Kasutaja poolt sisestatud loomaliigi nimetus</param>
        /// <returns>Tagastab tulemuse</returns>
        public static string LapseÕnn(string loom)
        {
            if (loom == "jänes")
            {
                return "krapsakas";
            }
            else if (loom == "karu")
            {
                return "ablas";
            }
            else if (loom == "öökull")
            {
                return "teadlik";
            }
            else if (loom == "rebane")
            {
                return "kaval";
            }
            else if (loom == "kaelkirjak")
            {
                return "uudishimulik";
            }
            else if (loom == "sääsk")
            {
                return "tüütu ja pinisev";
            }
            else
            {
                return "ei-tea";
            }
            return null;
        }
        /// <summary>
        /// Olenevalt nimepikkuse ja aastaarvu keskmisest ennustab isiku varalist õnne
        /// </summary>
        /// <param name="nimeTäheArv">Kasutaja poolt sisestatud nime pikkus</param>
        /// <param name="aastaArv">Kasutaja poolt sisestatud sünniaasta viimane arv</param>
        private static void RahaÕnn(int nimeTäheArv, int aastaArv)
        {
            int õnneKeskmine = (nimeTäheArv + aastaArv) / 2;
            // väiksem kui 0 suurem kui 10
            if (õnneKeskmine < 0 || õnneKeskmine > 10)
            {
                Console.WriteLine("Ooioioioi sinu õnn on põhimõtteliselt olematu, tunnen su rahakotipõuale kaasa.");
            }
            else
            {
                switch (õnneKeskmine)
                {
                    case 1:
                        Console.WriteLine("Väga halb õnn");
                        break;
                    case 2:
                        Console.WriteLine("Halb õnn");
                        break;
                    case 3:
                        Console.WriteLine("Natuke halb õnn");
                        break;
                    case 4:
                        Console.WriteLine("Keskmine halb õnn");
                        break;
                    case 5:
                        Console.WriteLine("Keskmine õnn");
                        break;
                    case 6:
                        Console.WriteLine("Keskmine hea õnn");
                        break;
                    case 7:
                        Console.WriteLine("Natuke halvem hea õnn");
                        break;
                    case 8:
                        Console.WriteLine("Hea õnn");
                        break;
                    case 9:
                        Console.WriteLine("Väga hea õnn");
                        break;
                    default:
                        Console.WriteLine("Parim õnn");
                        break;

                }
            }
        }
        /// <summary>
        /// Arvutab meetodisse parameetrina kaasa antud nimekirajs olevate arvude keskmise
        /// </summary>
        /// <param name="andmed">Meetodi töö jaoks vajaminev sisend</param>
        /// <returns>komakohaga arvu andmete keskmise arvutusega</returns>
        public static double ArvutaKeskmine(List<double> andmed)
        {
            double keskmine = 0;
            for (int i = 0; i < andmed.Count; i++)
            {
                keskmine += andmed[i];
            }
            keskmine /= andmed.Count;
            KuiPalavOn(keskmine);
            return keskmine;
        }
        /// <summary>
        /// Kuvab mingi sõnumi
        /// </summary>
        public static void KuvaSõnum()
        {
            Console.WriteLine("NJÄM NJÄM NJÄM");
        }
        /// <summary>
        /// Annab kasutajale teada kui palav on õues
        /// </summary>
        /// <param name="temp">Muutuja mis kasutatakse temperatuuridel</param>
        public static void KuiPalavOn(double temp)
        {
            if (temp <= 0 && temp >= -50)
            {
                Console.WriteLine("Külm blyat");
            }
            else if (temp > 0 && temp <= 15)
            {
                Console.WriteLine("Jahe");
            }
            else if (temp > 15 && temp <= 25)
            {
                Console.WriteLine("Päris see");
            }
            else if (temp > 25 && temp <= 40)
            {
                Console.WriteLine("Palav blyat");
            }
            else
            {
                Console.WriteLine("Heat death");
            }
        }
    }
}
