using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public readonly struct Coord
    {
        public int X {  get; }
        public int Y { get; }
        public Coord(int x, int y) {  X = x; Y = y; }
        public static Coord operator +(Coord a, Coord b)
        {
            return new Coord (a.X + b.X, a.Y + b.Y);
        }
        public static Coord operator -(Coord a, Coord b)
        {
            return new Coord(a.X - b.X, a.Y - b.Y);
        }
        public static Coord operator *(Coord a, int b)
        {
            return new Coord(a.X * b, a.Y * b);
        }
        public static bool operator ==(Coord a, Coord b)
        {
            if (a.X == b.X && a.Y == b.Y) {  return true; }
            return false;
        }
        public static bool operator !=(Coord a, Coord b)
        {
            return !(a == b);
        }
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
