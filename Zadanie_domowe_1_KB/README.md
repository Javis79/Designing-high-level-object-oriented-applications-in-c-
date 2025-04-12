# Magic World – Inheritance-Based Simulation

This project is a console application written in C# and created as the first homework assignment for practicing **inheritance** in object-oriented programming. The program models magical beings from the Harry Potter universe, including students, teachers, and Quidditch players at Hogwarts School of Witchcraft and Wizardry.

## Class Hierarchy

```
MagicBeing
├── Wizard
│   ├── HogwartStudent
│   │   └── QuidditchPlayer
│   └── HogwartTeacher
```

## Class Descriptions

### MagicBeing
- Base class for all magical characters.
- Fields: `name`, `age`
- Method: `PresentBeing()` – displays name and age.

### Wizard (inherits from MagicBeing)
- Adds field: `wand` – material used in wand core.
- Method: `WizardInfo()` – extends base info and displays wand core.

### HogwartStudent (inherits from Wizard)
- Adds fields: `house`, `pet`
- Method: `HogwartStudentInfo()` – includes student details.

### HogwartTeacher (inherits from Wizard)
- Adds field: `fieldOfStudy`
- Method: `HogwartTeacherInfo()` – shows subject taught.

### QuidditchPlayer (inherits from HogwartStudent)
- Adds fields: `role`, `broomstick`
- Method: `QuiddichPlayerInfo()` – shows team role and broomstick.

## Program Behavior

The `Main()` method creates various magical characters:
- A house elf (`MagicBeing`)
- A dark wizard (`Wizard`)
- A Hogwarts student and Quidditch player
- A Hogwarts professor

Each object calls its respective information method to display complete details, showcasing how **inheritance and method reuse** work in practice.

## Sample Output

```
This is Dobby who is 28 years old.
This wizard is wielding a wand which core is made with Phoenix feather.
This is Hermione Granger who is 19 years old.
This wizard is wielding a wand which core is made with Dragon heart-string.
This Hogwart student lives in Gryffindor house, has a cat as a pet
Professor Minerva McGonagall is teaching students about Transfiguration.
This is Harry Potter who is 19 years old.
This wizard is wielding a wand which core is made with Phoenix feather.
This Hogwart student lives in Gryffindor house, has a owl as a pet
This quiddich player plays as a seeker for Gryffindor house team and is riding on Nimbus 2000 broomstick.
```
## Author

Created by Krystian Bajerski as part of a university assignment in the course:
Designing and creating high-level object-oriented applications
