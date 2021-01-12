using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks {
    public class MockCategory : IShoesCategory {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category { categoryName = "Electro", desc = "Modern transport" },
                    new Category { categoryName = "Classic", desc = "Motors Cars" }
                };
            }
        }
    }
}
