using System;

namespace _03_StrategyPattern_PaymentSystem
{
    public class CardPayment : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("Pay with card");
        }
    }
}
