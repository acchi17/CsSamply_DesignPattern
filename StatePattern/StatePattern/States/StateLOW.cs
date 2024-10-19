namespace StatePattern.States
{
    public sealed class StateLOW : IState
    {
        private static StateLOW? _instance = null;

        private StateLOW() { }

        public static StateLOW GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StateLOW();
            }
            return _instance;
        }

        public void NextState(StateContext context)
        {
            context.ChangeState(StateMIDDLE.GetInstance());
        }

        public void OnOffState(StateContext context)
        {
            context.ChangeState(StateOFF.GetInstance());
        }

        public string GetText()
        {
            return "LOW";
        }

        public IEnumerable<string> GetCommand()
        {
            return new List<string> { "LOW", "500" };
        }
    }
}
