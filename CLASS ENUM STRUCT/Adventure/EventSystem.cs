using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Adventure.Player;

namespace Adventure
{
    public class EventSystem
    {

        public static void NextEncounter(Player player, World map, Random rng)
        {
            PlayerLocation playerlocation = player.Location;
            int result = map.Map[playerlocation.X, playerlocation.Y];
            switch (result)
            {
                case 1:
                    Event1_Kratt(player);
                    break;
                case 2:
                    Event2_Witch(player);
                    break;
                case 3:
                    Event3_Mushroom(player, rng);
                    break;
                case 4:
                    Event4_Knife(player);
                    break;
                case 5:
                    Event5_Hill(player);
                    break;
                case 6:
                    Event6_Shop(player);
                    break;
            }
        }
        public static void NextEncounter(Player player, Random rng)
        {
            int nextEncounterInt = rng.Next(1, 7);
            switch (nextEncounterInt)
            {
                case 1:
                    Event1_Kratt(player);
                    break;
                case 2:
                    Event2_Witch(player);
                    break;
                case 3:
                    Event3_Mushroom(player, rng);
                    break;
                case 4:
                    Event4_Knife(player);
                    break;
                case 5:
                    Event5_Hill(player);
                    break;
                case 6: 
                    Event6_Shop(player);
                    break;
            }
        }

        private static void Event6_Shop(Player player)
        {
            List<string> riiul = new List<string>()
                {
                    "a shoe",
                    "real knife",
                    "DDR5 32GB 2x16 kit",
                    "cheese ball",
                    "stinky sock"
                };
            List<int> hinnad = new List<int>()
                {
                    1000,
                    12,
                    1600,
                    3,
                    -6,
                };
            for (int i = 0; i < riiul.Count; i++)
            {
                //kuva kasutajale asi, selle hind
                Console.WriteLine($"On the shelf there is a {riiul[i]} and it costs {hinnad[i]}.");
                Console.WriteLine("Do you want to buy it? (Y/N)");
                string vastus = Console.ReadLine();
                if (vastus == "Y")
                {
                    if (hinnad[i] < player.Money)
                    {
                        player.Backpack.Add(riiul[i]);
                        player.Money -= hinnad[i];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not enough money, too bad.");
                    }
                }
                else
                {
                    Console.WriteLine("Viewing the next item.");
                }
            }
            Console.WriteLine($"You left the shop.");
        }

        private static void Event5_Hill(Player player)
        {
            Console.WriteLine("Kõnnid mööda teed, ja vastu tuleb huvtava kujuga põlvekõrgune mätas");
            Console.WriteLine("Mätas on keset teed ees, ei saa ei üle ega ümber sest oled laisk, mida teed?");
            Console.WriteLine("1 - ronin üle\n2 - kaevan lahti\n3 - pööran ringi ja lähen tagasi");
            Console.WriteLine("kirjuta vastava valiku number");
            string reply = Console.ReadLine();
            switch (reply)
            {
                case "1":
                    Console.WriteLine("Ronid mättast üle, ja jätkad oma teed");
                    break;
                case "2":
                    player.Money += 5;
                    Console.WriteLine("Kaevasid mätta lahti, ja leidsid väikese rahapaja, seal oli viis münti.");
                    break;
                default:
                    Console.WriteLine("Hakkasid kannapealt ringi pöörama, kui sellel hetkel kargas mätta\n" +
                        "tagant tuttav kratt, ja peksis sind natuke, kaotasid ühe elu.");
                    player.Money -= 1;
                    break;
            }
        }

        private static void Event4_Knife(Player player)
        {
            Console.WriteLine("Leiad maast noa, ta on verine, kas sa võtad selle üles?:");
            string reply = Console.ReadLine();
            if (reply == "jah")
            {
                Console.WriteLine("Panid noa seljakotti");
                player.Backpack.Add("nuga");
            }
            else
            {
                Console.WriteLine("Kõndisid minema, las politsei uurib");
            }
        }

        private static void Event3_Mushroom(Player player, Random rng)
        {
            int seeneEffekt = rng.Next(-4, 4);
            Console.WriteLine("Leiad seene, kas tahad seda maitsta?:");
            string vastus = Console.ReadLine();
            if (vastus == "jah")
            {
                if (seeneEffekt >= 0)
                {
                    Console.WriteLine("Seen maitses hästi, said juurde " + seeneEffekt + " elu.");
                    player.Lives += seeneEffekt;
                }
                else
                {
                    Console.WriteLine("Kurat, sitaseen oli, tunned ennast väga pahasti ja kaotasid " + (-seeneEffekt) + " elu.");
                    player.Lives += seeneEffekt;
                }
            }
            else
            {
                Console.WriteLine("Jätad seene maha nagu oma abusivi eksi.");;
            }
        }

