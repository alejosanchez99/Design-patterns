namespace AbstractFactory.Example1.Factories
{
    using AbstractFactory.Example1.ConcreteClasses;

    internal class WinFactory : IThemeFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public IDropDown CreateDropDown()
        {
            return new WinDropDown();
        }

        public ITextBox CreateTextBox()
        {
            return new WinTextBox();
        }
    }
}
