using System.Collections.Generic;

namespace VendorTracker.Models
{
    public class Vendor
    {
        private static List<Vendor> _instances = new List<Vendor> { };
        public string Name { get; set; }
        public int Id { get; }
        public Vendor(string vendorName)
        {

        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}