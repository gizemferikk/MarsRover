using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Tests
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod()]
        [TestCategory("Rover/Init")]
        public void RoverCoordinatesEqualToInitialCoordinates()
        {
            var rover = new Rover();
            var initialCoordinates = new Coordinates(0, 0);
            var endCoordinates = new Coordinates(0, 0);
            var orientation = new NorthOrientation();
            // Activity
            rover.Init(initialCoordinates, orientation);

            Assert.AreEqual(rover.Coordinates, endCoordinates);
        }

        [TestMethod()]
        [TestCategory("Rover/Init")]
        public void RoverOrientationEqualToInitialOrientation()
        {
            var rover = new Rover();
            var initialCoordinates = new Coordinates(5, 5);
            var orientation = new NorthOrientation();
            var finalOrientation = new NorthOrientation();

            // Activity
            rover.Init(initialCoordinates, orientation);

            Assert.AreEqual(rover.Orientation, finalOrientation);
        }

        [TestMethod()]
        [TestCategory("Rover/TurnLeft")]
        public void FinalOrientationWest_TurnLeft()
        {
            var rover = new Rover();
            var initialCoordinates = new Coordinates(0, 0);
            rover.Init(initialCoordinates, new NorthOrientation());

            // Activity
            rover.TurnLeft();

            Assert.AreEqual(rover.Orientation, new WestOrientation());
        }

        [TestMethod()]
        [TestCategory("Rover/TurnLeft")]
        public void FinalOrientationSouth_TurnLeft()
        {
            var rover = new Rover();
            var initialCoordinates = new Coordinates(0, 0);
            rover.Init(initialCoordinates, new WestOrientation());

            // Activity
            rover.TurnLeft();

            Assert.AreEqual(rover.Orientation, new SouthOrientation());
        }

        [TestMethod()]
        [TestCategory("Rover/TurnLeft")]
        public void FinalOrientationEast_TurnLeft()
        {
            var rover = new Rover();
            var initialCoordinates = new Coordinates(0, 0);
            rover.Init(initialCoordinates, new SouthOrientation());

            // Activity
            rover.TurnLeft();

            Assert.AreEqual(rover.Orientation, new EastOrientation());
        }

        [TestMethod()]
        [TestCategory("Rover/TurnLeft")]
        public void FinalOrientationNorth_TurnLeft()
        {
            var rover = new Rover();
            var initialCoordinates = new Coordinates(0, 0);
            rover.Init(initialCoordinates, new EastOrientation());

            // Activity
            rover.TurnLeft();

            Assert.AreEqual(rover.Orientation, new NorthOrientation());
        }

        [TestMethod()]
        [TestCategory("Rover/TurnRight")]
        public void FinalOrientationEast_TurnRight()
        {
            var rover = new Rover();
            var initialCoordinates = new Coordinates(0, 0);
            rover.Init(initialCoordinates, new NorthOrientation());

            // Activity
            rover.TurnRight();

            Assert.AreEqual(rover.Orientation, new EastOrientation());
        }

        [TestMethod()]
        [TestCategory("Rover/TurnRight")]
        public void FinalOrientationNorth_TurnRight()
        {
            var rover = new Rover();
            var initialCoordinates = new Coordinates(0, 0);
            rover.Init(initialCoordinates, new WestOrientation());

            // Activity
            rover.TurnRight();

            Assert.AreEqual(rover.Orientation, new NorthOrientation());
        }

        [TestMethod()]
        [TestCategory("Rover/TurnRight")]
        public void FinalOrientationWest_TurnRight()
        {
            var rover = new Rover();
            var initialCoordinates = new Coordinates(0, 0);
            rover.Init(initialCoordinates, new SouthOrientation());

            // Activity
            rover.TurnRight();

            Assert.AreEqual(rover.Orientation, new WestOrientation());
        }

        [TestMethod()]
        [TestCategory("Rover/TurnRight")]
        public void FinalOrientationSouth_TurnRight()
        {
            // Arrange
            var rover = new Rover();
            var initialCoordinates = new Coordinates(0, 0);
            rover.Init(initialCoordinates, new EastOrientation());

            // Act
            rover.TurnRight();

            //Assert
            Assert.AreEqual(rover.Orientation, new SouthOrientation());
        }

        [TestMethod()]
        [TestCategory("Rover/Move")]
        public void Move_From_00N_To_01N()
        {
            var rover = new Rover();
            var initialCoordinates = new Coordinates(0, 0);
            rover.Init(initialCoordinates, new NorthOrientation());

            // Activity
            rover.Move();

            Assert.AreEqual(rover.Coordinates, new Coordinates(0, 1));
        }

        [TestMethod()]
        [TestCategory("Rover/Move")]
        public void Move_From_00E_To_10E()
        {
            var rover = new Rover();
            var initialCoordinates = new Coordinates(0, 0);
            rover.Init(initialCoordinates, new EastOrientation());

            // Activity
            rover.Move();

            Assert.AreEqual(rover.Coordinates, new Coordinates(1, 0));
        }

        [TestMethod()]
        [TestCategory("Rover/Move")]
        public void Move_From_01S_To_00S()
        {
            var rover = new Rover();
            var initialCoordinates = new Coordinates(0, 1);
            rover.Init(initialCoordinates, new SouthOrientation());

            // Activity
            rover.Move();

            Assert.AreEqual(rover.Coordinates, new Coordinates(0, 0));
        }

        [TestMethod()]
        [TestCategory("Rover/Move")]
        public void Move_From_10W_To_00W()
        {
            var rover = new Rover();
            var initialCoordinates = new Coordinates(1, 0);
            rover.Init(initialCoordinates, new WestOrientation());

            // Activity
            rover.Move();

            Assert.AreEqual(rover.Coordinates,new Coordinates(0, 0));
        }

        [TestMethod()]
        [TestCategory("Rover/Move")]
        public void Move_From_InitCoordinates33W_And_PlateauSet55_NewCoordinates_23W()
        {
            
            var rover = new Rover();
            var initialCoordinates = new Coordinates(3, 3);
            rover.Init(initialCoordinates, new WestOrientation());

            var upperLeft = new Coordinates(5, 5);
            var plateau = new Plateau(upperLeft);

            rover.SetPlateau(plateau);

            // Activity
            rover.Move();

            Assert.AreEqual(rover.Coordinates, new Coordinates(2, 3));
            Assert.AreEqual(rover.Orientation, new WestOrientation());
        }

        [TestMethod()]
        [TestCategory("Rover/Create")]
        public void CreateRover_55N()
        {
            // Activity
            var rover = Rover.CreateRover("5 5 N");

            Assert.AreEqual(rover.Orientation, new NorthOrientation());
            Assert.AreEqual(rover.Coordinates, new Coordinates(5, 5));
        }

    }
}