using System;
using System.Collections.Generic;

namespace Homework_5_KB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test of 4 classes
            List <IceCream> iceCreams = new List <IceCream> ();
            IceCream sorbet = new Sorbet(9, "Raspberry");
            IceCream italian = new ItalianIceCream(11, "chocolate", true, true);
            IceCream cream = new CreamIceCream(13, "cream", true, "strawberry", true);
            IceCream fruit = new FruitIceCream(10, "orange", false, "blueberry");
            iceCreams.Add(cream);
            iceCreams.Add(fruit);
            iceCreams.Add(sorbet);
            iceCreams.Add(italian);
            foreach (IceCream ice in iceCreams) 
            {
                ice.DisplayInfo();
            }

            //Test of fabric method
            Console.WriteLine();
            IceCreamFactory iceCreamFactory = new IceCreamFactory();
            for (int i = 0; i < 7; i++)
            {
                iceCreamFactory.SetProductionMode(i);
                IceCream special = iceCreamFactory.SpecialOfTheDay();
                special.DisplayInfo();
            }

            //Tet of IceCreamVendor
            Console.WriteLine();
            IceCreamVendor iceCreamVendor = new IceCreamVendor(iceCreamFactory);
            for (int i = 0; i < 7; i++)
            {
                iceCreamFactory.SetProductionMode(i);
                iceCreamVendor.OfferSpecialOfTheDay();
                iceCreamVendor.OfferSpecialOfTheDay();
                iceCreamVendor.OfferSpecialOfTheDay();
            }

            //Simulation of a week
            Console.WriteLine();
            IceCreamFactory icfactory = new IceCreamFactory();
            IceCreamVendor vendor = new IceCreamVendor(icfactory);

            for (int day = 0; day < 7; day++) 
            {
                icfactory.SetProductionMode(day);
                Console.WriteLine($"=== Day {day +1 } ===");

                for(int customer = 0; customer < 3; customer++)
                {
                    vendor.OfferSpecialOfTheDay();
                }
            }

        }
    }
}
