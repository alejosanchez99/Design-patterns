namespace Command.Example2
{
    public class RemoteControl
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            this.command.Execute();
        }
    }
}
