using System;

namespace _03_StrategyPattern_PathFinderDemo
{
    public class PathWalking : IRouteStrategy
    {
        public void CalculatePath(int pointA, int pointB)
        {
            Console.WriteLine("Calculating walking path trough the allies.");
        }
    }
}
