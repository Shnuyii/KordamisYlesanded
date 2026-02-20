namespace KT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Programm 1
            //int vanus = 0;
            //do
            //{
            //   Console.WriteLine("Palun sisestage oma vanus mis on suurem kui 0.");
            //    vanus = int.Parse(Console.ReadLine());
            //}while (vanus == 0);

            /// Programm 2
            int aastaArv = 0;
            while (aastaArv < 1000 || aastaArv > 2025)
            {
                Console.WriteLine("Palun sisestage aastaarv");
                aastaArv = int.Parse(Console.ReadLine());
            }

            ///Programm 3
            //List<string> jõulukingitused = new List<string>() {"banaan", "mango", "kookos", "õun", "virsik" };
            //for (int i = 0;i < jõulukingitused.Count; i++)
            //{
            //    Console.WriteLine($"{i+1}. {jõulukingitused.ElementAt(i)}");
            //}

            ///Programm 4
            //int[] massiiviArvud = [5, 3, 2, 7, 1];
            //int k = 1;
            //foreach (int i in massiiviArvud)
            //{
            //    k *= i;
            //}
            //Console.WriteLine(k);

        }
    }
}
