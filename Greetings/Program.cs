using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please enter a name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            Console.WriteLine("Press Enter to restart, or type 'exit' to close:");
            string command = Console.ReadLine();

            if (command.ToLower() == "exit")
            {
                break;
            }

            Console.Clear();
        }
    }
}
