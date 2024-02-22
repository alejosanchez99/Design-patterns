namespace Builder.Example1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RobotBuilder : IRobotBuilder
    {
        private readonly Robot robot = new Robot();

        public void BuildArms(string arms)
        {
            robot.Arms = arms;
        }

        public void BuildBody(string body)
        {
            robot.Body = body;
        }

        public void BuildHead(string head)
        {
            robot.Head = head;
        }

        public void BuildLegs(string legs)
        {
            robot.Legs = legs;
        }

        public Robot GetRobot()
        {
            return robot;
        }
    }
}
