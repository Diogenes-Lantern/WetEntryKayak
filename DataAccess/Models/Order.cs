using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int KayakID { get; set; }
        public int TotalAmount { get; set; }
        public string CustomerName { get; set; }
        public string OrderShipAddress { get; set; }
        public string OrderCity { get; set; }
        public string OrderState { get; set; }
        public string OrderCountry { get; set; }
        public string OrderPostalCode { get; set; }
        public int OrderShipping { get; set; }
        public int Tax { get; set; }
        public string OrderTracking { get; set; }
        public string OrderEMail { get; set; }
        public DateTime OrderDateTime { get; set; }
    }
}
