


namespace _5___MethodBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pangaautomaat
            List<int> koodid = new List<int>() { 4321, 1166, 5577, 4206, 5225 };
            List<double> kontod = new List<double>() { 0, -25.6d, 4000d, 6540002, 5225.5d };
            Console.WriteLine("Tere tulemast Hansapanka, palun sisesta oma pin-kood: ");
            int pinKood = KoodiSisestus(koodid);
            TervitaKasutajat(pinKood);
            EsitaKontoJääk(pinKood, koodid, kontod);
            Console.WriteLine("Millist tegevust teha soovid?");
            string[] valikud = new string[] { "Võta raha välja","Sisesta raha" };
            for (int i = 0; i < valikud.Length; i++)
            {
                Console.WriteLine((i+1)+". "+valikud[i]);
            }
            int kasutajaValik = GetInput(new List<int>{1,2});
            if (kasutajaValik == 1)
            {
                Console.WriteLine("Kui palju soovite välja võtta?");
                double väljaSumma = double.Parse(Console.ReadLine());
                while (väljaSumma < 0)
                {
                    Console.WriteLine("Negatiivset arvu välja võtta ei saa, proovi uuesti: ");
                    väljaSumma = double.Parse(Console.ReadLine()) ;
                }
                VäljaVõte(pinKood, koodid, kontod, väljaSumma);
            }
            else if (kasutajaValik == 2)
            {
                Console.WriteLine("Palju soovite sisestada?");
                double sisestus = double.Parse(Console.ReadLine());
                while (sisestus < 0)
                {
                    Console.WriteLine("Ei saa negatiivset arvu sisestada, proovi uuest: ");
                    sisestus = double.Parse(Console.ReadLine());
                }
                RahaSisestus(pinKood, koodid, kontod, sisestus);
            }
                EsitaKontoJääk(pinKood, koodid, kontod);
        }

        private static List<double> RahaSisestus(int filter, List<int> accounts, List<double> balances, double sisestus)
        {
            int elementLocation = accounts.IndexOf(filter);
            balances[elementLocation] += sisestus;
            return balances;
        }

        private static List<double> VäljaVõte(int filter, List<int> accounts, List<double> balances, double väljaSumma)
        {
            int elementLocation = accounts.IndexOf(filter);
            balances[elementLocation] -= väljaSumma;
            return balances;
        }

        private static int GetInput(List<int>valikud)
        {
            int valik;
            do
            {
                Console.WriteLine("Sisesta kood:");
                valik = int.Parse(Console.ReadLine());
            } while (!valikud.Contains(valik));
            return valik;
        }

        public static void EsitaKontoJääk(int filter, List<int>accounts, List<double>balances)
        {
            int elementLocation = accounts.IndexOf(filter);
            Console.WriteLine($"Teie kontojääk on: {balances.ElementAt(elementLocation)} jublakat.");
        }

        private static void TervitaKasutajat(int userPin)
        {
            Console.WriteLine("Tere "+userPin+", oled sisenenud Hansapanga automaati.");
        }

        private static int KoodiSisestus(List<int> andmebaasiInfo)
        {
            int pinKood = 0;
            do
            {
                Console.WriteLine("Sisesta kood:");
                pinKood = int.Parse(Console.ReadLine());
            } while (!andmebaasiInfo.Contains(pinKood));
            return pinKood;
        }
    }
}
