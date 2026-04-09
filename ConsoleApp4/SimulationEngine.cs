using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class SimulationEngine
    {
        public bool TryStep(AbstractModule[][] map, in int turnNumber, out int processedCount, ref int totalFuelConsumed)
        {
            processedCount = 0;
            foreach (var i in map)
            {
                if (i != null)
                {
                    foreach (var j in i)
                    {
                        int exFuel = j.getFuel();
                        j.Act();
                        totalFuelConsumed += exFuel - j.getFuel();
                        processedCount++;
                    }
                }
            }
            if (processedCount > 0) { return true; }
            return false;
        }
        public static void ShiftMapCoords(AbstractModule[][] map, in Coord offset)
        {
            foreach (var i in map)
            {
                if (i != null)
                {
                    foreach (var j in i)
                    {
                        if (j != null)
                        {
                            j.setPosition(offset + j.getPosition());
                        }
                    }
                }
            }
        }
    }
}
