namespace _03_StrategyPattern_PaymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentMethod paymentMethod = new CashPayment();
            Booking booking = new Booking(paymentMethod);
            booking.Pay();
        }
    }
}
