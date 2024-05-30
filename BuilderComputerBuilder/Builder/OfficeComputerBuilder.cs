namespace BuilderComputerBuilder.Builder
{
    internal class OfficeComputerBuilder : ComputerBuilder
    {
        public override void SetCPU()
        {
            Computer.CPU = "Intel Core i5-9400F";
        }

        public override void SetGPU()
        {
            Computer.GPU = "Integrated Graphics";
        }

        public override void SetRAM()
        {
            Computer.RAM = "8GB DDR4";
        }

        public override void SetStorage()
        {
            Computer.Storage = "256GB NVMe SSD";
        }

        public override void SetMonitor()
        {
            Computer.Monitor = "24-inch 1080p 60Hz";
        }

        public override void SetKeyboard()
        {
            Computer.Keyboard = "Standard Keyboard";
        }

        public override void SetMemory()
        {
            Computer.Memory = "8GB USB Flash Drive";
        }
    }
}
