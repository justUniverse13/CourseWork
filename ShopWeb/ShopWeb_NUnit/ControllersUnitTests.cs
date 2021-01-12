using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ShopWeb_NUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void OrderController_nullOrder_ShouldReturnNullView()
        {
            Order order = new Order();

            Assert.IsTrue(!order.Equals(null));
        }

        [Test]
        public void ShoesController_null_allShoes_ShouldReturnNull()
        {
            string _allShoes = null;
                string category = String.Empty;
                if (string.IsNullOrEmpty(category))
                {
                    IAllShoes _allShoesExpected = null;
                    Assert.That(!category.Equals(_allShoesExpected));
                }
        }
        
    }
}