using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Adventure.Player;

namespace Adventure
{
    public class World
    {
        public int[,] Map {  get; set; }
        public string WorldName { get; set; }
        public PlayerLocation StartingPoint { get; set; }
        public PlayerLocation Goal {  get; set; }
        /// <summary>
        /// Constructor for the default world, with size of 10x10
        /// </summary>
        /// <param name="thisMap">2d array for the new map of the world, contains integers that represent different events</param>
        /// <param name="thisWorldName">name for this world</param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public World(int[,] thisMap, string thisWorldName, PlayerLocation start, PlayerLocation end)
        {
            Map = NewMap(10, 5);
            WorldName = thisWorldName;
            StartingPoint = start;
            Goal = end;
        }
        public World(string thisWorldName, PlayerLocation start, PlayerLocation end)
        {
            Map = NewMap(10,6);
            WorldName = thisWorldName;
            StartingPoint = start;
            Goal = end;
        }
        /// <summary>
        /// Method to generate a new map randomly
        /// </summary>
        /// <param name="size">the size of the map, both x and y axis</param>
        /// <param name="maxEventInteger">this integer id for the last possible event to be put into the array</param>
        /// <returns>new generated map</returns>
        private int[,]? NewMap(int size, int maxEventInteger)
        {
            int[,] newMap = new int[size, size];
            Random rng = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    newMap[i, j] = rng.Next(1, maxEventInteger + 1);
                }
            }
            return newMap;
        }
    }
}
