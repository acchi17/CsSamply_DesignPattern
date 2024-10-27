namespace DecoratorPattern2.Objects
{
    public abstract class Decorator : IMessage
    {
        protected IMessage _child;

        public Decorator(IMessage child)
        {
            _child = child;
        }

        public abstract IEnumerable<byte> GetBytes();
    }
}
