using System;
using System.Collections.Generic;
using System.Linq;
using CustomerInquiry.DataModel;
using CustomerInquiry.Repository;
using LiteDB;

namespace CustomerInquiry.Services
{
    public class TransactionServices : ITransactionServices
    {
        private CustomerContext _customerContext;

        public TransactionServices(CustomerContext customerContext)
        {
            _customerContext = customerContext;
            InsertDefaultValue();
        }
        public List<Customer> GetCustomers(int customerId, string email)
        {
            return _customerContext.GetCustomers(customerId, email);
        }

        public void InsertDefaultValue()
        {
            // Add default customer
            var customers = new List<Customer> {
                new Customer { CustomerId = 1, CustomerName = "User 01", Email= "user01@mail.com",  MobileNo = "01234545" },
                new Customer { CustomerId = 2, CustomerName = "User 02", Email= "user02@mail.com",  MobileNo = "01234555" },
                new Customer { CustomerId = 3, CustomerName = "User 03", Email= "user03@mail.com",  MobileNo = "01234567" },
            };

            // _customerContext.AddRange(customers);
            customers.ForEach(item => {
                if (!_customerContext.GetCustomers(item.CustomerId, item.Email).Any())
                {
                    _customerContext.Add(item);
                }
            });
            _customerContext.SaveChanges();
        }
    }
}
