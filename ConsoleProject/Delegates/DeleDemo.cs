/*using System;
using static ConsoleProject.Delegates.DeleDemo;


namespace ConsoleProject.Delegates
{
    public class DeleDemo
    {


        //to use delegate we neeed to create delegate 
        public delegate void DelegateCalculations(int value1 , int value2);


        public static void Add(int a , int b)
        {
            Console.WriteLine($" add value is :  {a + b}" );
    }

        public static void Subtract (int c,int d)
        {
            Console.WriteLine($"subtract value is : {c- d }");
        }
        

    
}


public class dele2 {
   
        public static void Main()
    {
        DelegateCalculations d = new DelegateCalculations(Subtract);
        
        d += Add;
       
        d(20, 10);

    }

   


}


*/