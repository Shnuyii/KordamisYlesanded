using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Player
    {
        public struct PlayerLocation
        {
            public PlayerLocation(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X { get; set; } = 0;
            public int Y { get; set; } = 0;

            public override string ToString()
            {
                return $"{X},{Y}";
            }
        }

        public Player(int lives, int health, PlayerLocation location, List<string> backpack, int money)
        {
            Lives = lives;
            Health = health;
            Location = location;
            Backpack = backpack;
            Money = money;
        }
        public int Lives { get; set; } = 3;
        public int Health { get; set; } = 100;
        public PlayerLocation Location { get; set; }
        public List<string> Backpack { get; set; }
        public int Money { get; set; } = 0;

        public void DisplayStats()
        {
            Console.WriteLine($"You currently have {Lives} lives and {Health} hp.");
            Console.WriteLine($"You are currently at {Location.ToString()} and have {Money} floppacoins.");
            Console.WriteLine($"You are currently holding onto {string.Join(",",Backpack)}");
        }

        public void HealthCheck()
        {
            if (Health <= 0)
            {
                Lives -= 1;
                Health = 100;
            }
        }
    }
}
