/*using System;


namespace ConsoleProject.Delegates2
{
    public class MultiCastDele
    {
        public delegate void Delegatedeclar();
        public static void Main()
        {
            MultiCastDele m = new MultiCastDele();
            Delegatedeclar d = new Delegatedeclar(m.SampleDele);  //method passing

            d += m.SecondMethod;
            d += m.ThirdMethod;
            d -= m.SecondMethod;
            d();


        }

        public void SampleDele()
        {
            Console.WriteLine("sample dele");
        }

        public void SecondMethod()
        {
            Console.WriteLine("second method");
        }

        public void ThirdMethod()
        {
            Console.WriteLine("third method");
        }



    }
}
*/