using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab08.Models;
using Lab08.DataConn;
using Lab08.Services;

namespace Lab8.Services
{
    public class CustomerService : ICustomerService
    {
        private SaleContext context;
        public CustomerService(SaleContext context)
        {
            this.context = context;
        }
        public List<Customer> GetCustomers()
        {
            return context.Customer.ToList();
        }
        public void CreateCustomer(Customer customer)
        {
            try
            {
                Customer cus = context.Customer.SingleOrDefault(c => c.CustomerCode.Equals(customer.CustomerCode));
                if (cus == null)
                {
                    context.Customer.Add(customer);
                    context.SaveChanges();
                }
                else
                {
                    return;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}