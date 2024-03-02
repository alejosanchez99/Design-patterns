namespace Command.Example1
{
    public class Waiter
    {
        public void TakeCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
