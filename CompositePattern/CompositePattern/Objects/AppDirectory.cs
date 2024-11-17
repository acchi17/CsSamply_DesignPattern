using CompositePattern.Data;

namespace CompositePattern.Objects
{
    internal sealed class AppDirectory : Entry
    {
        private List<Entry> _childNodes = new List<Entry>();

        public AppDirectory(TreeEntity entity) : base(entity)
        {
            ;
        }

        public override void Add(Entry entry)
        {
            _childNodes.Add(entry);
        }

        public override IEnumerable<Entry> GetChildren()
        {
            return _childNodes;
        }

        public override void Highlight()
        {
            ;
        }

        public override void Release()
        {
            ;
        }

        protected override bool GetIsHighlight()
        {
            foreach (var entry in _childNodes)
            {
                if (entry.IsHighlight)
                {
                    return true;
                }
            }

            return false;
        }


    }
}
