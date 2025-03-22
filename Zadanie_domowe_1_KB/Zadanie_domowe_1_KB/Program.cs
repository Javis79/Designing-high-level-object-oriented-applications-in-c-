using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe_1_KB
{

	class Program
	{
		static void Main(string[] args)
		{
			MagicBeing House_Elf = new MagicBeing("Dobby", 28);
			Wizard Voldemort = new Wizard("Voldemort", 71, "Phoenix feather");
			HogwartStudent Hermione_Granger = new HogwartStudent("Hermione Granger", 19, "Dragon heart-string", "Gryffindor", "cat");
			HogwartTeacher Minerva_McGonagall = new HogwartTeacher("Minerva McGonagall", 106, "Dragon heart-string", "Transfiguration");
			QuidditchPlayer Harry_Potter = new QuidditchPlayer("Harry Potter", 19, "Phoenix feather", "Gryffindor", "owl", "seeker", "Nimbus 2000");

			House_Elf.PresentBeing();
			Voldemort.WizardInfo();
			Hermione_Granger.HogwartStudentInfo();
			Minerva_McGonagall.HogwartTeacherInfo();
			Harry_Potter.QuiddichPlayerInfo();
		}
	}

}