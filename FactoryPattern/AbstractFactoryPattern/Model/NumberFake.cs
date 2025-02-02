namespace AbstractFactoryPattern.Model
{
    internal sealed class NumberFake : INumber
    {
        public int GetNumber()
        {
            return 9999;
        }
    }
}
