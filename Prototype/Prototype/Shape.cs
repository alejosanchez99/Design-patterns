namespace Prototype.Example1
{
    public abstract class Shape : ICloneable
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public abstract void Draw();

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
