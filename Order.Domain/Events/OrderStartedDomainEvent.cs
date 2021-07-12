using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Events
{
    public class OrderStartedDomainEvent : INotification
    {
        public OrderStartedDomainEvent(string userName, AggregateModels.OrderModels.Order order)
        {
            UserName = userName;
            Order = order;
        }

        public string UserName { get; set; }
        public AggregateModels.OrderModels.Order Order { get; set; } 


    }
}
