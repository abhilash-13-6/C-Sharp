using System;

namespace PaymentSystem
{
    public interface IPayment
    {
        void MakePayment(double amount);
    }

    public class CreditCardPayment : IPayment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine(amount);
        }
    }

    public class PaypalPayment : IPayment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine(amount);
        }
    }

    public class UpiPayment : IPayment
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine(amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPayment creditCardPayment = new CreditCardPayment();
            IPayment paypalPayment = new PaypalPayment();
            IPayment upiPayment = new UpiPayment();

            double amount = 1800;

            Console.WriteLine("USING CREDIT CARD");
            creditCardPayment.MakePayment(amount);

            Console.WriteLine("USING PAYPAL");
            paypalPayment.MakePayment(amount);

            Console.WriteLine("USING UPI");
            upiPayment.MakePayment(amount);
        }
    }
}
