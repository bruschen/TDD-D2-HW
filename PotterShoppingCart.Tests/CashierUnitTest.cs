using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PotterShoppingCart;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class CashierUnitTest
    {
        [TestMethod]
        public void CartOrder_第一集_1本_價格_100()
        {
            //Arrange
            List<CartModel> lsCartModel = new List<CartModel>(){
                new CartModel{BookName="HP1", Quantity=1}
            };

            var expected = 100;
            Cashier cashier = new Cashier(lsCartModel);

            //Act
            var actual = cashier.Check();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CartOrder_第一集_1本_第二集_1本_價格_190()
        {
            //Arrange
            List<CartModel> lsCartModel = new List<CartModel>(){
                new CartModel{BookName="HP1", Quantity=1},
                new CartModel{BookName="HP2", Quantity=1}
            };

            var expected = 190;
            Cashier cashier = new Cashier(lsCartModel);

            //Act
            var actual = cashier.Check();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CartOrder_第一集_1本_第二集_1本_第三集_1本_價格_270()
        {
            //Arrange
            List<CartModel> lsCartModel = new List<CartModel>(){
                new CartModel{BookName="HP1", Quantity=1},
                new CartModel{BookName="HP2", Quantity=1},
                new CartModel{BookName="HP3", Quantity=1}
            };

            var expected = 270;
            Cashier cashier = new Cashier(lsCartModel);

            //Act
            var actual = cashier.Check();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CartOrder_第一集_1本_第二集_1本_第三集_1本_第四集_1本_價格_320()
        {
            //Arrange
            List<CartModel> lsCartModel = new List<CartModel>(){
                new CartModel{BookName="HP1", Quantity=1},
                new CartModel{BookName="HP2", Quantity=1},
                new CartModel{BookName="HP3", Quantity=1},
                new CartModel{BookName="HP4", Quantity=1}
            };

            var expected = 320;
            Cashier cashier = new Cashier(lsCartModel);

            //Act
            var actual = cashier.Check();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CartOrder_第一集_1本_第二集_1本_第三集_1本_第四集_1本_第五集_1本_價格_375()
        {
            //Arrange
            List<CartModel> lsCartModel = new List<CartModel>(){
                new CartModel{BookName="HP1", Quantity=1},
                new CartModel{BookName="HP2", Quantity=1},
                new CartModel{BookName="HP3", Quantity=1},
                new CartModel{BookName="HP4", Quantity=1},
                new CartModel{BookName="HP5", Quantity=1},
            };

            var expected = 375;
            Cashier cashier = new Cashier(lsCartModel);

            //Act
            var actual = cashier.Check();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CartOrder_第一集_1本_第二集_1本_第三集_2本_價格_370()
        {
            //Arrange
            List<CartModel> lsCartModel = new List<CartModel>(){
                new CartModel{BookName="HP1", Quantity=1},
                new CartModel{BookName="HP2", Quantity=1},
                new CartModel{BookName="HP3", Quantity=2}
            };

            var expected = 370;
            Cashier cashier = new Cashier(lsCartModel);

            //Act
            var actual = cashier.Check();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CartOrder_第一集_1本_第二集_2本_第三集_2本_價格_460()
        {
            //Arrange
            List<CartModel> lsCartModel = new List<CartModel>(){
                new CartModel{BookName="HP1", Quantity=1},
                new CartModel{BookName="HP2", Quantity=2},
                new CartModel{BookName="HP3", Quantity=2}
            };

            var expected = 460;
            Cashier cashier = new Cashier(lsCartModel);

            //Act
            var actual = cashier.Check();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
