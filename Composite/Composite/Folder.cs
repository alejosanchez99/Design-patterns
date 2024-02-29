namespace Composite.Example1
{
    using System;
    using System.Collections.Generic;

    public class Folder : IFileSystemItem
    {
        private readonly string name;
        private readonly List<IFileSystemItem> items;

        public Folder(string name)
        {
            this.name = name;
            this.items = new List<IFileSystemItem>(0);
        }

        public void AddItem(IFileSystemItem item)
        {
            this.items.Add(item);
        }

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent} - {this.GetType().Name} : {this.name}");
            foreach (IFileSystemItem item in this.items)
            {
                item.Display(indent + " ");
            }
        }
    }
}
