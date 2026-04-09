using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public sealed class ScoutModule : AbstractModule
    {
        public override void Act()
        {
            var move = new Coord(1, 0);
            int consuming = 1;
            ConsumeFuel(consuming);
            {
                Position += move;
            }
        }
        public ScoutModule (Coord position, int fuel) : base (position, fuel)
        {

        }
    }
}
