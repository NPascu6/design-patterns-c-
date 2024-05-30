
using PrototypeEmployeeManager.Employee;

Employee employee1 = new PermanentEmployee
{
    Name = "John Doe",
    Role = "Software Developer",
    Department = "Engineering",
    Salary = 100000
};

Employee employee2 = employee1.Clone();
employee2.Name = "Jane Doe";
employee2.Department = "Human Resources";


employee1.GetDetails();
employee2.GetDetails();

Employee employee3 = new TemporaryEmployee
{
    Name = "Alice",
    Role = "Intern",
    Department = "Engineering",
    HourlyRate = 20
};

Employee employee4 = employee3.Clone();
employee4.Name = "Bob";
employee4.Department = "Human Resources";

employee3.GetDetails();
employee4.GetDetails();

Console.ReadKey();