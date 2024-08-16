//--------------------------------------------------------------------------------------
//  Example of Procedural Programming Style
//  *All the knowledge(data, behavior) in the main logic(FormMain.cs).
//  *It is easy to introduce bugs by modifying the main logic.
//  *Only someone with full knowledge can modify the main logic.
//--------------------------------------------------------------------------------------
namespace ProceduralStyle
{
    public partial class FormMain : Form
    {
        private int _marioX = 10;
        private int _marioY = 10;
        private int _marioCount = 0;

        private int _luigiX = 10;
        private int _luigiY = 80;
        private int _luigiCount = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void panelField_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), _marioX, _marioY, 50, 50);
            e.Graphics.FillRectangle(new SolidBrush(Color.Lime), _luigiX, _luigiY, 50, 50);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (radioButtonMario.Checked)
            {
                _marioX += 10;
            }
            else if (radioButtonLuigi.Checked)
            {
                _luigiX += 20;
            }
            panelField.Refresh();
        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
            if (radioButtonMario.Checked)
            {
                _marioCount++;
                if (_marioCount >= 3)
                {
                    _marioCount = 0;
                    MessageBox.Show("Hi, I'm Mario.");
                }
            }
            else if (radioButtonLuigi.Checked)
            {
                _luigiCount++;
                if (_luigiCount >= 5)
                {
                    _luigiCount = 0;
                    MessageBox.Show("Hello, It's Luigi.");
                }
            }
        }
    }
}
