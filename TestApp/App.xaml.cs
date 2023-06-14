using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using TestApp.Models;
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
            Task<IEnumerable<Order>> task = dataProvider.GetOrdersAsync();

            MainWindow window = new MainWindow();
            window.Show();

            var orders = await task;
            window.DataContext = new MainWindowViewModel(orders);
        }
    }
}
