namespace TemplateMethod.Example1
{
    using System;

    public class Bank : HiringProcess
    {
        public override void ConductInterview()
        {
            Console.WriteLine("Conducting interview about banking knowledge.");
        }

        public override void IssueOffer()
        {
            Console.WriteLine("Issuing job offer.");
        }

        public override void ReceiveCV()
        {
            Console.WriteLine("Receiving CV for Bank.");
        }
    }
}
