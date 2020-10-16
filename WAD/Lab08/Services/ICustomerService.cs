using Lab08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab08.Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        void CreateCustomer(Customer customer);
    }
}
