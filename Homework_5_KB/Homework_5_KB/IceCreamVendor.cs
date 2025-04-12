using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_KB
{
    class IceCreamVendor
    {
        private IceCreamFactory factory;
        
        public IceCreamVendor(IceCreamFactory factory)
        {
            this.factory = factory;
        }

        public void OfferSpecialOfTheDay()
        {
            IceCream special = factory.SpecialOfTheDay();
            Console.WriteLine("Today's special: ");
            special.DisplayInfo();
        }
    }
}
