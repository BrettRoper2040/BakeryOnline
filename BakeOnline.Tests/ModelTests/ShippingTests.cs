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

    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void AddOrderToVendor()
        {
            Orders MyOrder = new Orders("Ice Cream");

            Vendors MyLittleVendor = new Vendors("V1");

            MyLittleVendor.AddOrder(MyOrder);

            List<Orders> ListOfLittle = MyLittleVendor.Orders; 

            Assert.AreEqual(1, ListOfLittle.Count);
            Assert.AreEqual(MyOrder, ListOfLittle[0]);
        }
    }

    [TestClass]

    public class GetAllTests
    {
        [TestMethod]
        public void ListAllVendors()
        {
            Vendors MyFirstVendor = new Vendors("V1");
            Vendors MySecondVendor = new Vendors("V2");
            Vendors MyThirdVendor = new Vendors("V3");

            Vendors[] TestArray = new Vendors[] {MyFirstVendor, MySecondVendor, MyThirdVendor};

            List<Vendors> NewVendorsList = Vendors.GetAll();

            Assert.AreEqual(3, NewVendorsList.Count);
            Assert.AreEqual(TestArray, NewVendorsList);
        }
    }
}