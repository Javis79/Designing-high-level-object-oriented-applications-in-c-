using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe_1_KB
{
    internal class HogwartTeacher : Wizard
    {
        protected string fieldOfStudy { get; set; }
        
        public HogwartTeacher() { }
        public HogwartTeacher(string _name, int _age, string _wand, string _fieldOfStudy) : base(_name, _age, _wand)
        {
            fieldOfStudy = _fieldOfStudy;
        }

        public void HogwartTeacherInfo()
        {
            WizardInfo();
            Console.WriteLine("Professor " + name + " is teaching students about " + fieldOfStudy + ".");
        }
    }
}
