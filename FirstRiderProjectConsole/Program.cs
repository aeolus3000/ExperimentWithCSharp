using System;

namespace FirstRiderProjectConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {                
            Console.Write("Hello What is your name: ");   
            String name = Console.ReadLine();
            Console.WriteLine("Your name is: " + name);
        }
    }
}