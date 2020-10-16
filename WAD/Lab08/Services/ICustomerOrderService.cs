using System;
using System.Collections.Generic;
using System.Linq;
using Lab08.Models;
using System.Threading.Tasks;

namespace Lab08.Services
{
    public interface ICustomerOrderService
    {
        List<CustomerOrder> GetCustomerOrders();
    }
}
