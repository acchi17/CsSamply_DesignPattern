
namespace StatePattern.States
{
    public sealed class StateContext
    {
        private IState _state = StateOFF.GetInstance();

        public event Action? StateChanged;
        public bool EcoMode { get; set; } = false;

        public void Next()
        {
            _state.NextState(this);
            SendMessage(_state.GetCommand());
        }

        public void OnOff()
        {
            _state.OnOffState(this);
            SendMessage(_state.GetCommand());
        }

        public void ChangeState(IState state)
        {
            _state = state;
            StateChanged?.Invoke();
        }

        public string GetText()
        {
            return _state.GetText();
        }

        private bool SendMessage(IEnumerable<string> msg)
        {
            bool res = false;
            try
            {
                // Temporary implementation
                File.WriteAllLines("mode.texr", msg);
                res = true;
            }
            catch
            {
                ;
            }
            return res;
        }
    }
}
