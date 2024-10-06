using System.Windows.Forms;

namespace CommandPatternA.Commands
{
    public class BackColorCommand : ICommand
    {
        private Control _control;
        private Color _color;
        private Color _undoColor;

        public BackColorCommand(Control control, Color color)
        {
            _control = control;
            _color = color;
            _undoColor = _control.BackColor;
        }

        public void Execute()
        {
            _control.BackColor = _color; 
        }

        public void Undo()
        {
            _control.BackColor = _undoColor;
        }
    }
}
