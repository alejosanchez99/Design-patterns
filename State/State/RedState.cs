namespace State.Example1
{
    using System;

    public class RedState : IState
    {
        public void Handle(StateContext context)
        {
            Console.WriteLine("Red light - Stop!");
            context.State = new GreenState();
        }
    }
}
