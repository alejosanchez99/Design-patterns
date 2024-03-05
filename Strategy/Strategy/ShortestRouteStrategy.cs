namespace Strategy.Example1
{
    public class ShortestRouteStrategy : IRouteStrategy
    {
        public string CalculateRoute(string routeA, string routeB)
        {
            return "Shortest route calculated";
        }
    }
}
