/*using ConsoleProject.Delegates2.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Delegates2.Events
{
    public class Class1
    {



        public delegate void Simmpledelegate();


        public event Simmpledelegate Eventhandler;


        public void InvalidClick()
        {
            Console.WriteLine("Invalid button clicked");

            Eventhandler?.Invoke();

        }




    }
}


public class SubscriberClass1
{


    

    public void NotifySms()
    {
        Console.WriteLine("sms sent \"invalid credentials\"");
    }

    public void NotifyEmail() {
        Console.WriteLine("email sent \"invalid credentails\"");
            
            }
}


public class ExecuteClass : SubscriberClass1
{

    public static void Main()
    {
        ExecuteClass e = new ExecuteClass();
        Class1 c = new Class1();

        c.Eventhandler += e.NotifySms;
        c.Eventhandler += e.NotifyEmail;

        c.InvalidClick();

       



    }
}*/