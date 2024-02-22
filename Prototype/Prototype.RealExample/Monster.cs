namespace Prototype.RealExample
{
    public abstract class Monster : ICloneable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public abstract void Attack();

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
