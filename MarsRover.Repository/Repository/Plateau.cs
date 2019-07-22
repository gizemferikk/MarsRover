using MarsRover.Repository.IRepository;
using MarsRovers.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Repository.Repository
{
    public class Plateau : IPlateau
    {
        private readonly Coordinates upperLeft;

        public Coordinates UpperLeft
        {
            get { return upperLeft; }
        }
        public Plateau(Coordinates upperLeft)
        {
            this.upperLeft = upperLeft;
        }

        public bool AreCoordinatesInside(Coordinates coordinatesToCheck)
        {
            if (coordinatesToCheck.Y > upperLeft.Y) return false;
            if (coordinatesToCheck.X > upperLeft.X) return false;
            if (coordinatesToCheck.X < 0) return false;
            if (coordinatesToCheck.Y < 0) return false;

            return true;
        }

        public static Plateau CreatePlateau(string definition)
        {
            if (string.IsNullOrEmpty(definition)) throw new WrongPlateauDefinitionException("Definition of plateau is null!");

            var stringCoordinates = definition.Split(' ');

            if (stringCoordinates.Length != 2) throw new WrongPlateauDefinitionException("Definition of plateau doesn't have the proper format.");

            Coordinates coordinates;

            try
            {
                coordinates = new Coordinates(Convert.ToInt32(stringCoordinates[0]),
                                                  Convert.ToInt32(stringCoordinates[1]));
            }
            catch (Exception ex)
            {
                throw new WrongPlateauDefinitionException("Bad definition.", ex);
            }

            return new Plateau(coordinates);
        }
    }
}
