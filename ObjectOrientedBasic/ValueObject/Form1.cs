using ValueObject.Objects;
using static System.Windows.Forms.AxHost;

namespace ValueObject
{
    public partial class Form1 : Form
    {
        private Stage _stage = new Stage();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetAddr_Click(object sender, EventArgs e)
        {
            StageAddressX addrX = new StageAddressX(_stage.GetAddress());
            int dp = (int)numericUpDownDP.Value;
            if (radioButtonMm.Checked)
            {
                textBoxAddress.Text = addrX.GetValue_mm(dp).ToString();
            }
            else
            {
                textBoxAddress.Text = addrX.GetValue_um(dp).ToString();
            }    
        }
    }
}
