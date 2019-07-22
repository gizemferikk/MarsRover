using MarsRover.ErrorException;
using MarsRover.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Repository.Repository
{
    public static class OrientationFactory
    {
        public static IOrientation GenerateOrientation(string type)
        {
            switch (type)
            {
                case "N":
                    return new NorthOrientation();
                case "E":
                    return new EastOrientation();
                case "S":
                    return new SouthOrientation();
                case "W":
                    return new WestOrientation();
                default:
                    throw new OrientationException("Unknown orientation type.");
            }
        }
    }
}
