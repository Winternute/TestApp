using System;
using System.Collections.Generic;

namespace TestApp.Models
{
    public class Order
    {
        public int Id { get; set; }

        public User Client { get; set; }

        public int PositionsCount { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
