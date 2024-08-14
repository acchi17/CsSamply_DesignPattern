namespace ObserverPattern
{
    public partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();
            this.Disposed += SubForm_Disposed;
            WarningTimer.NotifyWarning += WarningTimer_NotifyWarning;
        }

        private void SubForm_Disposed(object? sender, EventArgs e)
        {
            WarningTimer.NotifyWarning -= WarningTimer_NotifyWarning;
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
    }
}
