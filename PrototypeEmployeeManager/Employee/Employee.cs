namespace PrototypeEmployeeManager.Employee
{
    internal abstract class Employee
    {
        public string? Name { get; set; }
        public string? Role { get; set; }
        public string? Department { get; set; }

        public abstract Employee Clone();

        public abstract void GetDetails();
    }
}
