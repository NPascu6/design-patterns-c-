namespace CommandPatternRemoteTV.Receiver
{
    internal class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV is off");
        }

        public void VolumeUp()
        {
            Console.WriteLine("Volume is up");
        }

        public void VolumeDown()
        {
            Console.WriteLine("Volume is down");
        }
    }
}
