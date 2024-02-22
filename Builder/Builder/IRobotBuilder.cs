namespace Builder.Example1
{
    /// <summary>
    /// Builder
    /// </summary>
    public interface IRobotBuilder
    {
        void BuildHead(string head);
        void BuildBody(string body);
        void BuildArms(string arms);
        void BuildLegs(string legs);

        Robot GetRobot();
    }
}
