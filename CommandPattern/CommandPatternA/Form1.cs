using CommandPatternA.Commands;

namespace CommandPatternA
{
    public partial class Form1 : Form
    {
        private CommandInvoker _invoker = new CommandInvoker();
        private Control _targetControl;
        public Form1()
        {
            InitializeComponent();
            _targetControl = textBoxTarget;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBoxAmount.Text);
                //labelTarget.Location =
                //    new Point(
                //        labelTarget.Location.X - x,
                //        labelTarget.Location.Y
                //    );
                _invoker.Execute(new LeftCommand(_targetControl, x));
            }
            catch
            {
                ;
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBoxAmount.Text);
                //labelTarget.Location =
                //    new Point(
                //        labelTarget.Location.X + x, 
                //        labelTarget.Location.Y
                //    );
                _invoker.Execute(new RightCommand(_targetControl, x));
            }
            catch
            {
                ;
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            using (var dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //labelTarget.BackColor = dialog.Color;
                    _invoker.Execute(new BackColorCommand(_targetControl, dialog.Color));
                }
            }
        }
        private void buttonUndo_Click(object sender, EventArgs e)
        {
            _invoker.Undo();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            _invoker.Redo();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonText.Checked)
            {
                _targetControl = textBoxTarget;
            }
            else if (radioButtonLabel.Checked)
            {
                _targetControl = labelTarget;
            }
        }
    }
}
