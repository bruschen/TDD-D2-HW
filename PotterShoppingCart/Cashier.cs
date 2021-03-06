﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class Cashier
    {
        private List<CartModel> lsCartModel = new List<CartModel>();

        public Cashier(List<CartModel> lsCartModel)
        {
            this.lsCartModel = lsCartModel;
        }

        public int Check()
        {
            int price = 0;

            while (lsCartModel.Where(m=>m.Quantity>0).ToList().Count>0)
            {
                
                price += GetPriceWithDiscount();
            }

            return price;
        }

        private int GetPriceWithDiscount()
        {
            List<string> bookList = lsCartModel.Where(m => m.Quantity > 0)
                                     .Select(m => m.BookName).Distinct().ToList();

            //先算出價格
            int price = bookList.Count * GetDiscountPrice(bookList.Count);

            //扣掉已經計算過的書
            foreach (string item in bookList)
            {
                var book = lsCartModel.Where(m => m.BookName == item);

                foreach (CartModel orderBook in book)
                {
                    orderBook.Quantity -= 1;
                }

            }


            return price;
        }

        private int GetDiscountPrice(int bookCnt)
        {
            switch(bookCnt){
                case 2:
                    return 95;
                case 3: 
                    return 90;
                case 4:
                    return 80;
                case 5:
                    return 75;
                default:
                    return 100;
            };

        }
    }
}
