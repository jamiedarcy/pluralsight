using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";

            //--ACT

            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";

            string expected = "Baggins";

            //--ACT

            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";

            string expected = "Bilbo";

            //--ACT

            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InstanceCountTest()
        {
            //--Arrange
            var c1 = new Customer();
            Customer.InstanceCount +=1;
            var c2 = new Customer();
            Customer.InstanceCount +=1;
            var c3 = new Customer();
            Customer.InstanceCount +=1;

            //-ACT
            //-Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var c1 = new Customer();
            c1.LastName = "Baggins";
            cus
            var c2 = new Customer();
            Customer.InstanceCount += 1;
            var c3 = new Customer();
            Customer.InstanceCount += 1;

            //-ACT
            //-Assert

        }

    }
}
