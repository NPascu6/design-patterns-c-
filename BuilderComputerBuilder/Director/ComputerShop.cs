using BuilderComputerBuilder.Builder;

namespace BuilderComputerBuilder.Director
{
    internal class ComputerShop
    {
        public void Construct(ComputerBuilder computerBuilder)
        {
            computerBuilder.SetCPU();
            computerBuilder.SetGPU();
            computerBuilder.SetRAM();
            computerBuilder.SetStorage();
            computerBuilder.SetMonitor();
            computerBuilder.SetKeyboard();
            computerBuilder.SetMemory();
        }
    }
}
