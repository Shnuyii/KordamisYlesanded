namespace Meetodid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Palun sisesta esimene arv.");
            //float arv1 = 0;
            //arv1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Palun sisestada teine arv.");
            //float arv2 = 0;
            //arv2 = float.Parse(Console.ReadLine());

            //string tehteTüüp = "";
            //Console.WriteLine("Palun sisestada tehte tüüp (+, -, *, /, ^, v)");
            //tehteTüüp = Console.ReadLine();

            //double tulemus = 0.0d;

            //if (tehteTüüp != "")
            //{
            //    switch (tehteTüüp)
            //    {
            //        default:
            //            Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");
            //            break;
            //        case "+":
            //            tulemus = arv1 + arv2;
            //            break;
            //        case "*":
            //            tulemus = arv1 * arv2;
            //            break;
            //        case "-":
            //            tulemus = arv1 - arv2;
            //            break;
            //        case "/":
            //            tulemus = arv1 / arv2;
            //            break;
            //        case "^":
            //            tulemus = Math.Pow(arv1, arv2);
            //            break;
            //        case "v":
            //            tulemus = Math.Pow(arv1, 1 / arv2);
            //            break;
            //    }
            //    Console.WriteLine($"Teie tehte tulemus on {arv1} {tehteTüüp} {arv2} =  {tulemus}");
            //}
            //else
            //{
            //    Console.WriteLine("Tehet ei saa sooritada, tehte tüüp puudub");
            //}
            //Console.WriteLine("Sisesta oma nimi");
            //string kasutajanimi = GetAnswer();
            //Console.WriteLine("Tere "+kasutajanimi);
            //Console.WriteLine("Palun sisesta ka oma tänavanimi");
            //string tänavanimi = GetAnswer();
            //Console.WriteLine(kasutajanimi+" ahha! Elad "+tänavanimi+" tänaval");
            VanusVastus();
        }
         
        private static void VanusVastus()
        {
            Console.WriteLine("Kui vana oled?");
            string KasutajaVanus =GetAnswer();
            int vanus = int.Parse(KasutajaVanus);
            if (vanus > 60)
            {
                Console.WriteLine("Kuidas jalad liiguvad? Hästi?");
            }
            else if (vanus > 18)
            {
                Console.WriteLine("Mitu monsterit päevas jood?");
            }
            else
            {
                Console.WriteLine("Alakas");
            }
        }

        private static string GetAnswer()
        {
            string input = "";
            do
            {
                Console.WriteLine("Palun sisesta:");
                Console.ReadLine();
            } while (input == "");
            return input;
        }

        private static double Juurimine(float arv1, float arv2)
        {
            return Math.Pow(arv1, 1 / arv2);
        }
        private static double Astendamine(float arv1, float arv2)
        {
            return Math.Pow(arv1, arv2);
        }
        private static double Korrutamine(float arv1, float arv2)
        {
            return arv1 * arv2;
        }
        private static double Jagamine(float arv1, float arv2)
        {
            return arv1 / arv2;
        }
        private static double Lahutamine(float arv1, float arv2)
        {
            return arv1 - arv2;
        }
        private static double Liitmine(float arv1, float arv2)
        {
            return arv1 + arv2;
        }
    }
}
