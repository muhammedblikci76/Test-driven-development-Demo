using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TddDemo.DataAcces;
using TddDemo.Entities;

namespace TddDemo.Business.Tests
{
    [TestClass]
    public class CustomerManagerTest
    {
        Mock<ICustomerDal> _mockCustomerDal;
        List<Customer> _dbCustomers;
        [TestInitialize]
        public void Start() 
        {
            _mockCustomerDal= new Mock<ICustomerDal>();
            _dbCustomers = new List<Customer>()// Test in db silme olasılığı oluşacağı için her seferinde yeniden oluşturuyoruz.
            {
                new Customer{ Id=1 , FristName="Ali"},
                new Customer{ Id=2 , FristName="Ahmet"},
                new Customer{ Id=3 , FristName="Ayşe"},
                new Customer{ Id=4 , FristName="Aydın"},
                new Customer{ Id=5 , FristName="Burhan"},
            };
            _mockCustomerDal.Setup(m => m.GetAll()).Returns(_dbCustomers);
        }
        [TestMethod]
        public void Tum_Musteriler_Listenebilmeli()
        {
            //Arrange
            ICustomerManager customerService=new CustomerManager(_mockCustomerDal.Object);
            //Act
            List<Customer> customers = customerService.Getall();
            //Assert
            Assert.AreEqual(5, customers.Count);
        }
        [TestMethod]
        public void A_ie_Baslayan_Dort_Musteri_Gelebilmelidir()
        {
            //Arrange
            ICustomerManager customerService = new CustomerManager(_mockCustomerDal.Object);
            //Act
            List<Customer> customers = customerService.CustomersByİnitial("A");
            //Assert
            Assert.AreEqual(4, customers.Count);
        }





    }
    //müşteriler listelenebilmeli
    //müşteriler başharflerine göre sayfalanabilmeli

    //test case
    //5 elemanlı bir liste olsun
}
