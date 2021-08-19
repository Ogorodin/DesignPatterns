namespace _05_DecoratorPattern_CondimentDecorator
{
    public class HouseBlend : IBeverage
    {
        private double _cost = .8;
        private string _description = "House Blend";
        public double GetCost()
        {
            return _cost;
        }

        public string GetDescription()
        {
            return _description;
        }
    }
}
