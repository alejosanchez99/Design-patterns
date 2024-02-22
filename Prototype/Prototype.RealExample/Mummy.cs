namespace Prototype.RealExample
{
    using System;

    public class Mummy : Monster
    {
        public int Bandage { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"Mummy {this.Id} ({this.Name}) attacks with {this.Bandage} bandage points.");
        }
    }
}
