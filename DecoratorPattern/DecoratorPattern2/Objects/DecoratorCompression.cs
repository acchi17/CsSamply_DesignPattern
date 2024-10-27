using System.ComponentModel;

namespace DecoratorPattern2.Objects
{
    public sealed class DecoratorCompression : Decorator
    {
        public DecoratorCompression(IMessage child) : base(child) { }

        public override IEnumerable<byte> GetBytes()
        {
            var result = new List<byte>();
            int index = 0;
            // Dummy compression >>
            foreach(var val in _child.GetBytes())
            {
                if ((index % 2) == 0)
                {
                    result.Add(val);
                }
                index++;
            }
            // <<
            return result;
        }
    }
}
