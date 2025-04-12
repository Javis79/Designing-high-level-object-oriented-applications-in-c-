using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_KB
{
    class FruitIceCream : IceCream
    {
        protected bool InWaffle {  get; set; }
        protected string Topping { get; set; }
        public FruitIceCream(int price, string flavor, bool inWaffle, string topping) : base(price, flavor) 
        {
            InWaffle = inWaffle;
            Topping = topping;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Fruit ice cream: {Flavor}, {Price} PLN" + (InWaffle == true ? ", with waffle" : "") + (Topping == "" ? "." : $", with {Topping} topping" + "."));
        }
    }
}
