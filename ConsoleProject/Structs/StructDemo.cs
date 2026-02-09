/*using ConsoleProject.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Structs
{
    public struct StructDemo
    {

        private int id;
        private int age ;
        public int _id
        {
            get
            {
                return this.id;

            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("id cannot be zero");
                }
                this.id = value;
            }
        }
        public int Sample(int Iod)
        {
            return this.age = Iod;   
        }
    }
}
public struct Class2
{
    public static void Main()
    {
        StructDemo demo = new StructDemo();
        int result = demo._id = 17;
            Console.WriteLine(result);



int methodreturn = demo.Sample(24);
        Console.WriteLine(methodreturn);    

    }








}
*/