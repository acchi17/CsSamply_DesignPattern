namespace CommandPatternA.Commands
{
    public class CommandInvoker
    {
        private Stack<ICommand> _undos = new Stack<ICommand>();
        private Stack<ICommand> _redos = new Stack<ICommand>();

        public void Execute(ICommand command)
        {
            command.Execute();
            _undos.Push(command);
            _redos.Clear();
        }

        public void Undo()
        {
            if (_undos.Count > 0)
            {
                var command = _undos.Pop();
                command.Undo();
                _redos.Push(command);
            }
        }

        public void Redo()
        {
            if (_redos.Count > 0)
            {
                var command = _redos.Pop();
                command.Execute();
                _undos.Push(command);
            }
        }
    }
}
