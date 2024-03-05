namespace State.Example1
{
    public class StateContext
    {
        public IState State { get; set; }

        public StateContext()
        {
            this.State = new GreenState();
        }

        public void Request()
        {
            this.State.Handle(this);
        }
    }
}
