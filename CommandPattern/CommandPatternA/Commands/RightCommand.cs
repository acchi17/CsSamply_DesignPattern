namespace CommandPatternA.Commands
{
    public class RightCommand : ICommand
    {
        private Control _control;
        private int _x;
        public RightCommand(Control control, int x)
        {
            _control = control;
            _x = x;
        }

        public void Execute()
        {
            _control.Location = new Point(
                _control.Location.X + _x,
                _control.Location.Y
            );
        }

        public void Undo()
        {
            _control.Location = new Point(
                _control.Location.X - _x,
                _control.Location.Y
            );
        }
    }
}
