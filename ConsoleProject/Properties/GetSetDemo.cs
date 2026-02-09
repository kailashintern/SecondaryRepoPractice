/*using ConsoleProject.Properties;
using System;


namespace ConsoleProject.Properties
{
    public class GetSetDemo
    {

        private int _Pin;


        public int Pin
        {
            get { return _Pin; }

            set
            {
               if(value <= 0 || value >= 9999)
                {
                    throw new Exception("follow the pin rules");
                }
                else
                {
                    _Pin = value;
                }


            }


        }
    }
}


public class Class2
{

    public static void Main()
    {

        GetSetDemo setDemo = new GetSetDemo();
        setDemo.Pin = 12345;

        Console.WriteLine(setDemo.Pin);
    }

  
}*/