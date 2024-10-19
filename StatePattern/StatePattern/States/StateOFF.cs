namespace StatePattern.States
{
    public sealed class StateOFF : IState
    {
        private static StateOFF? _instance = null;

        private StateOFF() { }

        public static StateOFF GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StateOFF();
            }
            return _instance;
        }

        public void NextState(StateContext context)
        {
            ;
        }

        public void OnOffState(StateContext context)
        {
            context.ChangeState(StateLOW.GetInstance());
        }

        public string GetText()
        {
            return "OFF";
        }

        public IEnumerable<string> GetCommand()
        {
            return new List<string> { "OFF", "0" };
        }
    }
}
