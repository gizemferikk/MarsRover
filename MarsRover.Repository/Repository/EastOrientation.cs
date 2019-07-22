using MarsRover.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Repository.Repository
{
    public class EastOrientation : IOrientation
    {
        private const string description = "E";

        public IOrientation TurnLeft()
        {
            return new NorthOrientation();
        }

        public IOrientation TurnRight()
        {
            return new SouthOrientation();
        }

        public Coordinates Advance(Coordinates coordinates)
        {
            return new Coordinates(coordinates.X + 1, coordinates.Y);
        }

        public override bool Equals(object obj)
        {
            return obj is EastOrientation;
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
