namespace Strategy.Example1
{
    public class Navigator
    {
        private IRouteStrategy strategy;

        public Navigator(IRouteStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IRouteStrategy strategy)
        {
            this.strategy = strategy;
        }

        public string ExecuteStrategy(string routeA, string routeB)
        {
            return this.strategy.CalculateRoute(routeA, routeB);
        }
    }
}
