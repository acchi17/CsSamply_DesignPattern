namespace DecoratorPattern1.Objects
{
    public sealed class DecoratorUpper : Decorator
    {
        public DecoratorUpper(IComponent child) : base(child) { }

        public override string GetData()
        {
            return _child.GetData().ToUpper();
        }
    }
}
