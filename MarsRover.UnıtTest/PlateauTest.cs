using System;
using MarsRover.Repository.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnıtTest
{
    [TestClass]
    public class PlateauTest
    {
        [TestMethod()]
        [TestCategory("Plateau/AreCoordinatesInside")]
        public void AreCoordinatesInside_Plateau55_And_Coordinates22()
        {
            var upperLeft = new Coordinates(5, 5);
            var plateau = new Plateau(upperLeft);
            var coordinatesToCheck = new Coordinates(2, 2);

            // Activity
            var result = plateau.AreCoordinatesInside(coordinatesToCheck);

            Assert.AreEqual(result, true);
        }



        [TestMethod()]
        [TestCategory("Plateau/AreCoordinatesInside")]
        public void AreCoordinatesInside_Plateau55_And_Coordinates00()
        {
            var upperLeft = new Coordinates(5, 5);
            var plateau = new Plateau(upperLeft);
            var coordinatesToCheck = new Coordinates(0, 0);

            // Activity
            var result = plateau.AreCoordinatesInside(coordinatesToCheck);

            Assert.AreEqual(result, true);
        }

        [TestMethod()]
        [TestCategory("Plateau/AreCoordinatesInside")]
        public void AreCoordinatesInside_Plateau55_And_Coordinates55()
        {
            var upperLeft = new Coordinates(5, 5);
            var plateau = new Plateau(upperLeft);
            var coordinatesToCheck = new Coordinates(5, 5);

            // Activity
            var result = plateau.AreCoordinatesInside(coordinatesToCheck);

            Assert.AreEqual(result, true);
        }

        [TestMethod()]
        [TestCategory("Plateau/AreCoordinatesInside")]
        public void AreCoordinatesInside_Plateau55_And_Coordinates57()
        {
            var upperLeft = new Coordinates(5, 5);
            var plateau = new Plateau(upperLeft);
            var coordinatesToCheck = new Coordinates(5, 7);

            // Activity
            var result = plateau.AreCoordinatesInside(coordinatesToCheck);

            Assert.AreEqual(result, false);
        }

        [TestMethod()]
        [TestCategory("Plateau/AreCoordinatesInside")]
        public void AreCoordinatesInside_Plateau55_And_Coordinates65()
        {
            var upperLeft = new Coordinates(5, 5);
            var plateau = new Plateau(upperLeft);
            var coordinatesToCheck = new Coordinates(6, 5);

            // Activity
            var result = plateau.AreCoordinatesInside(coordinatesToCheck);

            Assert.AreEqual(result, false);
        }

        [TestMethod()]
        [TestCategory("Plateau/AreCoordinatesInside")]
        public void AreCoordinatesInside_Plateau55_And_CoordinatesMinus25()
        {
            var upperLeft = new Coordinates(5, 5);
            var plateau = new Plateau(upperLeft);
            var coordinatesToCheck = new Coordinates(-2, 5);

            // Activity
            var result = plateau.AreCoordinatesInside(coordinatesToCheck);

            Assert.AreEqual(result, false);
        }

        [TestMethod()]
        [TestCategory("Plateau/Create")]
        public void CreatePlateau_55_ThePlateauCoordinatesShouldBe55()
        {
            // Activity
            var plateau = Plateau.CreatePlateau("5 5");

            Assert.AreEqual(plateau.UpperLeft, new Coordinates(5, 5));
        }
    }
}
