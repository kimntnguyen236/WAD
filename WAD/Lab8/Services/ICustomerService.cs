﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8.Models;
namespace Lab8.Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        void CreateCustomer(Customer customer);
    }
}
