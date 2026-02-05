/*using System;
using System.Security.Cryptography;


namespace ConsoleProject.AllConceptsPractice.Operator
{
    public class ValueTypeDemo
    {


        public static void Main(string[] args)
        {
            //value type, just copied the value,

            //int a = 10;
            //int b = a;
            //b = 20;
            //Console.WriteLine(a);
            //Console.WriteLine(b);




           *//* int b = 50;
            ValueMethod(ref b);
            Console.WriteLine(b);*/



            /*  int[] arr1 = { 1 };
              int[] arr2 = arr1;

              arr2[0] = 100;
              Console.WriteLine(arr1[0]);*//*




            //boxing
            *//*
                        int i = 10;

                        object obj = i;
                        Console.WriteLine(obj);*//*

            //unboxing

            *//* object obj1 = 100;


         /*public static void ValueMethod(ref int a )
         {
             a = 25;
         }*/

            /*            int[] arr1 = { 73, 3, 3, };
                        Method1( ref arr1);

                        Console.WriteLine(arr1[0]);

            */

/*
              int  _sum = 0;
            int _Multiply = 0;

            Methodd(19,20, out _sum, out _Multiply);
            Console.WriteLine($" sum is {_sum}  product is {_Multiply}")*//*;




            // main method ends here

            *//*
                    public static void Method1(ref int[] arr){
                        arr = new int[]{37,2,3,};*//*


            ParamsMethod(1,3,34,4,4,3,3,3,34,4,4);
            Console.WriteLine(" - ");
            ParamsMethod();
            Console.WriteLine(" - ");
            ParamsMethod(4,56,4);


        }


       *//* public static void Methodd(int num1, int num2, out int sum, out int multiply) {

            sum = num1 + num2;
            multiply = num1 * num2;

        }*//*



        public static void ParamsMethod(params int[] number)
        {
            foreach (int n in number) {

                Console.WriteLine(n);
            
            }


        }


    }
}




    

*/