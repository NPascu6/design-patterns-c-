# Design Patterns in C#

This repository contains C# implementations of various design patterns. Each pattern is implemented in a dedicated project with appropriate examples to illustrate its usage.

## Project Structure

The solution is organized into two main categories of design patterns: Behavioral, Creational, and Structural. Each pattern is demonstrated through a small, self-contained example.

### Behavioral Patterns

1. **Command Pattern**
   - [CommandPatternKitchen](./Behavioral/CommandPatternKitchen)
     - **Commands**
     - **Invoker**
     - **Receiver**
   - [CommandPatternRemoteTV](./Behavioral/CommandPatternRemoteTV)
   - [ObserverPatternMonitoringSystem](./Behavioral/ObserverPatternMonitoringSystem)
     - **Observer**
     - **ObserverInterface**
     - **Subject**
     - **SubjectInterface**
   - [ObserverPatternWeatherMonitoring](./Behavioral/ObserverPatternWeatherMonitoring)
   - [StrategyPatternPaymentSystem](./Behavioral/StrategyPatternPaymentSystem)
     - **Context**
     - **Strategy**
   - [StrategyPatternTaxCalculator](./Behavioral/StrategyPatternTaxCalculator)
   - [VisitorPatternOnlineShop](./Behavioral/VisitorPatternOnlineShop)
   - [VisitorPatternZoo](./Behavioral/VisitorPatternZoo)
     - **Elements**
     - **Visitor**

### Creational Patterns

1. **Abstract Factory Pattern**
   - [AbstractFactoryPaymentSystem](./Creational/AbstractFactoryPaymentSystem)
2. **Builder Pattern**
   - [BuilderComputerBuilder](./Creational/BuilderComputerBuilder)
3. **Factory Pattern**
   - [FactoryPaymentGateway](./Creational/FactoryPaymentGateway)
4. **Prototype Pattern**
   - [PrototypeEmployeeManager](./Creational/PrototypeEmployeeManager)
5. **Singleton Pattern**
   - [Singleton](./Creational/Singleton)

### Structural Patterns

1. **Composite Pattern**
   - [CompositeFileSystem](./Structural/CompositeFileSystem)
     - `Directory.cs`
     - `FileItem.cs`
     - `FileSystemItem.cs`
     - `Program.cs`
     - `CompositeFileSystem.csproj`
2. **Decorator Pattern**
   - [DecoratorPizza](./Structural/DecoratorPizza)
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

According to the Gang of Four definitions, the Command Design Pattern is used to encapsulate a request as an object (i.e., a command) and pass it to an invoker, wherein the invoker does not know how to serve the request but uses the encapsulated command to perform an action.

The Command Design Pattern is a Behavioral Design pattern that turns a request into a stand-alone object that contains all information about the request. This transformation allows you to parameterize methods with different requests, delay or queue a request’s execution, and support undoable operations. It’s useful in scenarios where you need to issue requests without knowing anything about the operation being requested or the receiver of the request.

### Observer Pattern

According to GoF, the Observer Design Pattern Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

This Design Pattern is widely used for implementing distributed event-handling systems where an object needs to notify other objects about its state changes without knowing who these objects are. In the Observer Design Pattern, an object (called a Subject) maintains a list of its dependents (called Observers). It notifies them automatically whenever any state changes by calling one of their methods. The Other names of this pattern are Producer/Consumer and Publish/Subscribe.

How Does the Observer Design Pattern Work?
The observer design pattern has two main components. They are as follows

Subject: They are also called Publishers. When a change occurs to a subject, it should notify all its Subscribers/Observers.
Observers: They are also called subscribers. They listen to the changes in the subjects.
Another name of the Observer is the Listener.

### Strategy Pattern

According to the Gang of Four Definitions, define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

The Strategy Design Pattern is a Behavioral Design Pattern that enables selecting an algorithm’s behavior at runtime. Instead of implementing a single algorithm directly, run-time instructions specify which of a family of algorithms to use. This pattern is ideal when you need to switch between different algorithms or actions in an object dynamically. That means the Strategy Design Pattern is used when we have multiple algorithms (solutions) for a specific task, and the client decides which algorithm to use at runtime. 

### Visitor Pattern

