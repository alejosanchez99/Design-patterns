namespace Composite.Example1
{
    using System;

    public class AppFile : IFileSystemItem
    {
        private readonly string name;

        public AppFile(string name)
        {
            this.name = name;
        }

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent} - {this.GetType().Name} : {this.name}");
        }
    }
}
