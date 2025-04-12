using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_KB
{
    class CreamIceCream : IceCream
    {
        protected bool InWaffle {  get; set; }
        protected string Topping { get; set; }
        protected bool HasSprinkles { get; set; }

        public CreamIceCream(int price, string flavor, bool inWaffle, string topping, bool hasSprinkles) : base(price, flavor)
        {
            InWaffle = inWaffle;
            Topping = topping;
            HasSprinkles = hasSprinkles;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Cream ice cream: {Flavor}, {Price} PLN" + (InWaffle == true ? ", with waffle" : "") + (HasSprinkles == true ? ", with sprinkles" : "") + (Topping == "" ? "." : $", with {Topping} topping" + "."));
        }
    }
}
