using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Address : ValueObject
    {
        public string City { get; set; }
        public string Country { get; set; }




        protected override IEnumerable<object> GetEqualityComponent()
        {
            yield return City;
            yield return Country;
        }
    }
}
