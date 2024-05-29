How to Implement Command Design Pattern in C#?
The Command design pattern encapsulates a request as an object, allowing users to parameterize clients with different requests,
queue requests, log the requests, and support undoable operations. It involves separating objects that issue commands from objects that perform the command.
Here’s a simple breakdown of the Command Design Pattern:

Command: This is an interface for executing an operation.
ConcreteCommand: This class extends the Command interface, implementing the Execute method by invoking the corresponding operation(s) on the Receiver object.
Receiver: This class knows how to perform the operations associated with carrying out a request. Any class may serve as a Receiver.
Invoker: This class asks the command to carry out the request.
Client: The client creates a ConcreteCommand object and sets its receiver.