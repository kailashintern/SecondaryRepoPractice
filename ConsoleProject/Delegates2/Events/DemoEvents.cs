/*using ConsoleProject.Delegates2.Events;
using System;


namespace ConsoleProject.Delegates2.Events
{
    public class DemoEvents
    {
        public delegate void Notify();


        public event Notify EventHandler;

        public void Pay()
        {
            Console.WriteLine("payment successfull");

           *//* EventHandler?.Invoke();*//*

        }



    }
}

public class Sample1
{
    public void Sms()
    {
        Console.WriteLine("sms sent");
    }
}


public class Sample2 : Sample1
{

    public void Email()
    {
        Console.WriteLine("email sent");
    }

    public static void Main()
    {
        Sample2 s = new Sample2();
        DemoEvents d = new DemoEvents();

        d.EventHandler += s.Sms;
        d.EventHandler += s.Email;


        d.Pay();




    }


}
*/