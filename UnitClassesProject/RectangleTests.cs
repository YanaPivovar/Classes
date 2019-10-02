using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;
using System.IO;

namespace UnitClassesProject
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Rectangle_Constructor_By_Default_Is_Not_Null()
        {
            //arrange
            Rectangle rectangle = new Rectangle();

            //assert
            Assert.IsNotNull(rectangle);
        }

        [TestMethod]
        public void Rectangle_Custom_Constructor()
        {
            //arrange
            Rectangle rectangle = new Rectangle(2.0, 2.0, 2.0, 2.0);

            //assert
            Assert.AreEqual(2.0, rectangle.A);
            Assert.AreEqual(2.0, rectangle.B);
            Assert.AreEqual(2.0, rectangle.C);
            Assert.AreEqual(2.0, rectangle.D);
        }

        [TestMethod]
        public void Rectangle_Property_A()
        {
            // arrage
            Rectangle rectangle = new Rectangle(2.0, 2.0, 2.0, 2.0);

            // act 
            rectangle.A = 2.0;

            // assert
            Assert.AreEqual(2.0, rectangle.A);
        }
        [TestMethod]
        public void Rectangle_Property_B()
        {
            // arrage
            Rectangle rectangle = new Rectangle(2.0, 2.0, 2.0, 2.0);

            // act 
            rectangle.B = 2.0;

            // assert
            Assert.AreEqual(2.0, rectangle.B);
        }

        [TestMethod]
        public void Rectangle_Property_C()
        {
            // arrage
            Rectangle rectangle = new Rectangle(2.0, 2.0, 2.0, 2.0);

            // act 
            rectangle.C = 2.0;

            // assert
            Assert.AreEqual(2.0, rectangle.C);
        }
        [TestMethod]
        public void Rectangle_Property_D()
        {
            // arrage
            Rectangle rectangle = new Rectangle(2.0, 2.0, 2.0, 2.0);

            // act 
            rectangle.D = 2.0;

            // assert
            Assert.AreEqual(2.0, rectangle.D);
        }

        [TestMethod]
        public void Rectangle_GetInfo()
        {
            //arrage
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Rectangle rectangle = new Rectangle(2.0, 2.0, 2.0, 2.0);

            //act
            rectangle.GetInfo();

            //assert
            Assert.AreEqual("a=2, b=2, c=2, d=2\r\n", sw.ToString());
        }

        [TestMethod]
        public void Rectangle_GetPerimetr()
        {
            //arrage
           Rectangle rectangle = new Rectangle(2.0, 2.0, 2.0, 2.0);

            //act
            double perimetr = rectangle.Perimetr();

            //assert
            Assert.AreEqual(8.0, perimetr);
        }
        [TestMethod]
        public void Rectangle_GetArea()
        {
            //arrage
            Rectangle rectangle = new Rectangle(2.0, 2.0, 2.0, 2.0);

            //act
            double area = rectangle.Area();

            //assert
            Assert.AreEqual(4.0, area);
        }
        [TestMethod]
        public void Rectangle_IsSquare()
        {
            // arrage
            Rectangle rectangle = new Rectangle(3.0, 2.0, 2.0, 2.0);

            // act 
            bool isSquare = rectangle.IsSquare;

            // assert
            Assert.AreEqual(false, isSquare);
        }

    }
}


