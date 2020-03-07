using System;
using System.Collections.Generic;

namespace DotNetSaleCore.ConsoleApp.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? OrderFulfilled { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
