using System.Windows;
using TestApp.Services.Abstractions;
using TestApp.Services.Implementations;
using TestApp.ViewModels;
using TestApp.Views;

namespace TestApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected async override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IDataProvider dataProvider = new DataProvider();
            var orders = await dataProvider.GetOrdersAsync();

            MainWindow window = new MainWindow()
            { 
                DataContext = new MainWindowViewModel(orders)
            };

            window.Show();
        }
    }
}
