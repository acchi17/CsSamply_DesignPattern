namespace SimpleFactoryPattern.Model
{
    internal sealed class DataFromSql : IData
    {
        public string GetData()
        {
            return "Data from sql";
        }
    }
}
