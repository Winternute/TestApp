using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;
using TestApp.Services.Abstractions;

namespace TestApp.Services.Implementations
{
    internal class DataProvider : IDataProvider
    {
        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            using (TestDBEntities testDBEntities = new TestDBEntities())
            {
                List<Order> orders;
                orders = await testDBEntities.Orders.Include(o => o.User)
                    .Include(o => o.Order_lines.Select(l => l.Product))                    
                    .ToListAsync();
                return orders;
            }
        }
    }
}
