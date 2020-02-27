using System;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HENLO Rostik!! Its me, MARIO!");
            var userInput = new UserInput();
            userInput.WaitForInput();
        }
    }
}
