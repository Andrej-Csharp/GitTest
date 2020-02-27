using System;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello John!! Its me, Luidgy!");
            var userInput = new UserInput();
            userInput.WaitForInput();
        }
    }
}
