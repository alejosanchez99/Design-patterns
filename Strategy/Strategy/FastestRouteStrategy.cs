namespace Strategy.Example1
{
    public class FastestRouteStrategy : IRouteStrategy
    {
        public string CalculateRoute(string routeA, string routeB)
        {
            return "Fastest route calculated";
        }
    }
}
