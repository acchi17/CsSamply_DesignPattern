using SimpleFactoryPattern.Model;
using System.ComponentModel;

namespace SimpleFactoryPattern.ViewModel
{
    public class Form1ViewModel : INotifyPropertyChanged
    {
        private string _labelShowText = "";
        public string LabelShowText
        {
            get { return _labelShowText; }
            set
            {
                _labelShowText = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(LabelShowText)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private IData _model;

        public Form1ViewModel(IData model)
        {
            _model = model;
        }

        public void ButtonGetClick()
        {
            LabelShowText = _model.GetData();
        }
    }
}
