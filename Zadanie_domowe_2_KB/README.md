# Medieval Castle Inhabitants – Polymorphism

This project is a console application and serves as an educational example demonstrating the concept of polymorphism in object-oriented programming.

## Key Concepts

- Polymorphism: All inhabitants share a common abstract base class `Inhabitant` and override its methods in their own way.
- Interfaces: Defenders implement the `IReady` interface, which provides the method `ReadyToFight()`.

## Class Hierarchy

```
Inhabitant (abstract)
├── Civilian
└── Defender (abstract, implements IReady)
    ├── Pikeman
    └── Crossbowman
```

### Methods Overview

| Class        | Method(s)                                                                 |
|--------------|---------------------------------------------------------------------------|
| `Inhabitant` | `Eat()` – abstract                                                        |
| `Civilian`   | `Eat()` → returns 3 <br> `ToString()`                                     |
| `Defender`   | `Eat()` → base 5 (can be overridden) <br> `ReadyToFight()` (abstract)     |
| `Pikeman`    | `Eat()` → returns 7 <br> `ReadyToFight()` <br> `ToString()`               |
| `Crossbowman`| `Eat()` → returns 6 <br> `ReadyToFight()` <br> `ToString()`               |

## Running the Program

1. Clone the repository:
   ```bash
   git clone https://github.com/Javis79/Designing-and-creating-high-level-object-oriented-applications-in-c-.git
   ```
2. Open the solution in Visual Studio or any C#-compatible IDE.
3. Build and run the project.

## Learning Outcome

This project helps in understanding:
- How abstract classes and interfaces can be combined to model real-world behaviors.
- How method overriding allows each class to provide its specific implementation while being accessed through a base type.
- How to use lists of base class or interface types to execute methods polymorphically.

## Technologies Used

- C# (.NET Core / .NET Framework)
- Visual Studio / .NET CLI

## Author

Created by Krystian Bajerski as part of a university assignment in the course:
Designing and creating high-level object-oriented applications (Homework 2)
