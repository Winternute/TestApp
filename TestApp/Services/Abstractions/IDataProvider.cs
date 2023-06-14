using System.Collections.Generic;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Services.Abstractions
{
    public interface IDataProvider
    {
        Task<IEnumerable<Order>> GetOrdersAsync();
    }
}
