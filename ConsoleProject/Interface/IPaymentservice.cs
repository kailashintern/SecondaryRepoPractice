using ConsoleProject.Interface;
using System;


namespace ConsoleProject.Interface
{
    public interface IPaymentservice
    {
        bool PaymentMethod(decimal amount );




    }
}


public class Card : IPaymentservice
{
    public bool PaymentMethod(decimal amount)
    {
        Console.WriteLine($"payment from card {amount}");
        return true;

    }

    public static void Main()
    {
        Card card = new Card();
        card.PaymentMethod(5.00m);
    }
}
