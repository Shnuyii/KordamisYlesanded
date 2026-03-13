using System.Security.Cryptography;

namespace _7___SimpleGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //    int floopaCoins = 0;
            //    int elud = 3;
            //    Tuple<int,int> data = new Tuple<int, int>(elud, floopaCoins );
            //    Random juhuArv = new Random(); //Tekitab Random generaatori
            //    string mängijaMängib = "jah"; //vastus küsimusele, kas mängija mängib
            //    do //tsükkel
            //    {
            //        do
            //        {
            //            Console.WriteLine("Vajuta ükskõik mis klahvi et jätkata");
            //            Console.ReadLine();
            //            Console.Clear();
            //            int järgmineEvent = juhuArv.Next(1, 4);
            //            switch (järgmineEvent)
            //            {
            //                case 1:
            //                    Console.WriteLine("Kõnnid küla tee peal ja vastu tuleb elukas.");
            //                    Stats(elud, floopaCoins);
            //                    elud = Mõistatus(juhuArv, elud);
            //                    break;
            //                case 2:
            //                    Console.WriteLine("Kõnnid küla tee peal ja vastu tuleb Nõid.");
            //                    Stats(elud, floopaCoins);
            //                    elud = Nõid(juhuArv, elud);
            //                    break;
            //                case 3:
            //                    Console.WriteLine("Kõnnid metsas ja vastu tuleb seen.");
            //                    Stats(elud, floopaCoins);
            //                    elud = Seen(juhuArv, elud);
            //                    break;
            //                case 4:
            //                    Console.WriteLine("Kõnnid tänaval ja leiad Floppa");
            //                    Stats(elud, floopaCoins);

            //                    data = Floppa(data);
            //                    break;
            //                default:
            //                    break;
            //            }
            //        } while (elud > 0);

            //        if (elud <= 0)
            //        {
            //        Console.WriteLine("Vajuta ükskõik mis klahvi et jätkata");
            //        Console.ReadLine();
            //        Console.Clear();
            //        Console.WriteLine("--== Kas soovid uuesti mängida? Sul on elud otsas. ==--");
            //        mängijaMängib = Console.ReadLine();
            //            if (mängijaMängib == "jah")
            //            {
            //                elud = 3;
            //            }
            //        }

            //    } while (mängijaMängib == "jah");
            //}

            //private static Tuple<int,int> Floppa(Tuple<int,int> data)
            //{
            //    int modifier1 = data.Item1;
            //    Console.WriteLine("Mis soovid Floppaga teha?\n1 - Kaasa võtta \n2 - Tagastada omanikule \n3 - Maha jätta \nValimiseks sisesta number:");
            //    int valik = 0;
            //    switch (valik)
            //    {
            //        case 1:
            //            Console.WriteLine("Sa võttad Floppa kaasa ja saad endale 5 floopa coini");

            //            modifier1 += 5;
            //            break;
            //    }
            //    return data;

            //}

            //private static void Stats(int elud, int floopaCoins)
            //{
            //    Console.WriteLine("Sul on alles " + elud + " elu.");
            //    Console.WriteLine("Sul on rahakotis "+floopaCoins+" floopa coini");
            //}

            //private static int Seen(Random juhuArv, int elud)
            //{
            //    int kaotatudElud = juhuArv.Next(-4, 4);
            //    Console.WriteLine("Kas tahad seene ära süüa?");
            //    string vastus = Console.ReadLine();
            //    if (vastus == "jah")
            //    {
            //        if (kaotatudElud >= 0)
            //        {
            //            Console.WriteLine("Lucky! Sööd seene ära ja saad " + kaotatudElud + " elu!");
            //            int eludAlles = elud + kaotatudElud;
            //            return eludAlles;
            //        }
            //        else if (kaotatudElud < 0)
            //        {
            //            Console.WriteLine("Damn bro, kaotasid "+kaotatudElud+" elu...");
            //            int eludAlles = elud + kaotatudElud;
            //            return eludAlles;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Okei, jätad seene sinna.");
            //        return elud;
            //    }
            //    return elud;
            //}

            //private static int Nõid(Random juhuArv, int elud)
            //{
            //    Console.WriteLine("NYEH! Oled eksinud minu koju! Mis sul - sissetungijal - öelda on!!!");
            //    string vastus = Console.ReadLine();
            //    if (vastus.ToLower() == "palun vabandust")
            //    {
            //        Console.WriteLine("No olgu, eks sa mine siis...");
            //        return elud;
            //    }
            //    else if (vastus.ToLower() == "tahtsin sulle kooki tuua")
            //    {
            //        Console.WriteLine("Oi aitäh, annan sulle ühe elu selle koogi vastu");
            //        return elud + 1;
            //    }
            //    else
            //    {
            //        vastus = vastus.ToUpper();
            //        Console.WriteLine("MISASJA?!?!?!?!?! KUIDAS SA JULGED, ISE "+vastus);
            //        return elud - 1;
            //    }
            //}

            //private static int Mõistatus(Random juhuArv, int elud)
            //{
            //    int seeJuhuArv = juhuArv.Next(1, 10); //suvaline täisarv vahemikus 1-10
            //    Console.WriteLine("Hahhaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!"); // Kuvab teksti andes kasutajale teada et mäng on alanud
            //    Console.WriteLine("Arva:"); //annab kasutajale teada et sisestada täisarv
            //    int kasutajaArv = int.Parse(Console.ReadLine()); //
            //    if (seeJuhuArv == kasutajaArv)
            //    {
            //        Console.WriteLine("AIAIAIAIAAAA, Y U DO DIS TO ME *sureb*");
            //        return elud;
            //    }
            //    else
            //    {
            //        Console.WriteLine("HJEHJEHJEH - õige vastus oli " + seeJuhuArv + "!!!! Sa kaotasid!");
            //        return elud -= 1;
            //    }
        }
    }
}
