using MarsRover.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Repository.Repository
{
    public class SouthOrientation : IOrientation
    {
        private const string description = "S";

        public IOrientation TurnLeft()
        {
            return new EastOrientation();
        }

        public IOrientation TurnRight()
        {
            return new WestOrientation();
        }

        public Coordinates Advance(Coordinates coordinates)
        {
            return new Coordinates(coordinates.X, coordinates.Y - 1);
        }

        public override bool Equals(object obj)
        {
            return obj is SouthOrientation;
        }

        public override string ToString()
        {
            return description;
        }
        public override int GetHashCode()
        {
            return description.GetHashCode();
        }
    }
}
