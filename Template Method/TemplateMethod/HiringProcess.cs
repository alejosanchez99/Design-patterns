namespace TemplateMethod.Example1
{
    public abstract class HiringProcess
    {
        public void HireCandiate()
        {
            this.ReceiveCV();
            this.ConductInterview();
            this.ConductSkillTest();
            this.IssueOffer();
        }

        public abstract void ReceiveCV();
        public abstract void ConductInterview();
        public virtual void ConductSkillTest()
        {

        }
        public abstract void IssueOffer();
    }
}
