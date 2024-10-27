
namespace DecoratorPattern2.Objects
{
    public sealed class MeasureMessage : IMessage
    {
        public int CommandId => 10;

        public int MeasureId { get; }

        public MeasureMessage(int measureId)
        {
            MeasureId = measureId;
        }
        public IEnumerable<byte> GetBytes()
        {
            var result = new List<byte>();
            result.AddRange(BitConverter.GetBytes(CommandId));
            result.AddRange(BitConverter.GetBytes(MeasureId));
            return result;
        }
    }
}
