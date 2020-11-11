using System.Collections.Generic;

namespace BuisnessLogic.Models
{
    public class Cart
    {
        public List<OrderContent> OrderContents { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Shipping { get; set; }
        public decimal Total { get; set; }
    }
}
