namespace DecoratorPattern1.Objects
{
    public sealed class ComponentA : IComponent
    {
        public string GetData()
        {
            return File.ReadAllText("textA.txt");
        }

        public int GetPrice()
        {
            return 100;
        }
    }
}
