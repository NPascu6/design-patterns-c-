using VisitorPatternZoo.cs.Elements;
using VisitorPatternZoo.cs.Visitor;

IAnimal lion = new Lion();
IAnimal monkey = new Monkey();
IAnimal bear = new Bear();
IAnimal giraffe = new Giraffe();

IVisitor caretaker = new Caretaker();
IVisitor zooVisitor = new ZooVisitor();
IVisitor animalDoctor = new AnimalDoctor();

Console.WriteLine("\nCaretaker");
lion.Accept(caretaker);
monkey.Accept(caretaker);
bear.Accept(caretaker);
giraffe.Accept(caretaker);

Console.WriteLine("\nZoo Visitor");
lion.Accept(zooVisitor);
monkey.Accept(zooVisitor);
bear.Accept(zooVisitor);
giraffe.Accept(zooVisitor);

Console.WriteLine("\nAnimal Doctor");
lion.Accept(animalDoctor);
monkey.Accept(animalDoctor);
bear.Accept(animalDoctor);
giraffe.Accept(animalDoctor);

Console.ReadKey();
