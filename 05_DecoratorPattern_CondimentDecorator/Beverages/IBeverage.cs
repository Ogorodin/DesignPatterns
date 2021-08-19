namespace _05_DecoratorPattern_CondimentDecorator
{
    /*
     * This is the interface all Beverage classes have to implement
     */
    public interface IBeverage
    {
        public double GetCost();
        public string GetDescription();
    }
}
