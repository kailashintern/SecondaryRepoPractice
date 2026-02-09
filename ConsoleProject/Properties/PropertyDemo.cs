/*using System;
using System.ComponentModel;
using ConsoleProject.Properties;

namespace ConsoleProject.Properties
{
    public class PropertyDemo
    {

        private int _balance;
        private int _minimumBalance = 500;
        private string _name;


        public int getbalance()
        {
           return _balance;

        }
        public void setbalance(int balance)
        {
            if (balance <= 0)
            {
                throw new Exception("balance cant be zero");
            }
            else this._balance = balance;

        }


        public int getminmumBalance()
        {
            return this._minimumBalance;
        }
        public void setname(string name)
        {
            if (name == null)
            {
                throw new Exception("name cant be null");
            }
            else this._name = name;
        }

        public string getname()
        {
            return this._name;
        }
    }
}


public class PropertyDemo2 {

    public static void Main(string[] args)
    {

        PropertyDemo demo = new PropertyDemo();

        demo.setbalance(30000);
        Console.WriteLine(demo.getbalance());
        Console.WriteLine(demo.getminmumBalance());
        demo.setname(null);
        Console.WriteLine(demo.getname());
       
        
        


    }









}






*/