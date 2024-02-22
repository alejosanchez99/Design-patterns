﻿namespace AbstractFactory.Example1.ConcreteClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac Button");
        }
    }
}