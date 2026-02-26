
namespace _2___Sulgudega_kalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kirjuta koos sisendikontrolliga ja sisendi normaliseerimisega, programm
            //küsib kasutajalt kolme tehet, esimene ja kolmas peaksid olema sulgude vahel
            //kasutaja saab määrata igale tehtele märgi
            //programm kuvab vastuse vastavalt tehte järjekorrale
            //
            Console.WriteLine("Sulgudega kalkulaator");
            string[] tehterida = new string[7];
            Console.WriteLine("(1 2 3) 4 (5 6 7)");

            for (int i = 0; i < tehterida.Length; i++)
            {
                //string displayLine = "( ";
                //foreach (var input in tehterida)
                //{
                //    if (input.Contains("0123456789"))
                //    {

                //    }
                //}
                string sisestus = "";
                do
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"Palun sisesta {i + 1} arv: ");
                    }
                    else
                    {
                        Console.WriteLine($"Palun sisesta {i + 1} tehe: ");
                    }
                    tehterida[i] = sisestus;

                } while (sisestus != "");

                double tehe = ÜksTehe(
                [
                ÜksTehe([tehterida[0], tehterida[1], tehterida[2]]
                ).ToString(),

                tehterida[3],

                ÜksTehe([tehterida[4], tehterida[5], tehterida[6]]).ToString()
                ]
                );
            }
        }

        private static void ÜksTehe(string[] tehterida)
        {
            switch ()
            {
                case "+":
                    Liitmine(double.Parse(a), double.Parse(b));
                    break;
                case "-":
                    Lahutamine(double.Parse(a), double.Parse(b));
                    break;
                case "*":
                    Korrutamine(double.Parse(a), double.Parse(b));
                    break;
                case "/":
                    Jagamine(double.Parse(a), double.Parse(b));
                    break;
            }
            
        }

        public static double Liitmine(double arv1, double arv2)
        {
            return arv1 + arv2;
        }
        public static double Lahutamine(double arv1, double arv2)
        {
            return arv1 - arv2;
        }
        public static double Korrutamine(double arv1, double arv2)
        {
            return arv1 * arv2;
        }
        public static double Jagamine(double arv1, double arv2)
        {
            return arv1 / arv2;
        }

    }
}
