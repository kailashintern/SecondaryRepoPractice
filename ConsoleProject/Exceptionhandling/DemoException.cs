using System;
using System.IO;


namespace ConsoleProject.Exceptionhandling

    public class DemoException
    {
        static void Main()
        {

     String path = @"F:\Data.txt";
      string content = "writen from code";

     System.IO.File.WriteAllText(path, content);

      Console.WriteLine("file created");



    to read a file
    string path2 = "F:\\filess\\Dataa.txt";


    try
    {
        StreamReader r = new StreamReader(path2);
        try
        {
            string s = r.ReadToEnd();
            Console.WriteLine(s);
        }
        catch (Exception ex){



            r.Close();
        }



    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
    finally
    {

        if (r != null)
        {

        }

        Console.WriteLine("finally block executed");

    }
}


}
}


    /* public class InnerExceptio
     {

         public static void Main()
         {
             try
             {
                 Console.WriteLine("Enter first number");

                 int fn = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("Enter second Number");

                 int sn = Convert.ToInt32(Console.ReadLine());

                 int result = fn / sn;

                 Console.WriteLine(result);
             }
             catch (Exception ex)
             {
                 //Console.WriteLine(ex.Message);
                 string path = @"F:\files\exception.txt";

                 StreamWriter s = new StreamWriter(path);

                 s.Write(ex.GetType().Name);
                 s.Write(ex.Message);
                 s.Close();

                 Console.WriteLine("a problem occured");
             }

             finally
             {


                 Console.WriteLine("finally block");
             }

 */







    /*       }
       }
   }
   */






    //} 




    public class AgeInvalidException : Exception

    {

        public AgeInvalidException(string message) : base(message) { }




    }


    public class CustomException
    {



        static void Main()
        {
            int age = 0;

            try
            {
                Console.WriteLine("Enter your age : ");
                age = Convert.ToInt32(Console.ReadLine());
                AgeValidation(age);


            }
            catch (AgeInvalidException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                if (age > 18)
                {

                    Console.WriteLine("program executed successfully");
                }
                else
                {
                    Console.WriteLine("Exception handled");
                }
            }


        }


        public static void AgeValidation(int age)
        {
            if (age < 18)
            {
                throw new AgeInvalidException("age must be above 18");
            }



        }

    }
