using Singleton;

Singelton singleton1 = Singelton.Instance;
Singelton singleton2 = Singelton.Instance;


if (singleton1 == singleton2)
{
    Console.WriteLine("Objects are the same instance");
}
else
{
    Console.WriteLine("Objects are different instances");
}

singleton1.PrintDetails("From singleton1");
singleton2.PrintDetails("From singleton2");

if (singleton1 == singleton2)
{
    Console.WriteLine("Objects are the same instance");
}
else
{
    Console.WriteLine("Objects are different instances");
}

Console.ReadKey();