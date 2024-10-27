namespace DecoratorPattern1.Objects
{
    public abstract class Decorator : IComponent
    {
        protected IComponent _child;

        public Decorator(IComponent child)
        {
            _child = child;
        }

        public abstract string GetData();
    }
}
