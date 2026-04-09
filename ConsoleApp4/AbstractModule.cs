using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class AbstractModule
    {
        protected Coord Position;
        protected int Fuel;
        public AbstractModule(Coord position, int fuel)
        {
            Position = position;
            Fuel = fuel;
        }
        public Coord getPosition() {  return Position; }
        public void setPosition(Coord position) { Position = position; }
        public int getFuel() { return Fuel; }
        public abstract void Act();
        public virtual void ConsumeFuel(int amount)
        {
            if (Fuel > 0 && amount <= Fuel)
            {
                Fuel -= amount;
            }
        }
    }
}
