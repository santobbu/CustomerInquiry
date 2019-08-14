using System;
using System.Collections.Generic;
using System.Linq;
using CustomerInquiry.DataModel;
using Microsoft.EntityFrameworkCore;

namespace CustomerInquiry.Repository
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        public List<Customer> GetCustomers(int customerId, string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return Customers.Where(c => c.CustomerId == customerId).ToList();
            else if (customerId <= 0)
                return Customers.Where(c => c.Email == email).ToList();
            else
                return Customers.Where(c => c.CustomerId == customerId && c.Email == email).ToList();
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
