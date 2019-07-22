using MarsRover.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Repository.IRepository
{
    public interface IOrientation
    {
        IOrientation TurnLeft();
        IOrientation TurnRight();
        Coordinates Advance(Coordinates coordinates);
    }
}
