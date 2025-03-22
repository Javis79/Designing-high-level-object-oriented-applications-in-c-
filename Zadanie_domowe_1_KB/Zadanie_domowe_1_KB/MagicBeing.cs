using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe_1_KB
{
    internal class MagicBeing
    {
        protected string name {  get; set; }
        protected int age { get; set; }

        public MagicBeing() { }
        public MagicBeing(string _name, int _age)
        {
            name = _name;
            age = _age;
        }

        public void PresentBeing()
        {
            Console.WriteLine("\nThis is " + name + " who is " + age + " years old.");
        }
    }
}
