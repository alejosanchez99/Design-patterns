namespace Command.Example2
{
    public class NetflixCommand : ICommand
    {
        private readonly SmartTV smartTV;

        public NetflixCommand(SmartTV smartTV)
        {
            this.smartTV = smartTV;
        }

        public void Execute()
        {
            this.smartTV.OpenNetflix();
        }
    }
}
