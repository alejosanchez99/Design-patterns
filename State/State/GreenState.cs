namespace State.Example1
{
    using System;

    public class GreenState : IState
    {
        public void Handle(StateContext context)
        {
            Console.WriteLine("Green light - go!");
            context.State = new YellowState();
        }
    }
}
