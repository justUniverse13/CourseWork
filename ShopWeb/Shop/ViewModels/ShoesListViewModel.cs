﻿using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels {
    public class ShoesListViewModel {

        public IEnumerable<Shoes> allShoes { get; set; }

        public string currCategory { get; set; }

    }
}
