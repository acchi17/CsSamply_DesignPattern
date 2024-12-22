namespace DIP.Objects
{
    public sealed class ProductSqlServer : IProduct
    {
        public string GetData()
        {
            // Connect to DB
            // Execute SQL
            return "Data from SQLServer2019";
        }
    }
}
