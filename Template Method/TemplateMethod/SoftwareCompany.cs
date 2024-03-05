namespace TemplateMethod.Example1
{
    using System;

    public class SoftwareCompany : HiringProcess
    {
        public override void ConductInterview()
        {
            Console.WriteLine("Conducting technical interview.");
        }
        public override void ConductSkillTest()
        {
            Console.WriteLine("Conducting coding test.");
        }

        public override void IssueOffer()
        {
            Console.WriteLine("Issuing job offer.");
        }

        public override void ReceiveCV()
        {
            Console.WriteLine("Receiving CV for Software Company.");
        }
    }
}
