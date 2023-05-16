using System.Collections.Generic;

namespace BakeOnline.Models
{
  public class Vendors
  {
    public string Description { get; set; }
    private static List<Vendors> _instances = new List<Vendors> { };

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
  }
}