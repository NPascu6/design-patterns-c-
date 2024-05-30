namespace PrototypeEmployeeManager.Employee
{
    internal class PermanentEmployee : Employee
    {
        public int Salary { get; set; }

        public override Employee Clone()
        {
            return (Employee)this.MemberwiseClone();
        }

        public void SetSalary(int salary)
        {
            Salary = salary;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
