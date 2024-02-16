using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrbanPetApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Email { get; set; }
        public decimal Total { get; set; }
        public System.DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}