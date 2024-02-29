namespace AbstractFactory.Example1
{
    public interface IThemeFactory
    {
        IButton CreateButton();
        IDropDown CreateDropDown();
        ITextBox CreateTextBox();
    }
}
