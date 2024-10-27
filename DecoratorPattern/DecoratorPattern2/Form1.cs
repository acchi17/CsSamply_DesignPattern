using DecoratorPattern2.Objects;

namespace DecoratorPattern2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMeasure_Click(object sender, EventArgs e)
        {
            IMessage msg = new MeasureMessage(Convert.ToInt32(textBoxMeasureId.Text));

            // Extended functionality by decorator pattern >>
            if (checkBoxXOR.Checked)
            {
                msg = new DecoratorXORCipher(msg);
            }
            if (checkBoxCompress.Checked)
            {
                msg = new DecoratorCompression(msg);
            }
            // <<

            listBoxMessage.Items.Add(string.Join("-", msg.GetBytes()));
        }
    }
}
