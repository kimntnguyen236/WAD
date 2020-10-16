using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8.Models;
using Lab8.DataConnect;
namespace Lab8.Services
{
    public class CustomerOrderService : ICustomerOrderService
    {
        private SaleContext context;
        public CustomerOrderService(SaleContext context)
        {
            this.context = context;
        }
        public List<CustomerOrder> GetCustomerOrders()
        {
            var res = from c in context.Customer
                      join o in context.Order
                      on c.CustomerCode equals o.CustomerCode
                      select new CustomerOrder
                      {
                          Customer=c,
                          Order=o
                      };
            return res.ToList();
        }
    }
}
