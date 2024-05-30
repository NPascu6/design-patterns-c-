using BuilderComputerBuilder.Builder;
using BuilderComputerBuilder.Director;

ComputerShop computerShop = new ComputerShop();
ComputerBuilder computerBuilder = new GamingComputerBuilder();
ComputerBuilder computerBuilder2 = new OfficeComputerBuilder();

computerShop.Construct(computerBuilder);
computerShop.Construct(computerBuilder2);
Computer computer = computerBuilder.GetComputer();
computer.DisplaySpecs();

Console.WriteLine();

computer = computerBuilder2.GetComputer();
computer.DisplaySpecs();

Console.ReadKey();