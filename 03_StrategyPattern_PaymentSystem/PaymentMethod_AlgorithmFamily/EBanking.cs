using System;

namespace _03_StrategyPattern_PaymentSystem
{
    public class EBanking : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("E-Banking payment.");
        }
    }
}
