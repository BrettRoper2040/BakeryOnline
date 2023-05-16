using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeOnline.Models;

namespace BakeOnline.Tests
{
    [TestClass]
    public class VendorsTests
    {
        [TestMethod]
        public void AddVendorToList()
        {
            Vendors MyVendor = new Vendors("Vendor 1");

            List<Vendors> VendorsList = Vendors.GetAll();

            Assert.AreEqual(1, VendorsList.Count);
            Assert.AreEqual(MyVendor, VendorsList[0]);
        }
    }
}