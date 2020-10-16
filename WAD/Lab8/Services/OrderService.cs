using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8.Models;
using Lab8.DataConnect;

namespace Lab8.Services
{
    public class OrderService : IOrderService
    {
        private SaleContext context;
        public OrderService(SaleContext context)
        {
            this.context = context;
        }
        public bool CreateOrder(Order order)
        {
            context.Order.Add(order);
            context.SaveChanges();
            return true;
        }

        public List<Order> GetOrders()
        {
            return context.Order.ToList();
        }
    }
}
