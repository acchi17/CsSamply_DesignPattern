using NullObjectPattern.Objects;

namespace NullObjectPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearchId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxProductId.Text);
            //ProductEntity? entity = ProductSqlServer.GetProduct(id);
            //if (entity != null)
            //{
            //    labelProductName.Text = entity.Name;
            //    labelOpeTime.Text = entity.OperatingTime.ToString();
            //}
            //else
            //{
            //    labelProductName.Text = string.Empty;
            //    labelOpeTime.Text = "Unknown";
            //}
            IProductEntity entity = ProductSqlServer.GetProduct(id);
            labelProductName.Text = entity.Name;
            labelOpeTime.Text = entity.OperatingTime.ToString();
        }
    }
}
