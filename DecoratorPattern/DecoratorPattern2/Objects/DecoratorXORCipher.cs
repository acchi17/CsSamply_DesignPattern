using System.ComponentModel;

namespace DecoratorPattern2.Objects
{
    public sealed class DecoratorXORCipher : Decorator
    {
        public DecoratorXORCipher(IMessage child) : base(child) { }

        public override IEnumerable<byte> GetBytes()
        {
            var result = new List<byte>();
            foreach(var val in _child.GetBytes())
            {
                result.Add(Convert.ToByte(val^123));
            }
            return result;
        }
    }
}
