using MarsRover.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Repository.Repository
{
    public class NoneOrientation : IOrientation
    {
        private const string description = "None orientation";

        public IOrientation TurnLeft()
        {
            return this;
        }

        public IOrientation TurnRight()
        {
            return this;
        }

        public Coordinates Advance(Coordinates coordinates)
        {
            return coordinates;
        }

        public override bool Equals(object obj)
        {
            return obj is NoneOrientation;
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
