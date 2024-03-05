namespace State.Example1
{
    using System;

    public class YellowState : IState
    {
        public void Handle(StateContext context)
        {
            Console.WriteLine("Yellow light - prepare to stop!");
            context.State = new RedState();
        }
    }
}
