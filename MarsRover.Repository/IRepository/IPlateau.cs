using MarsRover.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Repository.IRepository
{
    public interface IPlateau
    {
        Coordinates UpperLeft{get;}

        bool AreCoordinatesInside(Coordinates coordinatesToCheck);
    }
}
