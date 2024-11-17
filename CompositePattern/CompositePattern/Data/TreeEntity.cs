namespace CompositePattern.Data
{
    internal sealed class TreeEntity
    {
        public int Id { get; }
        public int ParentId { get; }
        public int Kind { get; }
        public string Name { get; }

        public TreeEntity(int id, int parentId, int kind, string name)
        {
            Id = id;
            ParentId = parentId;
            Kind = kind;
            Name = name;
        }
    }
}
