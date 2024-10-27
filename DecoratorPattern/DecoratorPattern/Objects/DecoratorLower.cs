namespace DecoratorPattern1.Objects
{
    public sealed class DecoratorLower : Decorator
    {
        public DecoratorLower(IComponent child) : base(child) { }

        public override string GetData()
        {
            return _child.GetData().ToLower();
        }
    }
}
