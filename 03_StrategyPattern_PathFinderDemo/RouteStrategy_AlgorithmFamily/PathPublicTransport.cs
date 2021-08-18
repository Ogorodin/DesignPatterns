using System;

namespace _03_StrategyPattern_PathFinderDemo
{
    public class PathPublicTransport : IRouteStrategy
    {
        public void CalculatePath(int pointA, int pointB)
        {
            Console.WriteLine("Calculating path to the closest public transportation station.");
        }
    }
}
