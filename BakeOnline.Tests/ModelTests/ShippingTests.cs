using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeOnline.Models;

namespace BakeOnline.Tests
{
    [TestClass]
    public class VendorsTests
    {
        [TestMethod]
        public void AddVendorToList()
        {
            var vendorsList = Vendors.GetAll();

            Assert.AreEqual(1, vendorsList.Count);
        }
    }
}