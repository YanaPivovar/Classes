using System;
using System.IO;
using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitClassesProject
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void Money_Constructor_By_Default_Is_Not_Null()
        {
            //arrange
            Money money = new Money();

            //assert
            Assert.IsNotNull(money);
        }

        [TestMethod]
        public void Money_Custom_Constructor()
        {
            //arrange
            Money money = new Money(100, 10);

            //assert
            Assert.AreEqual(100, money.First);
            Assert.AreEqual(10, money.Second);

        }
        [TestMethod]
        public void Money_GetInfo()
        {
            //arrange
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Money money = new Money(100, 10);

            //act
            money.GetInfo();

            //assert
            Assert.AreEqual("rating=100, quantity=10\r\n", sw.ToString());

        }

        [TestMethod]
        public void Money_BuyGoods()
        {
            //arrange
            Money money = new Money(100, 10);

            //act
            bool enoughMoney = money.EnoughMoney();

            //assert
            Assert.AreEqual(true, enoughMoney);
        }

        [TestMethod]
        public void Money_QuantityBought()
        {
            //arrange
            Money money = new Money(100, 10);

            //assert
            Assert.AreEqual(50, money.QuantityBought());
        }

        [TestMethod]
        public void Money_Property_First()
        {
            // arrage
            Money money = new Money(100, 10);

            // act 
            money.First = 100;

            // assert
            Assert.AreEqual(100, money.First);
        }

        [TestMethod]
        public void Money_Property_Second()
        {
            // arrage
            Money money = new Money(100, 10);

            // act 
            money.Second = 100;

            // assert
            Assert.AreEqual(100, money.Second);
        }

        [TestMethod]
        public void Money_GetSumm()
        {
            // arrage
            Money money = new Money(100, 10);

            // assert
            Assert.AreEqual(1000, money.GetSumm);
        }
    }
}

