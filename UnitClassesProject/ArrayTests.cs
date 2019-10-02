using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Classes;

namespace UnitClassesProject
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void Array_Custom_Constructor()
        {
            // arrange
            int arraySize = 10;

            // act
            MyArray array = new MyArray(arraySize);

            // assert
            Assert.AreEqual(arraySize, array.Size);
        }

        [TestMethod]
        public void Array_Instance_With_Lenght10()
        {
            // arrange
            int[] ExpectedArray = new int [10];

            // act
            MyArray ma = new MyArray(10);

            // assert
            Assert.AreEqual(ExpectedArray.Length, ma._Array.Length);
        }
        [TestMethod]
        public void Array_Input_From_TheKeyboard()
        {
            // arrange
            int[] ExpectedArray = new int[10];

            // act
            MyArray ma = new MyArray(10);

            // assert
            Assert.AreEqual(ExpectedArray.Length, ma._Array.Length);
        }
    }
}

