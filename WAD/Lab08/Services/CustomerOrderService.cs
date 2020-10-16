using Lab08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

using Lab08.DataConn;
namespace Lab08.Services
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
                          Customer = c,
                          Order = o
                      };
            return res.ToList();
        }
    }
}
