namespace Builder.Example1
{
    using System;

    /// <summary>
    /// Product
    /// </summary>
    public class Robot
    {
        public string Head { get; set; }
        public string Body { get; set; }
        public string Arms { get; set; }
        public string Legs { get; set; }

        public void DisplayRobotInfo()
        {
            Console.WriteLine("Robot Info:");
            Console.WriteLine($"Head: {this.Head}");
            Console.WriteLine($"Body: {this.Body}");
            Console.WriteLine($"Arms: {this.Arms}");
            Console.WriteLine($"Legs: {this.Legs}");
        }
    }
}
