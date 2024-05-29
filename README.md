# Design Patterns in C#

This repository contains C# implementations of various design patterns. Each pattern is implemented in a dedicated project with appropriate examples to illustrate its usage.

## Project Structure

The solution is organized into two main categories of design patterns: Behavioral and Structural. Each pattern is demonstrated through a small, self-contained example.

### Behavioral Patterns

1. **Command Pattern**
   - **CommandPatternKitchen**
     - **Commands**
     - **Invoker**
     - **Receiver**
   - **ObserverPatternMonitoringSystem**
     - **Observer**
     - **ObserverInterface**
     - **Subject**
     - **SubjectInterface**
   - **StrategyPatternPaymentSystem**
     - **Context**
     - **Strategy**
   - **VisitorPatternZoo**
     - **Elements**
     - **Visitor**

### Structural Patterns

1. **Composite Pattern**
   - **CompositeFileSystem**
     - `Directory.cs`
     - `FileItem.cs`
     - `FileSystemItem.cs`
     - `Program.cs`
     - `CompositeFileSystem.csproj`
2. **Decorator Pattern**
   - **DecoratorPizza**
     - `ChickenPizza.cs`
     - `Pizza.cs`
     - `PizzaDecorator.cs`
     - `VeggiePizza.cs`
     - `Program.cs`
     - `DecoratorPizza.csproj`

## How to Use

To run any of the examples, open the solution in Visual Studio, navigate to the project of interest, and execute it. Each project contains a `Program.cs` file which serves as the entry point, demonstrating the pattern in action.

## Design Patterns Explained

### Command Pattern

The Command Pattern encapsulates a request as an object, thereby allowing for parameterization of clients with queues, requests, and operations. In this solution, we demonstrate this pattern with examples like a Kitchen order system and a Remote TV controller.

### Observer Pattern

The Observer Pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. Examples include a Monitoring System and a Weather Monitoring System.

### Strategy Pattern

The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. The Strategy Pattern lets the algorithm vary independently from clients that use it. An example provided here is a Payment System with different tax calculators.

### Visitor Pattern

The Visitor Pattern represents an operation to be performed on elements of an object structure. It lets you define a new operation without changing the classes of the elements on which it operates. This pattern is illustrated with a Zoo example.

### Composite Pattern

The Composite Pattern composes objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly. This is demonstrated with a File System example.

### Decorator Pattern

The Decorator Pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality. In this repository, the example used is a Pizza ordering system where different types of pizzas can have different toppings (decorators).

## Contributing

Contributions are welcome! If you have an example of another design pattern or an improvement to an existing one, please submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

