//--------------------------------------------------------------------------------------
//  Example of Object-Oriented Programming Style
//  *Make each objects(Mario, Luiji) responsible.
//  *Encapsulate data and behavior into each objects.
//  *The main logic has simple procedure, each objects have details(data and behaviar).
//--------------------------------------------------------------------------------------
using ObjectOrientedStyle.Objects;

namespace ObjectOrientedStyle
{
    public partial class FormMain : Form
    {
        private List<CharacterBase> _characters = new List<CharacterBase>();
        private CharacterBase _selectedCharacter;
        public FormMain()
        {
            InitializeComponent();

            _characters.Add(new Mario());
            _characters.Add(new Luigi());
            _selectedCharacter = _characters[0];
        }

        private void panelField_Paint(object sender, PaintEventArgs e)
        {
            foreach (CharacterBase character in _characters)
            {
                e.Graphics.FillRectangle(
                    new SolidBrush(character.Color), character.X, character.Y, character.Width, character.Height);
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            _selectedCharacter.Right();
            panelField.Refresh();
        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
            string message;
            if (_selectedCharacter.Call(out message))
            {
                MessageBox.Show(message);
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMario.Checked)
            {
                _selectedCharacter = _characters[0];
            }
            else if (radioButtonLuigi.Checked)
            {
                _selectedCharacter = _characters[1];
            }
        }
    }
}
