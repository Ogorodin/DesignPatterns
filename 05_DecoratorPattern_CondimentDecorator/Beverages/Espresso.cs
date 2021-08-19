namespace _05_DecoratorPattern_CondimentDecorator
{
    public class Espresso : IBeverage
    {
        private double _cost = 1.2;
        private string _description = "Espresso";

    
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
