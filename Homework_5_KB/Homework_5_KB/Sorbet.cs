using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_KB
{
    class Sorbet : IceCream
    {
        public Sorbet(int price, string flavor) : base(price, flavor) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Sorbet: {Flavor}, {Price} PLN.");
        }
    }
}
