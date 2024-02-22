﻿namespace AbstractFactory.Example1.ConcreteClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WinDropDown : IDropDown
    {
        public void Render()
        {
            Console.WriteLine("Rendering Win Drop Down");
        }
    }
}
