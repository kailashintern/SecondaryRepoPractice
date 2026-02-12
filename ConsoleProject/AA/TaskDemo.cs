/*using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.AA
{
    public class TaskDemo
    {

        public static async Task<int> CalciMethod(int a , int b)
        {
            await Task.Delay(3000);
            return a + b;
        }

       public static async Task Dummymethod()
        {
            await Task.Delay(1000);
            Console.WriteLine("dummy method");
        }


        static async Task Main()
        {
            Console.WriteLine("main method starts");
            int result=  await  CalciMethod(10, 10);
            Console.WriteLine($"total is : {result}");
            await Dummymethod();
            Console.WriteLine("main method ends");


            //Task<string> task = Task.Run(Method1);
        }
    }
}
*/