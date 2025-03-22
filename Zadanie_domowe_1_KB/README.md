# Harry Potter – Inheritance

This project is a console application created as the first homework assignment for practicing **inheritance** in object-oriented programming. The program models magical beings from the Harry Potter universe, including students, teachers, and Quidditch players at Hogwarts School of Witchcraft and Wizardry.

## Assignment Theme

The main objective of this project is to demonstrate the concept of **inheritance** through a hierarchy of classes representing magical entities. Each derived class inherits properties and behaviors from more general base classes, while adding its own specific fields and methods.

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


## Technologies Used

- C# (.NET)
- Visual Studio / .NET CLI

## Author

Created by Krystian Bajerski as part of a university assignment in the course: Designing and creating high-level object-oriented applications (Homework 1)
