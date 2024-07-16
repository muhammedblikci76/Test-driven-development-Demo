using System;
using System.Collections.Generic;
using TddDemo.Entities;

namespace TddDemo.DataAcces
{
    public interface ICustomerDal
    {
        public List<Customer> GetAll();
        
    }
}