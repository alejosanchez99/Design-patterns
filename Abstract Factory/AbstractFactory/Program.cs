
using AbstractFactory.Example1;
using AbstractFactory.Example1.Factories;

IThemeFactory themeFactory = new WinFactory();

IButton button = themeFactory.CreateButton();
button.Render();

IDropDown dropDown = themeFactory.CreateDropDown();
dropDown.Render();

ITextBox textBox = themeFactory.CreateTextBox();
textBox.Render();