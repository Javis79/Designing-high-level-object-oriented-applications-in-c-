using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_KB
{
    abstract class IceCream
    {
        protected int Price { get; set; }
        protected string Flavor { get; set; }

        public IceCream(int price, string flavor)
        {
            Price = price;
            Flavor = flavor;
        }

        public abstract void DisplayInfo();

    }
}
