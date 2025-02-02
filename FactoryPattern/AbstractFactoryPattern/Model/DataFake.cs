namespace AbstractFactoryPattern.Model
{
    internal sealed class DataFake : IData
    {
        public string GetData()
        {
            return "Fake data";
        }
    }
}
