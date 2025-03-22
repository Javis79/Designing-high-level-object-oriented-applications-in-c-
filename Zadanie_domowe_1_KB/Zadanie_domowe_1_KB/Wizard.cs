using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe_1_KB
{
    internal class Wizard : MagicBeing
    {
        protected string wand;

        public Wizard() { }
        public Wizard(string _name, int _age, string _wand) : base(_name, _age) 
        { 
            wand = _wand; // contains the material from which the wand core is made 
        }

        public void WizardInfo()
        {
            PresentBeing();
            Console.WriteLine("This wizard is wielding a wand which core is made with " + wand + ".");
        }
    }
}
