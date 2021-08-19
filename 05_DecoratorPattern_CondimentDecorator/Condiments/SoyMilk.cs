namespace _05_DecoratorPattern_CondimentDecorator
{
    public class SoyMilk : BasicCondimentDecorator
    {
        private double _cost = .45;
        private string _description = "Soy milk";

        public SoyMilk(IBeverage beverage) : base(beverage) { }

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
