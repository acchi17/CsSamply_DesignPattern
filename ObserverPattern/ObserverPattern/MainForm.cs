namespace ObserverPattern
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WarningTimer.NotifyWarning += WarningTimer_NotifyWarning;
        }

        private void WarningTimer_NotifyWarning(bool obj)
        {
            this.Invoke((Action)delegate
            {
                if (obj)
                {
                    labelWarning.Text = "Waring";
                    labelWarning.BackColor = Color.Red;
                }
                else
                {
                    labelWarning.Text = "--";
                    labelWarning.BackColor = SystemColors.Control;
                }
            });
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            SubForm f = new SubForm();
            f.Show();
        }
    }
}
