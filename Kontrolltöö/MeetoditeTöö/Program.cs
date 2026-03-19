



namespace MeetoditeTöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1 - Tervitus */
            Tervitus();

            /* 2 - Arvutus */
            int[] arvud = { 1, 2, 3, 4, 5 };
            int tulemus = Calculate(arvud);
            Console.WriteLine(tulemus);

            /* 3 - Töötlus */
            Console.WriteLine("Sisesta oma moto:");
            string minuMoto = Console.ReadLine();
            int moto = GetMoto(minuMoto);
            Console.WriteLine("Sinu moto sisaldab "+moto+" sõna.");

            /* 4 - Tuvastus */
            Console.WriteLine("Kui palju sa jõusaalis jalapressil tõukasid?\nSisesta:");
            int tõukeRaskus = int.Parse(Console.ReadLine());
            string meetodiTulemus = Vahemik(tõukeRaskus);
            Console.WriteLine(meetodiTulemus);
        }

        private static string Vahemik(int tõukeRaskus)
        {
            if (tõukeRaskus < 0)
            {
                return "Kuidas sa seda tegid? oled elus?";
            }
            else if (tõukeRaskus >= 0 && tõukeRaskus <= 20)
            {
                return "natuke vähe, kuid algaja kohta ok";
            }
            else if (tõukeRaskus > 20 && tõukeRaskus <= 50)
            {
                return "hakkab looma, muskel tuleb...";
            }
            else if (tõukeRaskus > 50 && tõukeRaskus <= 90)
            {
                return "voh, see on juba miskit";
            }
            else if (tõukeRaskus > 90 && tõukeRaskus <= 120)
            {
                return "Vat kus metslane!!!";
            }
            else
            {
                return "E B A R E A A L N E !!!!";
            }
        }

        private static int GetMoto(string minuMoto)
        {
            string[] minuMotoOsad = minuMoto.Split(' ');
            int osi = minuMotoOsad.Length;
            return osi;
        }

        private static int Calculate(int[] arvud)
        {
            int tulemus = 0;
            foreach (int i in arvud)
            {
                tulemus += i;
            }
            return tulemus;
        }

        private static void Tervitus()
        {
            Console.WriteLine("Halloooo");
        }

    }
}
