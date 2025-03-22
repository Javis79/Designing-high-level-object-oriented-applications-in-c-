using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe_1_KB
{
    internal class HogwartStudent : Wizard
    {
        protected string house {  get; set; }

        protected string pet { get; set; }

        public HogwartStudent() { }
        public HogwartStudent(string _name,int _age, string _wand, string _house, string _pet) : base(_name, _age, _wand)
        {
            house = _house;
            pet = _pet;
        }

        public void HogwartStudentInfo()
        {
            WizardInfo();
            Console.WriteLine("This Hogwart student lives in " + house + " house, has a " + pet + " as a pet " );
        }
    }
}
