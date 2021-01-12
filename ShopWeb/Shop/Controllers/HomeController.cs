using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers {
    public class HomeController : Controller {

        private IAllShoes _shoesRep;

        public HomeController(IAllShoes shoeRep) {
            _shoesRep = shoeRep;
        }

        public ViewResult Index() {
            var homeShoes = new HomeViewModel {
                favShoes = _shoesRep.getFavShoes
            };
            return View(homeShoes);
        }

    }
}
