# Composition vs Inheritance

> Composition and inheritance are two different approaches to structuring and organizing code in object-oriented programming. Let's discuss the differences and provide examples of when to use each:

## Inheritance:

### Definition:
> Inheritance is a mechanism that allows a new class (subclass or derived class) to inherit properties and behaviors from an existing class (base class or parent class).

### Example:
```csharp
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}
```

### Usage
+ Inheritance is suitable when a subclass shares a "is-a" relationship with the base class.
+ It promotes code reuse but can lead to issues like the diamond problem and can create tightly coupled code.

## Composition:

### Definition:

> Composition involves creating objects within a class and using these objects to implement the desired behavior.

### Example: 

```csharp
public class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine starting.");
    }
}

public class Car
{
    private Engine engine = new Engine();

    public void StartCar()
    {
        engine.Start();
        Console.WriteLine("Car is starting.");
    }
}
```

### Usage

+ Composition is suitable when a class has a "has-a" relationship with another class.
+ It allows for greater flexibility, easier maintenance, and avoids the issues associated with deep class hierarchies.

## When to Use Which:

### Composition:

+ Use composition when you want to build more flexible and maintainable systems.
+ Use when there is no clear "is-a" relationship between the classes.
+ Use when avoiding the limitations of multiple inheritance (diamond problem) is important.

### Inheritance:

Use inheritance when a true "is-a" relationship exists, and code reuse through the base class is appropriate.
Use when there is a clear and meaningful hierarchy, and polymorphism is essential.
Real-world Example:
Consider a scenario involving different types of vehicles.

### Inheritance:

If you have a hierarchy of vehicles such as Car, Motorcycle, and Truck, and they share common features like Start(), Stop(), and Drive(), you might use inheritance.
Composition:

If you have a class Car and want to give it the ability to start using an Engine, you might use composition. The Car class has an Engine object, and you delegate the Start() behavior to the Engine.

## General Guidelines:

### Prefer Composition Over Inheritance:

+ Composition tends to be more flexible and avoids the issues associated with deep class hierarchies.
+ It promotes the use of interfaces and smaller, more focused classes.

### Use Inheritance When Appropriate:

+ When a true "is-a" relationship exists and code reuse through a common base class is warranted.
+ When polymorphism is a key requirement.

+ ? In many cases, a combination of both composition and inheritance is used to create well-structured, modular, and maintainable code. The key is to choose the approach that best fits the specific relationship between classes in your application.




# Design Patterns:
## Decorator Pattern (Composition):

+ Composition is fundamental to the Decorator pattern, where you wrap an object with additional behaviors.
+ It's achieved by composing objects that implement the same interface.

## Strategy Pattern (Composition):

+ Composition is central to the Strategy pattern, where you define a family of algorithms and make them interchangeable.
+ Strategies are often implemented using composition.

## Factory Method Pattern (Inheritance):

+ The Factory Method pattern often involves creating objects by calling a factory method in a base class.
+ Subclasses provide concrete implementations via inheritance.

## Template Method Pattern (Inheritance):

+ In the Template Method pattern, a base class defines the skeleton of an algorithm with certain steps.
+ Subclasses provide concrete implementations for specific steps through inheritance.

# SOLID Principles:

## Single Responsibility Principle (SRP):

Composition aligns with SRP by allowing classes to have a single responsibility, relying on other components for additional functionality.

## Open/Closed Principle (OCP):

Both inheritance and composition can support OCP. Inheritance can be closed for modification by extending behavior, and composition allows adding new components without modifying existing ones.

## Liskov Substitution Principle (LSP):

Inheritance should adhere to LSP, ensuring that subclasses can be used interchangeably with their base classes.

## Interface Segregation Principle (ISP):

Composition aligns with ISP by allowing clients to use only the interfaces they are interested in, avoiding unnecessary dependencies.

## Dependency Inversion Principle (DIP):

Composition is essential for DIP, as it involves depending on abstractions (interfaces) rather than concrete implementations.

# Guidelines for Applying These Concepts:
## Favor Composition Over Inheritance (Composition):

+ Prefer composition when building flexible and modular systems.
+ Helps avoid the issues associated with deep class hierarchies.
+ Program to Interfaces, Not Implementations (Composition):

Composition is often associated with programming to interfaces, promoting flexibility and adherence to SOLID principles.

Use Inheritance for "Is-A" Relationships (Inheritance):

Inheritance is suitable for expressing "is-a" relationships when a subclass truly represents a specialization of its base class.
Combine Both for Synergy (Combined Usage):

Use a combination of inheritance and composition to create well-structured, maintainable systems that benefit from both approaches.