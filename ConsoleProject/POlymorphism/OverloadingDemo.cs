/*using System;
using System.IO.Pipes;


namespace ConsoleProject.POlymorphism
{
    public class OverloadingDemo
    {

        static void Main(string[] args)
        {
            OverloadingDemo o = new OverloadingDemo();
            o.Person("kailash");
            o.Person(3);
            o.Person("dhanush", 16);
        }

        public void Person(string name)
        {
            
            Console.WriteLine(name);
        }

        public void Person(int age)
        {
            Console.WriteLine(age);
        }

        public void Person(string name, int age)
        {
            Console.WriteLine($"name is : {name}  age is {age}");
        }
       



    }
}
*/