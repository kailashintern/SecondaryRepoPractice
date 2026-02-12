/*using ConsoleProject.Collections;
using ConsoleProject.NewConstructor;
using System;


namespace ConsoleProject.Collections
{
    public class GenericsDemo
    {
        public static int ADD(int a, int b){

            return a + b;
            }

        public static bool Compare<W>(W x, W y)
        {
            return x.Equals(y);

        }


    }
}


public class Class2 {

    public static void Main()
    {


      int Total=  GenericsDemo.ADD(1,1);

       bool result = GenericsDemo.Compare<int>(5,10);


        Console.WriteLine($" add is {Total}  , Result is {result}");

      bool c1 =  GenericsDemo.Compare<string>("k","k");
        Console.WriteLine(" channged "+c1);



    }



}

*//*

using System.Collections;

public class Class3
{


    public static void Main()
    {

        *//*   object o = 10;
           int i = (int)o; // unboxing*/



        /* object[] a = new object[2];
         a[0] = 1;
         a[1] = "kjascnja";

         foreach (object o in a)
         {
             Console.WriteLine(o);
         }*/

        /* ArrayList arr = new ArrayList();

         arr.Add(1);
         arr.Add(10000);
         arr.Add("scsdc");
         arr.Add(23.44);*//*


        //arr.Insert(0,5);
        //arr.Remove(0);
        //bool exists =arr.Contains(1);
        //Console.WriteLine(exists);

        //Console.WriteLine(arr[0]);


        //hashtable - non generic

        *//* Hashtable h = new Hashtable();
         h.Add(1, "kailash");
         h.Add(0, "dummy");

         Console.WriteLine(h[0]);

         foreach(DictionaryEntry d in h)
         {
             Console.WriteLine(d.Key + "  " + d.Value);
         }
 */


        /*Stack s = new Stack();

        
        s.Push("kd");
        s.Push('c');
        s.Push(true);
        Console.WriteLine  (s.Pop());
        Console.WriteLine(s.Peek());

        Console.WriteLine(s.Count);*/


        /* Queue q = new Queue();

         q.Enqueue(1);
         q.Enqueue(2);

         q.Enqueue('b');


         Console.WriteLine(q.Dequeue());
         Console.WriteLine(q.Peek());*//*


        //generic

        //list, dictionary,stack,queue,hashset


        *//* List<int> l = new List<int>();

         l.Add(1);
         l.Add(2);
         l.Add(3);
         l.Add(4);
         l.Add(5);

         *//*l.RemoveAt(0);*//*
         // l.AddRange(32, 24, 31, 36);
         //Console.WriteLine(l.Contains(2));
         //Console.WriteLine(l.Count);
         //  Console.WriteLine("index 0 is : " +l[0]);
      // l.Clear();

         foreach (int i in l)
         {
             Console.WriteLine(i);
         }
 *//*


        //Dictionary

        *//* Dictionary<int, string> d = new Dictionary<int, string>();

         d.Add(1, "kk");
         d.Add(2,"dd");

         foreach(KeyValuePair <int,string> x in d)
         {
             Console.WriteLine(x.Key +"  " +  x.Value) ;

         }*//*

        //list & set
      *//*  List<int> l =  new List<int>{ 1, 1,2,4,4,5,7,8,99};

        HashSet<int> set = new HashSet<int>(l);

        foreach(var s in set)
        {
            Console.WriteLine(s);
        }*//*







    }
}

 



















*/