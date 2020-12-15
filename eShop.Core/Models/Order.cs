using System;
using System.Collections.Generic;

namespace eShop.Core.Models
{
    public class Order
    {
        public Customer Customer { get; set; }
        public string AdminUser { get; set; }
        public DateTime? DatePlaced { get; set; }
        public DateTime? DateProcessed { get; set; }
        public DateTime? DateProcessing { get; set; }
        public int Id { get; set; }
        public IEnumerable<OrderLineItem> LineItems { get; set; }
        public string UniqueId { get; set; }
    }
}