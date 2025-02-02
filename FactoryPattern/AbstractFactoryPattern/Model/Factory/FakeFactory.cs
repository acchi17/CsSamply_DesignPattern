namespace AbstractFactoryPattern.Model.Factory
{
    internal sealed class FakeFactory : AbstractFactory
    {
        public override IData CreateData()
        {
            return new DataFake();
        }
        public override INumber CreateNumber()
        {
            return new NumberFake();
        }
    }
}
