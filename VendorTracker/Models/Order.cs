using System.Collections.Generic;

namespace VendorTracker.Models
{
    public class Order
    {
        public string Details { get; set; }
        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };

        public Order(string details)
        {

        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}