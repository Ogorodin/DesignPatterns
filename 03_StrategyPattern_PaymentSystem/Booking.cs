namespace _03_StrategyPattern_PaymentSystem
{
    public class Booking {

        private IPaymentMethod _paymentMethod;

        public Booking(IPaymentMethod paymentMethod)
        {
            this._paymentMethod = paymentMethod;
        }

        public void Pay()
        {
            _paymentMethod.Pay();
        }
    }
}
