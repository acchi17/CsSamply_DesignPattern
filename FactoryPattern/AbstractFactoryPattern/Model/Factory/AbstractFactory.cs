namespace AbstractFactoryPattern.Model.Factory
{
    public abstract class AbstractFactory
    {
        public abstract IData CreateData();
        public abstract INumber CreateNumber();

        public static AbstractFactory Create(int kind)
        {
            if (kind == 0)
            {
                return new SqlFactory();
            }
            else
            {
                return new FakeFactory();
            }
        }
    }
}
