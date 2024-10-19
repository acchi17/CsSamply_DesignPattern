using StatePattern.States;
using System.IO;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StatePattern
{
    public partial class Form1 : Form
    {
        //private enum enumMode { ON, OFF, LOW, MIDDLE, HIGH }
        //private enumMode _mode = enumMode.OFF;
        private StateContext _context = new StateContext();

        public Form1()
        {
            InitializeComponent();
            //labelDisplay.Text = _mode.ToString();
            ChangeDisplay();
            _context.EcoMode = checkBoxOnOff.Checked;
            _context.StateChanged += ChangeDisplay;
            checkBoxOnOff.Checked = false;
        }

        private void ChangeDisplay()
        {
            labelDisplay.Text = _context.GetText();
        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            //if (checkBoxOnOff.Checked)
            //{
            //    if (_mode == enumMode.LOW)
            //    {
            //        _mode = enumMode.MIDDLE;
            //    }
            //    else if (_mode == enumMode.MIDDLE)
            //    {
            //        if (checkBoxEcoMode.Checked)
            //        {
            //            _mode = enumMode.LOW;
            //        }
            //        else
            //        {
            //            _mode = enumMode.HIGH;
            //        }   
            //    }
            //    else if (_mode == enumMode.HIGH)
            //    {
            //        _mode = enumMode.LOW;
            //    }
            //    else
            //    {
            //        ;
            //    }
            //}
            //else
            //{
            //    ;
            //}
            //labelDisplay.Text = _mode.ToString();
            _context.Next();
        }

        private void checkBoxOnOff_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxOnOff.Checked)
            //{
            //    _mode = enumMode.LOW;
            //}
            //else
            //{
            //    _mode = enumMode.OFF;
            //}
            //labelDisplay.Text = _mode.ToString();  
            _context.OnOff();
        }

        private void checkBoxEcoMode_CheckedChanged(object sender, EventArgs e)
        {
            _context.EcoMode = checkBoxEcoMode.Checked;
        }
    }
}
