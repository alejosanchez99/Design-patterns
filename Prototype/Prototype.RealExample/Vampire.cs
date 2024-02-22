namespace Prototype.RealExample
{
    using System;

    public class Vampire : Monster
    {
        public int Bloodlust { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"Vampire {this.Id} ({this.Name}) attacks with {this.Bloodlust} bloodlust points.");
        }
    }
}
