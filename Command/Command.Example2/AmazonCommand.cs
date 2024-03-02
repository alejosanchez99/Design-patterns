namespace Command.Example2
{
    public class AmazonCommand : ICommand
    {
        private readonly SmartTV smartTV;

        public AmazonCommand(SmartTV smartTV)
        {
            this.smartTV = smartTV;
        }

        public void Execute()
        {
            this.smartTV.OpenAmazon();
        }
    }
}
