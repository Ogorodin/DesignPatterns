namespace _05_DecoratorPattern_CondimentDecorator
{
    public class Cookie : BasicCondimentDecorator
    {
        private double _cost = .35;
        private string _description = "Cookie";
        public Cookie(IBeverage beverage) : base(beverage) { }

        public override double GetCost()
        {
            return base.GetCost() + _cost;
        }

        public override string GetDescription()
        {
            return $"{ base.GetDescription() }, { _description }";
        }
    }
}
