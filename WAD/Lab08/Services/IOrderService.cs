using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab08.Models;

namespace Lab08.Services
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        bool CreateOrder(Order order);
    }
}
