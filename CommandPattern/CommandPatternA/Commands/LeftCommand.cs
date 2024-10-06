namespace CommandPatternA.Commands
{
    public class LeftCommand : ICommand
    {
        private Control _control;
        private int _x;
        public LeftCommand(Control control, int x)
        {
            _control = control;
            _x = x;
        }

        public void Execute()
        {
            _control.Location = new Point(
                _control.Location.X - _x,
                _control.Location.Y
            );
        }

        public void Undo()
        {
            _control.Location = new Point(
                _control.Location.X + _x,
                _control.Location.Y
            );
        }
    }
}
