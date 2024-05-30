namespace BuilderComputerBuilder.Builder
{
    internal abstract class ComputerBuilder
    {
        protected Computer Computer { get; private set; } = new Computer();

        public abstract void SetCPU();
        public abstract void SetGPU();
        public abstract void SetRAM();
        public abstract void SetStorage();
        public abstract void SetMonitor();
        public abstract void SetKeyboard();
        public abstract void SetMemory();

        public Computer GetComputer() => Computer;
    }
}
