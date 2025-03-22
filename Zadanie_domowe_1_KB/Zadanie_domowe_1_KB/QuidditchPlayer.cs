using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe_1_KB
{
    class QuidditchPlayer : HogwartStudent
    {
        private string role {  get; set; }

        private string broomstick { get; set; }

        public QuidditchPlayer() { }

        public QuidditchPlayer(string _name, int _age, string _wand, string _house, string _pet, string _role, string _broomstick ) : base(_name, _age, _wand, _house, _pet) 
        {
            role = _role;
            broomstick = _broomstick;
        }

        public void QuiddichPlayerInfo()
        {
            HogwartStudentInfo();
            Console.WriteLine("This quiddich player plays as a " + role + " for " + house + " house team and is riding on " + broomstick + " broomstick.");
        }
    }
}
