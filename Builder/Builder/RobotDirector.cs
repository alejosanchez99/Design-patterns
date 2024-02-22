namespace Builder.Example1
{
    /// <summary>
    /// Director
    /// </summary>
    public class RobotDirector
    {
        private readonly IRobotBuilder robotBuilder;

        public RobotDirector(IRobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }

        public void ConstructRobot()
        {
            this.robotBuilder.BuildHead("Round");
            this.robotBuilder.BuildBody("Metal");
            this.robotBuilder.BuildArms("Claws");
            this.robotBuilder.BuildLegs("Wheels");
        }
    }
}
