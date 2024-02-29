namespace AbstractFactory.Example1.Factories
{
    using AbstractFactory.Example1.ConcreteClasses;

    internal class MacFactory : IThemeFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public IDropDown CreateDropDown()
        {
            return new MacDropDown();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }
}
