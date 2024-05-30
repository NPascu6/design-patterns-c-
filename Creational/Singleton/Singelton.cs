namespace Singleton
{
    internal sealed class Singelton
    {
        private static int _counter = 0;
        private static Singelton? _instance;
        private static readonly object _lock = new object();

        public static Singelton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance ??= new Singelton();
                    }
                    _instance = new Singelton();
                }

                return _instance;
            }
        }

        private Singelton()
        {
            _counter++;
            Console.WriteLine($"Counter value: {_counter}");
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
