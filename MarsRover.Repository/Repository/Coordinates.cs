using MarsRover.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Repository.Repository
{
    public class Coordinates : ICoordinates
    {
        private readonly int x;
        private readonly int y;

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Coordinates))
                return false;

            return Equals((Coordinates)obj);
        }

        public bool Equals(Coordinates other)
        {
            if (x != other.x)
                return false;

            return y == other.y;
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", x, y);
        }
    }
}
