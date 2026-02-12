/*using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.AA
{
    public class ThreadDemo
    {

        public static void Method1()
        {
            Console.WriteLine("method 1 starts");
            Thread.Sleep(2000);
            Console.WriteLine("method 1 ends");
        }


        public static void Method2()
        {
            Console.WriteLine("method 2 starts");
            Console.WriteLine("method 2 ends");

        }



        static void Main()
        {
            Console.WriteLine("main method starts");
            Thread t = new Thread(Method1);
            t.Start();

            Method2();
            Console.WriteLine("main method ends");

        }
    }
}
*/