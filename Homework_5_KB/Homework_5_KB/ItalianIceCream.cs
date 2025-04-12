using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_KB
{
    class ItalianIceCream : IceCream
    {
        protected bool InWaffle { get; set; }
        protected bool HasSprinkles { get; set; }

        public ItalianIceCream(int price, string flavor, bool inWaffle, bool hasSprinkles) : base(price, flavor)
        {
            InWaffle = inWaffle;
            HasSprinkles = hasSprinkles;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Cream ice cream: {Flavor}, {Price} PLN" + (InWaffle == true ? ", with waffle" : "") + (HasSprinkles == true ? ", with sprinkles" : "") + ".");
        }
    }
}
