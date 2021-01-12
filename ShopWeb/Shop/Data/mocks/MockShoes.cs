using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks {
    public class MockShoes : IAllShoes {

        private readonly IShoesCategory _categoryShoes = new MockCategory();

        public IEnumerable<Shoes> 
            s {
            get {
                return new List<Shoes> {
                    new Shoes {
                        name = "Tesla Model S",
                       shortDesc = "Such a lightstrike",
                       longDesc = "Comfortable for urban space",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryShoes.AllCategories.First()
                    },
                    new Shoes {
                        name = "Ford Fiesta",
                       shortDesc = "Such a lightstrike",
                        longDesc = "Comfortable for urban space",
                        img = "/img/fiesta.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryShoes.AllCategories.Last()
                    },
                    new Shoes {
                        name = "BMW M3",
                       shortDesc = "Such a lightstrike",
                            longDesc = "Comfortable for urban space",
                        img = "/img/m3.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryShoes.AllCategories.Last()
                    },
                    new Shoes {
                        name = "Mercedes C class",
                       shortDesc = "Such a lightstrike",
                            longDesc = "Comfortable for urban space",
                        img = "/img/mercedes.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryShoes.AllCategories.Last()
                    },
                    new Shoes {
                        name = "Nissan Leaf",
                        shortDesc = "Such a lightstrike",
                            longDesc = "Comfortable for urban space",
                        img = "/img/nissan.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryShoes.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Shoes> getFavShoes { get; set; }

        public IEnumerable<Shoes> Shoes => throw new NotImplementedException();

        public Shoes getObjectShoes(int shoesId)
        {
            throw new NotImplementedException();
        }
    }
}
