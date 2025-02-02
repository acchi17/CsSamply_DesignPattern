using AbstractFactoryPattern.View;
using AbstractFactoryPattern.ViewModel;
using AbstractFactoryPattern.Model.Factory;

namespace AbstractFactoryPattern
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
            AbstractFactory _factory = AbstractFactory.Create(1);
            Form1ViewModel _viewModel = new Form1ViewModel(_factory);
            Application.Run(new Form1(_viewModel));
        }
    }
}