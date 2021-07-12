using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.AggregateModels.BuyerModels
{
    public class Buyer : BaseEntity
    {
        public string UserName { get; set; }

        public Buyer(string userName)
        {
            UserName = userName;
        }
    }
}
