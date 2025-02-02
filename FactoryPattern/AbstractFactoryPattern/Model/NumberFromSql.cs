namespace AbstractFactoryPattern.Model
{
    internal sealed class NumberFromSql : INumber
    {
        public int GetNumber()
        {
            return 101;
        }
    }
}
