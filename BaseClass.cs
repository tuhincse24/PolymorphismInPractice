namespace PolymorphismPractice
{
    class BaseClass
    {
        public virtual void DoSomeThing()
        {
        }
    }
    class ClassWithNew : BaseClass
    {
        public new void DoSomeThing()
        {
        }
    }
    class ClassWithOverride : BaseClass
    {
        public override void DoSomeThing()
        {
        }
    }
}
