using System.Collections.Generic;
using TddDemo.Entities;

namespace TddDemo.Business
{
    public interface ICustomerManager
    {
        List<Customer> CustomersByİnitial(string v);
        List<Customer> Getall();
    }
}