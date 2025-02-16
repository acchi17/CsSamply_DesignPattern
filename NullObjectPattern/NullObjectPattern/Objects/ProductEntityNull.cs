namespace NullObjectPattern.Objects
{
    public class ProductEntityNull : IProductEntity
    {
        public int Id => -1;
        public string Name => "Unknown";
        public TimeSpan OperatingTime
        {
            get{ return TimeSpan.FromSeconds(0.0); }
        }
    }
}
