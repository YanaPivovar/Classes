using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;
using System.IO;
using System;

namespace UnitClassesProject
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Trinangle_Constructor_By_Defaut_is_not_null()
        {
            // arrage
            Triangle triangle = new Triangle();

            // assert
            Assert.IsNotNull(triangle);
        }

        [TestMethod]
        public void Trinangle_Custom_Constructor()
        {
            // arrage
            Triangle triangle = new Triangle(2.0, 3.0, 4.0);

            // assert
            Assert.AreEqual(2.0, triangle.A);
            Assert.AreEqual(3.0, triangle.B);
            Assert.AreEqual(4.0, triangle.C);
        }

        [TestMethod]
        public void Trinangle_Show_Side_Lengths()
        {
            // arrage
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Triangle triangle = new Triangle(2.0, 3.0, 4.0);

            // act 
            triangle.GetInfo();

            // assert
            Assert.AreEqual("a=2, b=3, c=4\r\n", sw.ToString());
        }

        [TestMethod]
        public void Trinangle_Perimetr()
        {
            // arrage
            Triangle triangle = new Triangle(2.0, 3.0, 4.0);

            // act 
            double perimetr = triangle.GetPerimetr();

            // assert
            Assert.AreEqual(9.0, perimetr);
        }

        [TestMethod]
        public void Trinangle_Area()
        {
            // arrage
            Triangle triangle = new Triangle(2.0, 3.0, 4.0);

            // act 
            double area = triangle.GetArea();

            // assert
            Assert.AreEqual(24.0, area);
        }

        [TestMethod]
        public void Trinangle_Property_A()
        {
            // arrage
            Triangle triangle = new Triangle(2.0, 3.0, 4.0);

            // act 
            triangle.A = 24;

            // assert
            Assert.AreEqual(24.0, triangle.A);
        }

        [TestMethod]
        public void Trinangle_Property_B()
        {
            // arrage
            Triangle triangle = new Triangle(2.0, 3.0, 4.0);

            // act 
            triangle.B = 24;

            // assert
            Assert.AreEqual(24.0, triangle.B);
        }

        [TestMethod]
        public void Trinangle_Property_C()
        {
            // arrage
            Triangle triangle = new Triangle(2.0, 3.0, 4.0);

            // act 
            triangle.C = 24;

            // assert
            Assert.AreEqual(24.0, triangle.C);
        }

        [TestMethod]
        public void Trinangle_Property_IsReal()
        {
            // arrage
            Triangle triangle = new Triangle(-2.0, 3.0, 4.0);

            // act 
            bool isReal = triangle.IsReal;

            // assert
            Assert.AreEqual(false, isReal);
        }
    }
}

