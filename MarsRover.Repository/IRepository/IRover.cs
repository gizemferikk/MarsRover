using MarsRover.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Repository.IRepository
{
    public interface IRover
    {
        void Init(Coordinates coordinates, IOrientation orientation);

        IOrientation Orientation { get; }

        Coordinates Coordinates { get; }

        void SetPlateau(Plateau plateau);

        void TurnLeft();

        void TurnRight();

        string GetPosition();

        void Move();

        void ExecuteCommands(string stringCommands);
    }
}
