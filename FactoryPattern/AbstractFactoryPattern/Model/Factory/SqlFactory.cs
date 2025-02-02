namespace AbstractFactoryPattern.Model.Factory
{
    internal sealed class SqlFactory : AbstractFactory
    {
        public override IData CreateData()
        {
            return new DataFromSql();
        }
        public override INumber CreateNumber()
        {
            return new NumberFromSql();
        }
    }
}
