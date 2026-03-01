



namespace _4_Mahukalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kirjuta programm mis
            //küsib kasutajalt kas ta tahab arvutada oma kasti mahtu, või õlivaadi mahtu
            //sisendite küsimiseks on oma meetod, mis ei lase programmil edasi liikuda, kuni vastus ei ole tühi, ega üks võimalikest valikutest.
            //selle tegemiseks annate meetodile parameetrina valikud listis kaasa ja .Contains abil saate kontrollida kas ta on olemas või mitte
            //kui programm teab kumba ta arvutab toimuvad järgmised tegevused
            //  kasti puhul, küsitakse kas kast on kuubik või risttahukas.
            //    - kuubiku puhul küsitakse küljepikkus, antakse parameetrina meetodile KuubiRuumala() kaasa,
            //      ning kuubiruumala tagastab double tüüpi andmena muutujasse tehte tulemuse. valem otsi internetist.
            //    - risttahuka puhul lühima ja pikima külje pikkust ning kõrgust. samamoodi arvutab parameetrite abil 
            //      meetod RisttahukaRuumala() tulemuse double andmena ja tagastab selle muutujasse.
            //  Tünni puhul, küsitakse kas ta tünn on kaanega või kaaneta.
            //    - Kui tal on kaas olemas, siis küsi selle paksust, kui ei ole, määra paksuseks ise 0
            //      Küsi kasutajalt ka tünni põhja läbimõõtu ja kõrgust ning arvuta SilindriRuumala()
            //      meetodiga kus parameetrid ka kaasas double tulemus mille tagastad muutujasse
            //      NB! kaane paksuse arvutad kõrgusest maha, sest kaas võtab õlitünni sees mingi ruumala enda poolt ära.
            //Kuva kasutajale tema ruumala tulemus peaprogrammis, mitte arvutatavates meetodites.

            int i = 0;
            string[] mahuValik = new string[] { "kast", "õlivaat" };
            Console.WriteLine("Kumba soovite arvutada? Valimiseks sisesta number.");
            for (i = 0; i < mahuValik.Length; i++)
            {
                Console.WriteLine((i + 1)+". " + mahuValik.ElementAt(i));
            }
            int kasutajaValik = GetIntInput(new List<int> {1,2});
            if (kasutajaValik == 1)
            {
                Console.WriteLine("Kumba soovite arvutada? Valimiseks sisesta number.");
                string[] kastiValik = new string[] { "kast", "risttahukas" };
                for (i = 0; i < kastiValik.Length; i++)
                {
                    Console.WriteLine((i+1)+". "+kastiValik.ElementAt(i));
                }
                kasutajaValik = GetIntInput(new List<int> { 1, 2 });
                if (kasutajaValik == 1)
                {
                    Console.WriteLine("Palun sisesta oma kasti ühe külje pikkus:");
                    int kastiKülg = GetInPut();
                    int kastiMaht = KastiArvutus(kasutajaValik, kastiKülg);
                    Console.WriteLine($"Teie kuubiku maht on {kastiMaht}cm³.");
                }
                if (kasutajaValik == 2)
                {
                    Console.WriteLine("Palun sisesta lühem külg:");
                    int lühemKülg = GetInPut();
                    Console.WriteLine("Palun sisesta pikem külg:");
                    int pikemKülg = GetInPut();
                    int ristTahukaMaht = KastiArvutus(kasutajaValik, lühemKülg, pikemKülg);
                    Console.WriteLine($"Teie kuubiku maht on {ristTahukaMaht}cm³.");
                }
            }
            else if (kasutajaValik == 2)
            {
                int vaadiPõhi = 0;
                int vaadiKõrgus = 0;
                int kaanePaksus = 0;
                Console.WriteLine("Kaanega või kaaneta? Valimiseks sisesta number.");
                string[] kaaneValik = new string[] { "Kaaneta", "Kaanega" };
                for (i = 0; i < kaaneValik.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + kaaneValik.ElementAt(i));
                }
                kasutajaValik = GetIntInput(new List<int> { 1, 2 });
                if (kasutajaValik == 1)
                {
                    Console.WriteLine("Sisesta oma tünni põhja läbimõõt: ");
                    vaadiPõhi = GetInPut() / 2;
                    Console.WriteLine("Sisesta oma tünni kõrgus: ");
                    vaadiKõrgus = GetInPut();
                    int kaanegaVaat = SilindriRuumala(vaadiPõhi, vaadiKõrgus);
                    Console.WriteLine($"{kaanegaVaat}");
                }
                if (kasutajaValik == 2)
                {
                    Console.WriteLine("Sisesta oma tünni põhja läbimõõt: ");
                    vaadiPõhi = GetInPut() / 2;
                    Console.WriteLine("Sisesta oma tünni kõrgus: ");
                    vaadiKõrgus = GetInPut();
                    Console.WriteLine("Sisesta oma tünni kaane paksus: ");
                    kaanePaksus = GetInPut();
                    vaadiKõrgus = vaadiKõrgus - kaanePaksus;
                    int kaanetaVaat = SilindriRuumala(vaadiPõhi, vaadiKõrgus);
                    Console.WriteLine($"{kaanetaVaat}");
                }
            }
        }

        private static int SilindriRuumala(int põhi, int kõrgus)
        {
            double vastus = 0.0d;
            double põhi2 = põhi;
            vastus = Math.PI * Math.Pow(põhi2, 2) * kõrgus;
            return (int)vastus;
        }

        private static int KastiArvutus(int valik, int üksKülg, int? teineKülg = 0)
        {
            if (valik == 1)
            {
            int kastiMaht = 0;
                kastiMaht = üksKülg * üksKülg * üksKülg;
                return kastiMaht;
            }
            else
            {
            int risttahukaMaht = 0;
                risttahukaMaht = (int)(üksKülg * üksKülg * teineKülg);
                return risttahukaMaht;
            }
        }

        private static int GetInPut()
        {
            int value = 0;
            do
            {
                value = int.Parse(Console.ReadLine());
            } while (value < 1);
            return value;
        }

        private static int GetIntInput(List<int>input)
        {
            int vastus = 0;
            do
            {
                vastus = int.Parse(Console.ReadLine());
            } while (!input.Contains(vastus));
            return vastus;
        }
    }
}
