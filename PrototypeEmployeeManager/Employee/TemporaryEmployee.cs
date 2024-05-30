namespace PrototypeEmployeeManager.Employee
{
    internal class TemporaryEmployee : Employee
    {

        public int HourlyRate { get; set; }

        public override Employee Clone()
        {
            return (Employee)this.MemberwiseClone();
        }

        public void SetHourlyRate(int hourlyRate)
        {
            HourlyRate = hourlyRate;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Hourly Rate: {HourlyRate}");
        }
    }
}
