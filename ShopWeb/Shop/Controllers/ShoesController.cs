using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers {
    public class ShoesController : Controller {

        private readonly IAllShoes _allShoes;
        private readonly IShoesCategory _allCategories;

        public ShoesController(IAllShoes iAllShoes, IShoesCategory iShoesCat) {
            _allShoes = iAllShoes;
            _allCategories = iShoesCat;
        }

        [Route("Shoes/List")]
        [Route("Shoes/List/{category}")]
        public ViewResult List(string category) {
            string _category = category;
            IEnumerable<Shoes> shoes = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category)) {
                shoes = _allShoes.Shoes.OrderBy(i => i.id);
            } else {
                if(string.Equals("nike", category, StringComparison.OrdinalIgnoreCase)) {
                    shoes = _allShoes.Shoes.Where(i => i.Category.categoryName.Equals("nike")).OrderBy(i => i.id);
                    currCategory = "nike";
                } else if (string.Equals("adidas", category, StringComparison.OrdinalIgnoreCase)) {
                    shoes = _allShoes.Shoes.Where(i => i.Category.categoryName.Equals("adidas")).OrderBy(i => i.id);
                    currCategory = "adidas";
                }
            }

            var shoeObj = new ShoesListViewModel
            {
                allShoes = shoes,
                currCategory = currCategory
            };

            ViewBag.Title = "Models that current exist";
            

            return View(shoeObj);
        }


    }
}
