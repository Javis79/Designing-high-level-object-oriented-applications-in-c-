# Medieval Castle Inhabitants – Polymorphism-Based Simulation

This project is a console application written in C# and serves as an educational example demonstrating the concept of polymorphism in object-oriented programming. The theme centers around simulating the behavior of inhabitants in a medieval castle: civilians and defenders (further divided into pikemen and crossbowmen).

## Key Concepts

- Polymorphism: All inhabitants share a common abstract base class `Inhabitant` and override its methods in their own way.
- Interfaces: Defenders implement the `IReady` interface, which provides the method `ReadyToFight()`.
- Dynamic dispatch: Lists of base class (`Inhabitant`) and interface type (`IReady`) are used to demonstrate polymorphic behavior during iteration.


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
   git clone https://github.com/Javis79/Designing-high-level-object-oriented-applications-in-c-.git
   ```
2. Open the solution in Visual Studio or any C#-compatible IDE.
3. Build and run the project.

## Example Output

```
Defenders:
This pikeman is ready to defend castle.
Crossbowman is ready for a strike.

List of all inhabitants:
This inhabitant is civilian.
Food supply required: 3
...

There are 7 inhabitants and they require 36 units of food.
```

## Learning Outcome

This project helps in understanding:
- How abstract classes and interfaces can be combined to model real-world behaviors.
- How method overriding allows each class to provide its specific implementation while being accessed through a base type.
- How to use lists of base class or interface types to execute methods polymorphically.

## Author

Created by Krystian Bajerski as part of a university assignment in the course:
Designing and creating high-level object-oriented applications
