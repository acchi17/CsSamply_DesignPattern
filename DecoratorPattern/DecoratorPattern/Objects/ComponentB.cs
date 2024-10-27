namespace DecoratorPattern1.Objects
{
    public sealed class ComponentB : IComponent
    {
        public string GetData()
        {
            return File.ReadAllText("textB.txt");
        }

        public int GetPrice()
        {
            return 200;
        }
    }
}
