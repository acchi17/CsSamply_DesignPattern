namespace SimpleFactoryPattern.Model
{
    internal sealed class DataFake : IData
    {
        public string GetData()
        {
            return "Fake data";
        }
    }
}
