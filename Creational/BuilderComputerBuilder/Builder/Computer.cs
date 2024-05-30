namespace BuilderComputerBuilder.Builder
{
    internal class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string Monitor { get; set; }
        public string Keyboard { get; set; }
        public string Memory { get; set; }

        public void DisplaySpecs()
        {
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"GPU: {GPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Storage: {Storage}");
            Console.WriteLine($"Monitor: {Monitor}");
            Console.WriteLine($"Keyboard: {Keyboard}");
        }
    }
}
