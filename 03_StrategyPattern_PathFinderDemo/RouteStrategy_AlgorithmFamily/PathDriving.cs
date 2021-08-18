using System;

namespace _03_StrategyPattern_PathFinderDemo
{
    public class PathDriving : IRouteStrategy
    {
        public void CalculatePath(int pointA, int pointB)
        {
            Console.WriteLine("Calculating driving path using roads.");
        }
    }
}
