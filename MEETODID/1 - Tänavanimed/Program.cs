

namespace _1___Tänavanimed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kasutades meetodeid ja sõnetöötlemisvahendeid sisendi kontrolli jaoks, kirjuta programm mis:
            /*
             * küsib kasutajalt tema kodukandi tänavanimesid
             * küsib kasutajalt milline tähestiku täht talle ei meeldi
             * programm otsib järjendist üles kõik tänavanimed milles ebameeldiv täht esineb
             * eemaldab need järjendist
             * ja kuvab järjendi välja
             * programm loendab ka kokku eemaldatud nimede arvu, ning tagastab sõnumi koos loendiga mitu sõna eemaldati.
             */
            //Debug code
            //Console.WriteLine("Sisesta tänavanimi");
            //string tänavanimi = SisendiVõttJaKontroll();
            //Console.WriteLine(tänavanimi);
            List<string> tänavaNimed = new List<string>();
            Console.WriteLine("Kirjuta siia oma kodukandi tänavanimed, kui rohkem ei ole, kirjuta ei-ole");
            string sisestus = "";
            do
            {
                Console.WriteLine("Sisesta tänavanimi");
                sisestus = SisendiVõttJaKontroll();
                if (sisestus != "Ei-ole")
                {
                    tänavaNimed.Add(sisestus);
                }
            } while (sisestus != "Ei-ole");

            //foreach (var nimi in tänavaNimed)
            //{
            //    Console.WriteLine(nimi);
            //}
            Console.WriteLine("Kirjuta täht mis sulle ei meeldi");
            string ebameeldivTäht = SisendiVõttJaKontroll(" ");
            List<string> uusJärjend = JärjendiFiltreerimine(tänavaNimed, ebameeldivTäht);
            KuvaAndmed(uusJärjend);
            
        }

        private static void KuvaAndmed(List<string> kuvatavadAndmed)
        {
            if (kuvatavadAndmed.Count > 0)
            {
                for (int i = 0; i < kuvatavadAndmed.Count; i++)
                {
                    Console.WriteLine((i+1)+". " + kuvatavadAndmed[i]);
                }
                return;
            }
            Console.WriteLine("Järjend on tühi");
            return;
        }

        private static List<string> JärjendiFiltreerimine(List<string> filtreeritavadAndmed, string filter)
        {
            int loendur = 0;
            List<string> töödeldudAndmed = new List<string>();
            foreach (var anne in filtreeritavadAndmed)
            {
                if (!anne.ToLower().Contains(filter.Substring(0,1).ToLower()))
                {
                    töödeldudAndmed.Add(anne);
                }
                else
                {
                    loendur++;
                }
            }
            Console.WriteLine($"Eemaldati {loendur} elementi");
            return töödeldudAndmed;
        }

        public static string SisendiVõttJaKontroll()
        {
            string sisestus = "";
            string töödeldudsisestus = "";
            do
            {
                Console.WriteLine("Kirjuta siia: ");
                sisestus = Console.ReadLine();
                if (sisestus.Length > 1)
                {
                    töödeldudsisestus = (sisestus.Substring(0,1).ToUpper() + sisestus.Substring(1).ToLower());
                }
                else
                {
                    Console.WriteLine("Tänavanimi ei saa olla lühem kui kaks tähte");
                }
            } while (string.IsNullOrEmpty(sisestus));
            return töödeldudsisestus;
        }
        public static string SisendiVõttJaKontroll(string addition)
        {
            string sisestus = "";
            string töödeldudsisestus = "";
            do
            {
                Console.WriteLine("Kirjuta siia: ");
                sisestus = Console.ReadLine() + addition;
                if (sisestus.Length > 1)
                {
                    töödeldudsisestus = (sisestus.Substring(0,1).ToUpper() + sisestus.Substring(1).ToLower());
                }
                else
                {
                    Console.WriteLine("Tänavanimi ei saa olla lühem kui kaks tähte");
                }
            } while (string.IsNullOrEmpty(sisestus));
            return töödeldudsisestus;
        }
    }
}
