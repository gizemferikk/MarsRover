using MarsRover.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Repository.Repository
{
    public class NorthOrientation : IOrientation
    {
        private const string description = "N";

        public IOrientation TurnLeft()
        {
            return new WestOrientation();
        }

        public IOrientation TurnRight()
        {
            return new EastOrientation();
        }

        public Coordinates Advance(Coordinates coordinates)
        {
            return new Coordinates(coordinates.X, coordinates.Y + 1);
        }

        public override string ToString()
        {
            return description;
        }
        public override bool Equals(object obj)
        {
            return obj is NorthOrientation;
        }

        public override int GetHashCode()
        {
            return description.GetHashCode();
        }
    }
}
