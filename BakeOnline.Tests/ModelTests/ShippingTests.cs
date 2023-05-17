using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeOnline.Models;

namespace BakeOnline.Tests
{
    [TestClass]

    public class ClearAllTests
    {  
        [TestMethod]
        public void ClearAllVendors()
        {
            Vendors VendorDoof = new Vendors("Lorem");
            
             List<Vendors> NewVendorsList = Vendors.GetAll();

            Vendors.ClearAll();
            Assert.AreEqual(0, NewVendorsList.Count);
        }

    }
    [TestClass]

    public class GetAllTests
    {
        [TestMethod]
        public void ListAllVendors()
        {
            Vendors.ClearAll();
            Vendors MyFirstVendor = new Vendors("V1");
            Vendors MySecondVendor = new Vendors("V2");
            Vendors MyThirdVendor = new Vendors("V3");

            Vendors[] TestArray = new Vendors[] {MyFirstVendor, MySecondVendor, MyThirdVendor};

            List<Vendors> NewVendorsList = Vendors.GetAll();

            Assert.AreEqual(3, NewVendorsList.Count);
           CollectionAssert.AreEquivalent(TestArray, NewVendorsList);
        }
    }

    [TestClass]
    public class VendorsTests
    {
        [TestMethod]
        public void AddVendorToList()
        {
            Vendors.ClearAll();
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
            Vendors.ClearAll();
            Orders MyOrder = new Orders("Ice Cream");

            Vendors MyLittleVendor = new Vendors("V1");

            MyLittleVendor.AddOrder(MyOrder);

            List<Orders> ListOfLittle = MyLittleVendor.Orders; 

            Assert.AreEqual(1, ListOfLittle.Count);
            Assert.AreEqual(MyOrder, ListOfLittle[0]);
        }
    }

    [TestClass]

    public class ClearOrderTests
    {
        [TestMethod]
        public void ClearOrdersFromVendor()
        {
            Vendors.ClearAll();
            Orders MyOrder = new Orders("Pizza");

            Vendors MyVendor = new Vendors("V2");

            MyVendor.AddOrder(MyOrder);

            List<Orders> ListOfOrders = MyVendor.Orders; 

            MyVendor.ClearOrders();

            Assert.AreEqual(0, ListOfOrders.Count);
        }
    }
}