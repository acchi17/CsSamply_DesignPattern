namespace NullObjectPattern.Objects
{
    public interface IProductEntity
    {
        int Id { get; }
        string Name { get; }
        TimeSpan OperatingTime { get; }
    }
}
