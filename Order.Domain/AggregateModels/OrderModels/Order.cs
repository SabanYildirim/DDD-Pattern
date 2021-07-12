using Order.Domain.Events;
using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Order : BaseEntity, IAggregateRoot
    {
        public DateTime OrderDate { get; set; }

        public string Description { get; set; }

        public string UserName { get; set; }

        public string OrderStatus { get; set; }

        public Address Address { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public Order(DateTime orderDate, string description, string userName, string orderStatus, Address address, ICollection<OrderItem> orderItems)
        {
            if (orderDate < DateTime.Now)
                throw new Exception("Orderdata must be greater than now");

            if (address.City == "")
                throw new Exception("city cannot be empty");

            OrderDate = orderDate;
            Description = description;
            UserName = userName;
            OrderStatus = orderStatus;
            Address = address;
            OrderItems = orderItems;

            AddDomainEvents(new OrderStartedDomainEvent("", this));
        }

        public void AddOrderItem(int quantity, decimal price, int productId)
        {
            OrderItem item = new OrderItem
            {
                Quantity = quantity,
                Price = price,
                ProductId = productId
            };

            OrderItems.Add(item);
        }
    }
}
