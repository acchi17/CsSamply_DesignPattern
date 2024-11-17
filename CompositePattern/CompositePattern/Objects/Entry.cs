using CompositePattern.Data;

namespace CompositePattern.Objects
{
    internal enum Condition
    {
        NORMAL,
        HIGHLIGHT
    }

    internal abstract class Entry
    {
        protected TreeEntity _entity;

        public int Id => _entity.Id;
        public int ParentId => _entity.ParentId;

        public int Kind => _entity.Kind;
        public string Name => _entity.Name;
        public bool IsHighlight { get { return GetIsHighlight(); } }

        protected Entry(TreeEntity entity)
        {
            _entity = entity;
        }

        public abstract void Add(Entry entry);
        public abstract IEnumerable<Entry> GetChildren();
        public abstract void Highlight();
        public abstract void Release();
        protected abstract bool GetIsHighlight();



    }
}
