namespace _03_StrategyPattern_PaymentSystem
{
    /*
     *  Base interface for creating the algorithm family.
     *  Every class implementing it will become a member
     *  of the algorithm family.
     */
    public interface IPaymentMethod
    {
        public void Pay();
    }
}
