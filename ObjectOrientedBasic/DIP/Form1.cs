using DIP.Objects;

namespace DIP
{
    public partial class Form1 : Form
    {
        //private bool _isDebug = false;
        //private ProductSqlServer _product = new ProductSqlServer();
        private IProduct _product = Factories.CreateProduct();


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            //if (_isDebug)
            //{
            //    textBoxLog.Text = textBoxLog.Text + "Data for test" + "\r\n";
            //}
            //else
            //{
            //    textBoxLog.Text = textBoxLog.Text + _product.GetData() + "\r\n";
            //}
            textBoxLog.Text = textBoxLog.Text + _product.GetData() + "\r\n";
        }
    }
}
