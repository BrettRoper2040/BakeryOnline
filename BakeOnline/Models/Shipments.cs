using System.Collections.Generic;
using BakeOnline.Models; 

namespace BakeOnline.Models
{
    public class Vendors
    {
        public string Description { get; set; }
        public List<Orders> Orders { get; set; } = new List<Orders>();
        private static List<Vendors> _instances = new List<Vendors>();

        public Vendors(string description)
        {
            Description = description;
            _instances.Add(this);
        }

        public static List<Vendors> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public void AddOrder(Orders newOrder)
        {
            Orders.Add(newOrder);
        }
    }
}
