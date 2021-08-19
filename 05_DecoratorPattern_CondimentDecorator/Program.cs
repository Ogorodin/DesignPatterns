using System;

namespace _05_DecoratorPattern_CondimentDecorator
{
    class Program
    {
        public static void Main()
        {
            IBeverage espresso = new Espresso();
            espresso = new Milk(new Cookie(new SoyMilk(espresso)));

            Console.WriteLine(espresso.GetCost());
            Console.WriteLine(espresso.GetDescription());


        }

    }
}
