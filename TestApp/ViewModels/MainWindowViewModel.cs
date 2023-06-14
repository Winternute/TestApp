using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestApp.Models;

namespace TestApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(IEnumerable<Order> orders)
        {
            Orders = new ObservableCollection<Order>(orders);
        }

        public ObservableCollection<Order> Orders { get; }

        private Order _selectedOrder;

        public Order SelectedOrder
        {
            get => _selectedOrder;
            set => SetProperty(ref _selectedOrder, value);           
        }
    }
}
