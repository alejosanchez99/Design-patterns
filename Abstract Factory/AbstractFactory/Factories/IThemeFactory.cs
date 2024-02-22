namespace AbstractFactory.Example1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IThemeFactory
    {
        IButton CreateButton();
        IDropDown CreateDropDown();
        ITextBox CreateTextBox();
    }
}
