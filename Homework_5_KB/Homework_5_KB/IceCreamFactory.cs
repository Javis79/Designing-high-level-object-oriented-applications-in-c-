using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_KB
{
    class IceCreamFactory
    {
        private enum ProductionMode 
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        private ProductionMode currentMode;

        public void SetProductionMode(int i)
        {
            currentMode = (ProductionMode)i;
        }

        public IceCream SpecialOfTheDay()
        {
            switch (currentMode)
            {
                case ProductionMode.Monday:
                    return new Sorbet(7, "Mango");

                case ProductionMode.Tuesday:
                    return new CreamIceCream(10, "Vanilla", true, "Chocolate", true);

                case ProductionMode.Wednesday:
                    return new FruitIceCream(9, "Strawberry", false, "Raspberry");

                case ProductionMode.Thursday:
                    return new ItalianIceCream(8, "Chocolate", true, false);

                case ProductionMode.Friday:
                    return new CreamIceCream(11, "Caramel", false, "Toffee", false);

                case ProductionMode.Saturday:
                    return new FruitIceCream(9, "Lemon", true, "Peach");

                case ProductionMode.Sunday:
                    return new ItalianIceCream(10, "Cream", false, true);

                default:
                    return null;
            }
        }

    }
}
