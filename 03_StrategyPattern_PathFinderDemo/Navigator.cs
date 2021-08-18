namespace _03_StrategyPattern_PathFinderDemo
{
    /*
     *      This class is basically our interface for accessing different
     *      strategies we provide in the algorithm family. This basic form of it
     *      don't need to change even if we are adding new members to the
     *      injected behaviour (IRouteStrategy)
     */
    public class Navigator
    {
        private IRouteStrategy _strategy;

        public Navigator(IRouteStrategy strategy)
        {
            _strategy = strategy;
        }

        public void CalculatePath(int pointA, int pointB)
        {
            _strategy.CalculatePath(pointA, pointB);
        }
    }
}
