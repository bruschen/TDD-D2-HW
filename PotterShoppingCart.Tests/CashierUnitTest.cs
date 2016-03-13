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
        public void CartOrder_第一集_1本()
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
        public void CartOrder_第一集_1本_第二集_1本()
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
    }
}
