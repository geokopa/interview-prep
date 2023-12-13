# SOLID Principles 

>The SOLID principles are a set of five design principles that, when followed, can lead to more maintainable, flexible, and scalable software. Here's a brief overview of each SOLID principle along with design patterns that align with them:

## Single Responsibility Principle (SRP):

+ Principle: A class should have only one reason to change, meaning it should have only one responsibility.
+ Design Pattern: The Command Pattern can help achieve SRP by encapsulating a request as an object, allowing you to parameterize clients with queues, requests, and operations.

[ref file](SRP.cs)


## Open/Closed Principle (OCP):

+ Principle: Software entities (classes, modules, functions) should be open for extension but closed for modification. You should be able to add new functionality without altering existing code.
+ Design Pattern: The Strategy Pattern is aligned with OCP, allowing you to define a family of algorithms, encapsulate each one, and make them interchangeable without modifying the client code.

[ref file](OCP.cs)

## Liskov Substitution Principle (LSP):

+ Principle: Subtypes must be substitutable for their base types without altering the correctness of the program.
+ Design Pattern: The Template Method Pattern can be used to enforce a structure in derived classes, ensuring that they provide specific implementations without violating LSP.

[ref file](LSP.cs)


## Interface Segregation Principle (ISP):

+ Principle: A client should not be forced to implement interfaces it does not use, and classes should not be forced to depend on methods they do not use.
+ Design Pattern: The Adapter Pattern is aligned with ISP, as it allows a class to work with interfaces it expects, while the adapter handles the interface segregation and delegates to the actual implementation.

[ref file](ISP.cs)

## Dependency Inversion Principle (DIP):

+ Principle: High-level modules should not depend on low-level modules; both should depend on abstractions. Abstractions should not depend on details; details should depend on abstractions.
+ Design Pattern: The Dependency Injection (DI) Pattern is a common approach to follow DIP, where dependencies are injected into a class rather than created within the class. This helps inverting the dependency flow.

[ref file](DIP.cs)


In this example, we've applied SOLID principles and relevant design patterns:

+ SRP: Each class has a single responsibility.
+ OCP: The DocumentEditor class is open for extension but closed for modification, using the Strategy Pattern.
+ LSP: The DocumentProcessorBase class follows the Template Method Pattern, ensuring a common structure for derived classes.
+ ISP: The DocumentViewerAdapter follows the Adapter Pattern, allowing the client to work with the expected interface.
+ DIP: Dependencies are injected using the Dependency Injection (DI) pattern, with the IDocumentProcessorFactory interface.
These principles and patterns work together to create a flexible, maintainable, and extensible design for the document processing system.


## Additional Readings
https://refactoring.guru/design-patterns/catalog