namespace StatePattern.States
{
    public interface IState
    {
        void NextState(StateContext state);
        void OnOffState(StateContext state);
        string GetText();
        IEnumerable<string> GetCommand();
    }
}
