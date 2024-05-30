namespace BuilderComputerBuilder.Builder
{
    internal class GamingComputerBuilder : ComputerBuilder
    {
        public override void SetCPU()
        {
            Computer.CPU = "Intel Core i9-9900K";
        }

        public override void SetGPU()
        {
            Computer.GPU = "Nvidia RTX 2080 Ti";
        }

        public override void SetRAM()
        {
            Computer.RAM = "32GB DDR4";
        }

        public override void SetStorage()
        {
            Computer.Storage = "1TB NVMe SSD";
        }

        public override void SetMonitor()
        {
            Computer.Monitor = "27-inch 1440p 144Hz";
        }

        public override void SetKeyboard()
        {
            Computer.Keyboard = "Mechanical RGB Keyboard";
        }

        public override void SetMemory()
        {
            Computer.Memory = "16GB USB Flash Drive";
        }
    }
}
