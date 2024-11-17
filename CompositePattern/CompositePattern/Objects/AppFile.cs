using CompositePattern.Data;

namespace CompositePattern.Objects
{
    internal sealed class AppFile : Entry
    {
        private Condition _condition = Condition.NORMAL;

        public AppFile(TreeEntity entity) : base(entity)
        {
            ;
        }

        public override void Add(Entry entry)
        {
            throw new NotImplementedException($"It can not Add(), Id:{Id}");
        }

        public override IEnumerable<Entry> GetChildren()
        {
            return new List<Entry>();
        }

        public override void Highlight()
        {
            _condition = Condition.HIGHLIGHT;
        }

        public override void Release()
        {
            _condition = Condition.NORMAL;
        }

        protected override bool GetIsHighlight()
        {
            return (_condition == Condition.HIGHLIGHT);
        }

    }
}
