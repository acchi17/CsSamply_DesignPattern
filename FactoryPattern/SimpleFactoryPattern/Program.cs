using SimpleFactoryPattern.View;
using SimpleFactoryPattern.ViewModel;
using SimpleFactoryPattern.Model;

namespace SimpleFactoryPattern
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IData _model = DataFactory.CreateData(0);
            Form1ViewModel _viewModel = new Form1ViewModel(_model);
            Application.Run(new Form1(_viewModel)); 
        }
    }
}