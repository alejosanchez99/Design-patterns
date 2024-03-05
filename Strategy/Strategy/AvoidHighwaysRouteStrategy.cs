namespace Strategy.Example1
{
    public class AvoidHighwaysRouteStrategy : IRouteStrategy
    {
        public string CalculateRoute(string routeA, string routeB)
        {
            return "Route avoiding highways calculated";
        }
    }
}
