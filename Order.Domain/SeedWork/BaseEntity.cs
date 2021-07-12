﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.SeedWork
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        private ICollection<INotification> domainEvents;
        public ICollection<INotification> DomainEvents => domainEvents;

        public void AddDomainEvents(INotification notification)
        {
            domainEvents ??= new List<INotification>();
            domainEvents.Add(notification);
        }
    }
}
