namespace DIP.Objects
{
    public static class Factories
    {
        private static bool _isDebug = false;
        public static IProduct CreateProduct()
        {
            if (_isDebug)
            {
                return new ProductDummy();
            }
            else
            {
                return new ProductSqlServer();
            } 
        }
    }
}
