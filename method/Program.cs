// See https://aka.ms/new-console-template for more information
namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        string readData = Console.ReadLine();
        Greetings(readData);
    }

    public static void Greetings(string name)
    {
        Console.WriteLine($"Hello {name} i'm ChatBot nice to meet you");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(true);
        Console.WriteLine("GoodBye, have a nice day");
    }
}