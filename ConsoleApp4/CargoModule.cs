using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public sealed class CargoModule : AbstractModule
    {
        public CargoModule(Coord position, int fuel) : base(position, fuel)
        {

        }
        public override void Act()
        {
            var move = new Coord(0, -1);
            int consuming = 2;
            ConsumeFuel(consuming);
            {
                Position += move;
            }
        }
    }
}
