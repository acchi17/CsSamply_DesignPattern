using AbstractFactoryPattern.ViewModel;

namespace AbstractFactoryPattern.View
{
    public partial class Form1 : Form
    {
        private Form1ViewModel _viewModel;

        public Form1(Form1ViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            labelShow.DataBindings.Add("Text", _viewModel, "LabelShowText");
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            _viewModel.ButtonGetClick();
        }
    }
}
