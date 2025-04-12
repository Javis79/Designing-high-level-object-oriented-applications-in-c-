# Ice Cream Shop 

This project is a console application written in C# and created as part of an assignment for practicing **inheritance**, **composition**, and **factory patterns** in object-oriented programming. The program models different types of ice cream, their preparation methods, and simulates sales throughout the week using a vendor and a factory system.

## Class Hierarchy

```
IceCream
├── CreamIceCream
├── FruitIceCream
├── ItalianIceCream
└── Sorbet
```

## Class Descriptions

### IceCream
- Abstract base class for all ice cream types.
- Fields: `Price`, `Flavor`
- Method: `DisplayInfo()` – abstract method for printing details.

### CreamIceCream (inherits from IceCream)
- Fields: `InWaffle` (bool), `Topping` (string), `HasSprinkles` (bool)
- Method: `DisplayInfo()` – includes cream-specific toppings and extras.

### FruitIceCream (inherits from IceCream)
- Fields: `InWaffle` (bool), `Topping` (string)
- Method: `DisplayInfo()` – displays flavor, topping, and waffle option.

### ItalianIceCream (inherits from IceCream)
- Fields: `InWaffle` (bool), `HasSprinkles` (bool)
- Method: `DisplayInfo()` – displays basic details and topping info.

### Sorbet (inherits from IceCream)
- Method: `DisplayInfo()` – prints flavor and price only.

## Factory and Vendor

### IceCreamFactory
- Contains an internal `enum ProductionMode` with 7 days of the week.
- Method: `SetProductionMode(int)` – selects daily production mode.
- Method: `SpecialOfTheDay()` – returns a specific type of ice cream based on the current production mode.

### IceCreamVendor
- Composed with an `IceCreamFactory` object.
- Method: `OfferSpecialOfTheDay()` – prints the current special based on the factory’s setting.

## Program Behavior

The `Main()` method simulates:
- Creation and testing of individual ice cream objects.
- Factory method that returns different ice cream types based on the day of the week.
- Use of the `IceCreamVendor` class to serve multiple customers.
- A full week simulation where three customers are served per day, and the vendor offers the special of the day.

## Sample Output

```
Cream ice cream: cream, 13 PLN, with waffle, with sprinkles, with strawberry topping.
Fruit ice cream: orange, 10 PLN, with blueberry topping.
Sorbet: Raspberry, 9 PLN.
Cream ice cream: chocolate, 11 PLN, with waffle, with sprinkles.

Vanilla, 10 PLN, with waffle, with sprinkles, with chocolate topping.
Strawberry, 9 PLN, with raspberry topping.
...

=== Day 1 ===
Today's special:
Sorbet: Mango, 7 PLN.
Today's special:
Sorbet: Mango, 7 PLN.
Today's special:
Sorbet: Mango, 7 PLN.
...
```

## Author

Created by Krystian Bajerski as part of a university assignment in the course:  
**Designing and creating high-level object-oriented applications**
