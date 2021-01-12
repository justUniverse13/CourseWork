using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces {
    public interface IAllShoes {

        IEnumerable<Shoes> Shoes { get; }
        IEnumerable<Shoes> getFavShoes { get; }
        Shoes getObjectShoes(int shoesId);

    }
}
