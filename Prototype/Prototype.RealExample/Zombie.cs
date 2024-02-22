namespace Prototype.RealExample
{
    using System;

    public class Zombie : Monster
    {
        public int Health { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"Zombie {this.Id} ({this.Name}) attacks with {this.Health} health points.");
        }
    }
}
