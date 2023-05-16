using System.Collections.Generic;

namespace BakeOnline.Models
{
    public class Orders
    {
        public string Description { get; set; }

        public Orders(string description)
        {
            Description = description;
        }
    }
}