using System.Collections.Generic;
using System.Linq;
using TddDemo.DataAcces;
using TddDemo.Entities;

namespace TddDemo.Business
{
    public class CustomerManager : ICustomerManager
    {
        ICustomerDal _custumerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _custumerDal = customerDal;
        }

        public List<Customer> CustomersByİnitial(string initial)
        {
            return _custumerDal.GetAll().Where(c=> c.FristName.ToUpper().StartsWith(initial.ToUpper())).ToList();
        }

        public List<Customer> Getall()
        {
            //diğer iş kodları
           return _custumerDal.GetAll();

        }
    }
}