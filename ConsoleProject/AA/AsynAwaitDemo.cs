using System;



namespace ConsoleProject.AA
{
    public class AsynAwaitDemo
    {

        static async Task method1()
        {

            Console.WriteLine("method 1 started");
            await Task.Delay(3000);
            Console.WriteLine("method 1 ended");
        }

        static void Method2()
        {
            Console.WriteLine("method2");
        }





        static async Task Main()
        {
            Console.WriteLine("main starts");
            await method1();
            Method2();


            Console.WriteLine("main ends");





            //  Thread t = new Thread();




           /* Console.WriteLine("asyn started");

            Console.WriteLine("third method");
            Thread.Sleep(3000);


            Console.WriteLine("async ended");


            Console.WriteLine();


            Console.WriteLine("started thread");
            Thread.Sleep(5000);
            Console.WriteLine("ended thread");*/




        }


    }
}
