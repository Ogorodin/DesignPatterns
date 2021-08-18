namespace _03_StrategyPattern_PathFinderDemo
{
    /*
     *      This interface is the base of our route finding classes.
     *      It is used for creating the whole family of algorithms.
     *      Concrete classes implementing this interface are the
     *      members of the algorithm family.
     */
    public interface IRouteStrategy
    {
        public void CalculatePath(int pointA, int pointB);
    }
}
