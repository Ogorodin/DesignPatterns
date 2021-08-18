using System;

namespace _03_StrategyPattern_PaymentSystem
{
    public class CashPayment : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("Pay with cash");
        }
    }
}
