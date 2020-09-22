using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SectorWork;

namespace ConsoleWorkTest
{
    [TestClass]
    public class SectorTest
    {
        [TestMethod]
        public void Set_Sector_With_Invalid_Radius_Should_Throw_ArgumentOutOfRangeException()
        {
            //Arrange
            double r = -4;
            Sector sector = new Sector();

            //Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => sector.R = r);

        }
		
	[TestMethod]
	public void Set_Sector_With_Angle_less_or_equal_to_null_Should_Throw_ArgumentOutOfRangeException()
        {
            //Arrange
            double angle = 0;
            Sector sector = new Sector();

            //Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => sector.Angle = angle);

        }
		
	[TestMethod]
	public void Set_Sector_With_Invalid_Radius_Should_Throw_ArgumentOutOfRangeException()
        {
            //Arrange
            double angle = 361;
            Sector sector = new Sector();

            //Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => sector.Angle = angle);

        }

        [TestMethod]
        public void Sector_With_Valid_Radius_Get_Area()
        {
            //Arrange
            double r = 4;
	    double angle = 360;
            double expected = 50.265;
            Sector sector = new Sector();

            //Act
            sector.R = r;
	    sector.Angle = angle;
            double actual = sector.GetArea();

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Area of sector wasn't calculated correctly");

        }
		
	[TestMethod]
        public void Sector_With_Valid_Radius_Get_Area()
        {
            //Arrange
            double r = 4;
	    double angle = 90;
            double expected = 12.566;
            Sector sector = new Sector();

            //Act
            sector.R = r;
	    sector.Angle = angle; 
            double actual = sector.GetArea();

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Area of sector wasn't calculated correctly");

        }

        [TestMethod]
        public void Sector_With_Valid_Radius_Get_Arc()
        {
            //Arrange
            double r = 4;
	    double angle = 180;
            double expected = 12.566;
            Sector sector = new sector();

            //Act
            sector.R = r;
	    sector.Angle = angle;
            double actual = sector.GetArc();

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Area wasn't calculated correctly");

        }

        [TestMethod]
        public void Sector_With_Same_Radius_and_Angle_Is_Sectors_Equals()
        {
            //Arrange
            double r1 = 4.2;
            double r2 = 4.2;
	    double angle1 = 270;
            double angle2 = 270;
            bool expected = true;
            Sector sector1 = new Sector();
            Sector sector2 = new Sector();

            //Act
            sector1.R = r1;
            sector2.R = r2;
	    sector1.Angle = angle1;
	    sector2.Angle = angle2;
            bool actual = sector1.IsSectorEquals(sector2);

            //Assert
            Assert.AreEqual(expected, actual, "Sector are not Equals");

        }

        [TestMethod]
        public void Sector_With_Different_Radius_Is_Sectors_Equals()
        {
            //Arrange
            double r1 = 4.2;
            double r2 = 4.3;
	    double angle1 = 1;
	    double angle2 = 1;
            bool expected = false;
            Sector sector1 = new Sector();
            Sector sector2 = new Sector();

            //Act
            sector1.R = r1;
            sector2.R = r2;
	    sector1.Angle = angle1;
	    sector2.Angle = angle2;
            bool actual = sector1.IsSectorEquals(sector2);

            //Assert
            Assert.AreEqual(expected, actual, "Sector are Equals");

        }
		
	[TestMethod]
        public void Sector_With_Different_Angles_Is_Sectors_Equals()
        {
            //Arrange
            double r1 = 4.2;
            double r2 = 4.2;
	    double angle1 = 1;
	    double angle2 = 2;
            bool expected = false;
            Sector sector1 = new Sector();
            Sector sector2 = new Sector();

            //Act
            sector1.R = r1;
            sector2.R = r2;
	    sector1.Angle = angle1;
	    sector2.Angle = angle2;
            bool actual = sector1.IsSectorEquals(sector2);

            //Assert
            Assert.AreEqual(expected, actual, "Sector are Equals");

        }


    }
}
