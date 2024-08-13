namespace SingletonPattern
{
    public partial class Form1 : Form
    {
        //private CheckTimer _checkTimer = new CheckTimer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_checkTimer.StartTimer();
            CheckTimer.GetInstance().StartTimer();
        }
    }
}
