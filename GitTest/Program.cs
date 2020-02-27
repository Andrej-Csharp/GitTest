using System;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HENLO ANDREJ! Its me, MARIO!");
            var userInput = new UserInput();
            userInput.WaitForInput();
        }
    }
}
