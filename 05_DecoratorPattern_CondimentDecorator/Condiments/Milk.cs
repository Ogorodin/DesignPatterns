namespace _05_DecoratorPattern_CondimentDecorator
{
    public class Milk : BasicCondimentDecorator
    {
        private double _cost = .25;
        private string _description = "Milk";

        public Milk(IBeverage beverage) : base(beverage) { }

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
