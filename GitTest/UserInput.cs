using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest
{
    class UserInput
    {
        public void WaitForInput()
        {
            //1
            //2
            //3
            //4
            //Awesome feature to do here!
            //5
            Console.Write(">>> ");
            var str = Console.ReadLine();
            Console.WriteLine(str.ToUpper());
            //Console.WriteLine(key);
        }
    }
}
