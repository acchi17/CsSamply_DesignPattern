using AbstractFactoryPattern.Model;
using AbstractFactoryPattern.Model.Factory;
using System.ComponentModel;

namespace AbstractFactoryPattern.ViewModel
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
        private IData _data;
        private INumber _number;

        //public Form1ViewModel(IData data, INumber number)
        //{
        //    _data = data;
        //    _number = number
        //}

        public Form1ViewModel(AbstractFactory factory)
        {
            _data = factory.CreateData();
            _number = factory.CreateNumber();
        }

        public void ButtonGetClick()
        {
            LabelShowText = $"Data:{_data.GetData()}, Number:{_number.GetNumber().ToString()}";
        }
    }
}
