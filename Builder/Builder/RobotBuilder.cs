namespace Builder.Example1
{
    public class RobotBuilder : IRobotBuilder
    {
        private readonly Robot robot = new Robot();

        public void BuildArms(string arms)
        {
            this.robot.Arms = arms;
        }

        public void BuildBody(string body)
        {
            this.robot.Body = body;
        }

        public void BuildHead(string head)
        {
            this.robot.Head = head;
        }

        public void BuildLegs(string legs)
        {
            this.robot.Legs = legs;
        }

        public Robot GetRobot()
        {
            return this.robot;
        }
    }
}
