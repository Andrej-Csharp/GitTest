using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest
{
    class UserInput
    {
        public void WaitForInput()
        {
            Console.Write(">>> ");
            var str = Console.ReadLine();
            Console.WriteLine(str.ToUpper());
            //Console.WriteLine(key);
        }
    }
}
