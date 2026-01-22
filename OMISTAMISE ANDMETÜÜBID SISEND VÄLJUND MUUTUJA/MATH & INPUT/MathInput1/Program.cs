namespace MathInput1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programm 1
            //int vanus = 0;
            //Console.WriteLine("Tere, alustamiseks palun sisestage oma vanus.");
            //vanus = int.Parse(Console.ReadLine());
            //int aastaarv = 0;
            //Console.WriteLine("Jätkamiseks palun sisestage selle kalendriaasta number.");
            //aastaarv = int.Parse(Console.ReadLine());
            //int sünniaasta = aastaarv - vanus;
            //Console.WriteLine($"Olete sündinud aastal {sünniaasta}.");

            //Programm 2
            //string kasutajaNimi = "";
            //Console.WriteLine("Sisse logimiseks palun sisestage oma nimi.");
            //kasutajaNimi = Console.ReadLine();
            //Console.WriteLine($"Olete edukalt sisse logitud, {kasutajaNimi}");

            //Programm 3




            //* Suunakood *//
            int suunakood = 0;
            Console.WriteLine("Palun sisesta oma suunakood");
            suunakood = int.Parse(Console.ReadLine());
            if (suunakood > 9999 && suunakood < 100000)
            {
                Console.WriteLine("Ahha nüüd tean kus sa elad");
            }
            else if (suunakood <= 9999)
            {
                Console.WriteLine("Üks täht on puudu");
            }
            else
            {
                Console.WriteLine("Üks täht on üle");
            }

        }
    }
}
