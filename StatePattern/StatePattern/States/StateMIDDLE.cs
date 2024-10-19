namespace StatePattern.States
{
    public sealed class StateMIDDLE : IState
    {
        private static StateMIDDLE? _instance = null;

        private StateMIDDLE() { }

        public static StateMIDDLE GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StateMIDDLE();
            }
            return _instance;
        }

        public void NextState(StateContext context)
        {
            if (context.EcoMode)
            {
                context.ChangeState(StateLOW.GetInstance());
            }
            else
            {
                context.ChangeState(StateHIGH.GetInstance());
            }
        }

        public void OnOffState(StateContext context)
        {
            context.ChangeState(StateOFF.GetInstance()); 
        }

        public string GetText()
        {
            return "MIDDLE";
        }

        public IEnumerable<string> GetCommand()
        {
            return new List<string> { "MIDDLE", "700" };
        }
    }
}
