using DecoratorPattern1.Objects;
using System.Diagnostics.Eventing.Reader;

namespace DecoratorPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReadA_Click(object sender, EventArgs e)
        {
            IComponent compo = new ComponentA();

            // Extended functionality by decorator pattern >>
            if (radioButtonUpperCase.Checked)
            {
                compo = new DecoratorUpper(compo); 
            }
            else if (radioButtonLowerCase.Checked)
            {
                compo = new DecoratorLower(compo);
            }
            // <<

            buttonReadA.Text = compo.GetData();
        }

        private void buttonReadB_Click(object sender, EventArgs e)
        {
            IComponent compo = new ComponentB();

            // Extended functionality by decorator pattern >>
            if (radioButtonUpperCase.Checked)
            {
                compo = new DecoratorUpper(compo);
            }
            else if (radioButtonLowerCase.Checked)
            {
                compo = new DecoratorLower(compo);
            }
            // <<

            buttonReadB.Text = compo.GetData();
        }
    }
}
