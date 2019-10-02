using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;
using System;
using System.Text;
using System.IO;

namespace UnitClassesProject
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void Point_Constructor_By_Defaut_not_null()
        {
            // arrage
            Point point = new Point();

            // assert
            Assert.IsNotNull(point);
        }

        [TestMethod]
        public void Point_Constructor_With_parameters()
        {
            // arrage
            Point point = new Point(2.2, 3.4);

            // assert
            Assert.AreEqual(2.2, point.X);
            Assert.AreEqual(3.4, point.Y);
        }

        [TestMethod]
        public void Point_Property_X()
        {
            // arrage
            Point point = new Point();

            // act
            point.X = 2.2;

            // assert
            Assert.AreEqual(2.2, point.X);
        }

        [TestMethod]
        public void Point_Property_Y()
        {
            // arrage
            Point point = new Point();

            // act
            point.Y = 2.3;

            // assert
            Assert.AreEqual(2.3, point.Y);
        }

        [TestMethod]
        public void Point_Distance()
        {
            // arrage
            Point point = new Point(3, 4);

            // assert
            Assert.AreEqual(5.0, point.Distanse());
        }


        [TestMethod]
        public void Point_MoveByVector()
        {
            // arrage
            Point point = new Point(3, 4);

            // act
            point.MoveByVector(2.2, 3.3);

            // assert
            Assert.AreEqual(point.X, 5.2);
            Assert.AreEqual(point.Y, 7.3);
        }

        [TestMethod]
        public void Point_Scalar()
        {
            // arrage
            Point point = new Point(3, 4);

            // act
            point.Scalar = 3.0;

            // assert
            Assert.AreEqual(point.X, 9.0);
            Assert.AreEqual(point.Y, 12.0);
        }

        [TestMethod]
        public void Point_GetInfo()
        {
            // arrage 
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Point point = new Point(3, 4);

            // act
            point.GetInfo();

            // assert
            Assert.AreEqual("x=3, y=4\r\n", sw.ToString());
        }
    }
}
