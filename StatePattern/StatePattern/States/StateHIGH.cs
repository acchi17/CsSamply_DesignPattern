namespace StatePattern.States
{
    public sealed class StateHIGH: IState
    {
        private static StateHIGH? _instance = null;

        private StateHIGH() { }

        public static StateHIGH GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StateHIGH();
            }
            return _instance;
        }

        public void NextState(StateContext context)
        {
            context.ChangeState(StateLOW.GetInstance());
        }

        public void OnOffState(StateContext context)
        {
            context.ChangeState(StateOFF.GetInstance());
        }

        public string GetText()
        {
            return "HIGH";
        }

        public IEnumerable<string> GetCommand()
        {
            return new List<string> { "HIGH", "1000" };
        }
    }
}