        private static void Event2_Witch(Player player)
        {
            Console.WriteLine("NYEH! Oled eksinud minu koju! Mis sul - sissetungijal - öelda on!!!");
            string reply = Console.ReadLine();
            if (reply.ToLower() == "palun vabandust")
            {
                Console.WriteLine("No olgu, eks sa mine siis...");
                player.Lives += 0;
            }
            else if (reply.ToLower() == "tahtsin sulle kooki tuua")
            {
                Console.WriteLine("Oi aitäh, anna sulle ühe elu selle koogi vastu");
                player.Lives += 1;
            }
            else
            {
                Console.WriteLine("MISASJA!?!?!?? KUIDAS SA JULGED?!?! KÄI ISE " + reply);
                player.Lives -= 1;
            }
        }

        private static void Event1_Kratt(Player player)
        {
            Random newrng = new Random();
            int randomNum = newrng.Next(1, 10); //suvaline täisarv vahemikus 1-10

            if (!player.Backpack.Contains("nuga"))
            {
                Console.WriteLine("Hahaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!"); //flavourtext
                Console.WriteLine("Arva:"); //oota kasutajalt sisestust
                int kasutajaArv = int.Parse(Console.ReadLine());

                if (randomNum == kasutajaArv) // kontrolli sisestust tingimuslauses
                {
                    Console.WriteLine("AIAIAIAAA, Y U DIS TO ME *sureb*"); //kui on õige
                }
                else
                {
                    Console.WriteLine("HJEHJEHJEH - õige vastus oli" + randomNum + "!!!! sa kaotasid!"); //kui on vale
                    player.Lives -= 1;
                }
            }
            else
            {
                Console.WriteLine("Vastu tuleb kuri kratt, aga sul on nuga. Kratt ütleb:");
                Console.WriteLine("\"Hahaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!\"");
                Console.WriteLine("Mida sa teed? Kas vastad (1) või ründad noaga (2)?");
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    Console.WriteLine("Arva:"); //oota kasutajalt sisestust
                    int kasutajaArv = int.Parse(Console.ReadLine());

                    if (randomNum == kasutajaArv) // kontrolli sisestust tingimuslauses
                    {
                        Console.WriteLine("AIAIAIAAA, Y U DIS TO ME *sureb*"); //kui on õige
                    }
                    else
                    {
                        Console.WriteLine("HJEHJEHJEH - õige vastus oli" + randomNum + "!!!! sa kaotasid!"); //kui on vale
                        player.Lives -= 1;
                    }
                }
                else
                {
                    Console.WriteLine("Lõikasid krati lõhki, ta maost voolas välja 25 münti!\nAga nuga murdus...");
                    player.Money += 25;
                    player.Backpack.Remove("nuga");
                }
            }
        }

        internal static void NextLocation(Player player, World map)
        {
            int mapXmax = map.Map.GetLength(0);
            int mapYmax = map.Map.GetLength(1);
            Console.WriteLine("Kuhu sa edasi minna tahad? Vali suund (kirjuta täht)");
            Console.WriteLine("  N  ");
            Console.WriteLine("W + E");
            Console.WriteLine("  S ");
            string response = Console.ReadLine();
            switch (response)
            {
                case "N":
                    int nextLocationN = CheckCandidate(mapYmax, player.Location.Y - 1, true);
                    player.Location = new PlayerLocation(player.Location.X, player.Location.Y - 1);
                    break;
                case "S":
                    int nextLocationS = CheckCandidate(mapYmax, player.Location.Y + 1);
                    player.Location = new PlayerLocation(player.Location.X, player.Location.Y + 1);
                    break;
                case "W":
                    int nextLocationW = CheckCandidate(mapXmax, player.Location.X - 1, true);
                    player.Location = new PlayerLocation(player.Location.X - 1, player.Location.Y);
                    break;
                case "E":
                    int nextLocationE = CheckCandidate(mapXmax, player.Location.X + 1);
                    player.Location = new PlayerLocation(player.Location.X + 1, player.Location.Y);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Checks if the player location exceeds maximum value and returns int 0 as next location if it does exceed.
        /// </summary>
        /// <param name="maxvalue">value to compare against</param>
        /// <param name="playerFutureLocation">player future location</param>
        /// <returns>new value to set player at.</returns>
        private static int CheckCandidate(int maxvalue, int playerFutureLocation, bool checkMinimum = false)
        {
            if (checkMinimum == false)
            {
                if (playerFutureLocation > int.MaxValue)
                {
                    //Telepordib teise serva
                    return 0;
                    //Peatab seina ees
                    //return maxvalue;
                }
                else
                {
                    return playerFutureLocation;
                }
            }
            else
            {
                if (playerFutureLocation < 0)
                {
                    return maxvalue;
                    //return 0;
                }
                else
                {
                    return playerFutureLocation;
                }
            }
        }

        internal static bool CheckWin(PlayerLocation location, PlayerLocation goal)
        {
            if (location.ToString() == goal.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
} 