In the Visitor Design Pattern, we use a Visitor object that changes an element object’s executing algorithm. In this way, when the visitor varies, the execution algorithm of the element object can also vary. As per the Visitor Design Pattern, the element object has to accept the visitor object so that the visitor object handles the operation on the element object.

The Visitor Design Pattern should be used when you have distinct and unrelated operations to perform across a structure of objects (element objects). That means the Visitor Design is used to create and perform new operations on a set of objects without changing the object structure or classes.

### Abstract Factory Pattern

According to the Gang of Four Definition, The Abstract Factory Design Pattern provides a way to encapsulate a group of factories with a common theme without specifying their concrete classes.

Abstract means hiding some information, factory means which produces the products, and pattern means a design. So, the Abstract Factory Pattern is a software design pattern that provides a way to encapsulate a group of individual factories that have a common theme.

In simple words, we can say that the Abstract Factory is a super factory that creates other factories. This Abstract Factory is also called the Factory of Factories. That means the Abstract Factory design pattern provides an interface for creating families of related or dependent products but leaves the actual object creation to the concrete factory classes.

This pattern is useful when a system needs to be independent of how its products are created, composed, and represented. It’s about having a superclass with multiple subclasses and a factory method that returns an instance of one of these subclasses.

### Builder Pattern

According to GOF, the Builder Design Pattern builds a complex object using many simple objects and a step-by-step approach. The Process of constructing the complex object should be generic so that the same construction process can be used to create different representations of the same complex object.

The Builder Design Pattern is useful in C# when you need to create an object with many optional and required fields, especially if the object’s construction process is complex or if many representations of the object are possible. The key idea is to separate the construction of a complex object from its representation, allowing the same construction process to create different representations.

So, the Builder Design Pattern is all about separating the construction process from its representation. When the construction process of your object is very complex, only you need to use the Builder Design Pattern. 

### Factory Pattern

According to Gang of Four (GoF), “A factory is an object used for creating other objects. In technical terms, we can say that a factory is a class with a method. That method will create and return different objects based on the received input parameter“.

In simple words, if we have a superclass and n number of subclasses, and based on the data provided, if we have to create and return the object of one of the subclasses, then we need to use the Factory Design Pattern in C#.

In the Factory Design pattern, we create an object without exposing the Object Creation and Initialization logic to the client, and the client will refer to the newly created object using a common interface. The basic principle behind the Factory Design Pattern is that, at run time, we get an object of a similar type based on the parameter we pass. So, the client will get the appropriate object and consume the object without knowing how the object is created and initialized. 

### Prototype Pattern

According to the GoF Definition, the Prototype Design Pattern specifies the kind of objects to create using a prototypical instance and creates new objects by copying this prototype.

The Prototype Design Pattern in C# is a creational pattern used for creating objects by copying an existing object, known as the prototype. This pattern is particularly useful when the cost of creating an object is more expensive or complex than copying an existing object.

To simplify the above definition, we can say that the Prototype Design Pattern gives us a way to create new or cloned objects from the existing object of a class. That means it clones the existing object with its data into a new object. If we make any changes to the cloned object (i.e., new object), it does not affect the original object.

### Singleton Pattern

The Singleton pattern is a design pattern that restricts the instantiation of a class to one object and provides a way to access its object. This is useful when exactly one object is needed to coordinate actions across the system. That means we need to use the Singleton Design Pattern in C# to ensure that only one instance of a particular class will be created and provide simple global access to that instance for the entire application.

### Composite Pattern

According to the Gang of Four definitions, Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly. 

The Composite Design Pattern is a structural pattern that allows us to compose objects into tree structures to represent part-whole hierarchies. This pattern lets clients treat individual objects and compositions of objects uniformly. That means the client can access the individual objects or the composition of objects in a uniform manner. It’s useful for representing hierarchical structures such as file systems, UI components, or organizational structures.

### Decorator Pattern

The Decorator Design Pattern in C# allows us to dynamically add new functionalities to an existing object without altering or modifying its structure, and this design pattern acts as a wrapper to the existing class. That means the Decorator Design Pattern dynamically changes the functionality of an object at runtime without impacting the existing functionality of the object. In short, this design pattern adds additional functionalities to the object by wrapping it. A decorator is an object that adds features to another object.

## Contributing

Contributions are welcome! If you have an example of another design pattern or an improvement to an existing one, please submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
