namespace Builder.FastFoodChain
{
    using System;

    public class Burger
    {
        public string Bread { get; set; }
        public string Cheese { get; set; }
        public bool Lettuce { get; set; }
        public string Meat { get; set; }
        public string Dressing { get; set; }
        public bool Tomato { get; set; }


        public void DisplayInformation()
        {
            Console.WriteLine($"Bread: {this.Bread}");
            Console.WriteLine($"Meat: {this.Meat}");
            Console.WriteLine($"Cheese: {this.Cheese}");
            Console.WriteLine($"Lettuce: {this.Lettuce}");
            Console.WriteLine($"Dressing: {this.Dressing}");
            Console.WriteLine($"Tomatoe: {this.Tomato}");
        }
    }
}
