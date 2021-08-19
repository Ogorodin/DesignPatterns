namespace _05_DecoratorPattern_CondimentDecorator
{
    public class BasicCondimentDecorator : IBeverage
    {
        private IBeverage _beverage;

        public BasicCondimentDecorator(IBeverage beverage)
        {
            this._beverage = beverage;
        }
        public virtual double GetCost()
        {
            return _beverage.GetCost();
        }

        public virtual string GetDescription()
        {
            return _beverage.GetDescription();
        }
    }
}
