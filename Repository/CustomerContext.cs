using System;
using CustomerInquiry.DataModel;
using Microsoft.EntityFrameworkCore;

namespace CustomerInquiry.Repository
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
