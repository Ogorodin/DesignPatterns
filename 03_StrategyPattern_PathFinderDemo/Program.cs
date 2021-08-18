namespace _03_StrategyPattern_PathFinderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IRouteStrategy transportationType = new PathDriving();
            Navigator path = new Navigator(transportationType);

            path.CalculatePath(4, 9);
        }
    }
}
