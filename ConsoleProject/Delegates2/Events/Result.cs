/*using ConsoleProject.Delegates2.Events;
using System;


namespace ConsoleProject.Delegates2.Events
{
    public  class Result
    {

        public delegate void Resultdele();


        public event Resultdele _result;


        public void Announce()
        {
            Console.WriteLine("result announced");

            _result?.Invoke();
        }

    }
}

public class Events1 : Result{ 

public static void Student1()
    {
        Console.WriteLine("1st student was passed with 80 marks");
    }

    public void Student2() {

        Console.WriteLine("2nd student was passed 60 marks");
    }

    public static void Main()
    {
        Events1 e = new Events1();
        

        e._result += Student1;
        e._result += e.Student2;

        e.Announce();






    }



}

*/