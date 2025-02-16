namespace NullObjectPattern.Objects
{
    public static class ProductSqlServer
    {
        //private static List<ProductEntity> _products = new List<ProductEntity>();
        private static List<IProductEntity> _products = new List<IProductEntity>();

        static ProductSqlServer()
        {
            // Temporary implementation simulating SQL Server
            _products.Add(new ProductEntity(1, "P1000"));
            _products.Add(new ProductEntity(2, "P1100"));
            _products.Add(new ProductEntity(3, "P2000"));
        }

        //public static ProductEntity? GetProduct(int id)
        //{
        //    return _products.Find(x => x.Id == id); // The argument is  Predicate<T> delegate
        //}

        public static IProductEntity GetProduct(int id)
        {
            var res = _products.Find(x => x.Id == id); // The argument is  Predicate<T> delegate
            if (res == null)
            {
                res = new ProductEntityNull();
            }
            return res;
        }
    }
}
