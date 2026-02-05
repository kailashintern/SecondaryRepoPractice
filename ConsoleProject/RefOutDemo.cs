/*using System;

namespace ConsoleProject
{
    public class RefOutDemo
    {
        public static void Main(string[] args)
        {
            *//* int a = 1;
             Console.WriteLine($" before  {a}");
             Method1(ref a);
             Console.WriteLine($" after  {a}");*//*

            int d ;
          //  Console.WriteLine("before"+d);
            MethouOut(out d);
            Console.WriteLine("after" + d);

        }
        static void Method1(ref int x)
        {
            x = 10;
        }


        static void MethouOut(out int c)
        {
            c = 200;
        }



    }
}*/