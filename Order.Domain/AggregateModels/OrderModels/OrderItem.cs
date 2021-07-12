using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class OrderItem : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
    }
}
