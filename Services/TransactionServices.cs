using System;
using System.Collections.Generic;
using System.Linq;
using CustomerInquiry.DataModel;
using LiteDB;

namespace ChangePassword.Services
{
    public class TransactionServices
    {
        private LiteDatabase _database;

        public TransactionServices()
        {
            _database = new LiteDatabase(@"C:\MyData.db");

            InsertDefaultValue();
        }
        public List<Customer> GetCustomers(int customerId, string email)
        {
            return null;
        }

        public void InsertDefaultValue()
        {
            // Add default customer
            var defaultData = new Dictionary<int, Customer>()
            {
            };

            var col = _database.GetCollection<Customer>("Customer");

            foreach (var item in defaultData)
            {
                if (!col.Exists(c => c.CustomerId == item.Value.CustomerId))
                {
                    col.Insert(item.Value);
                }
            }
        }
    }
}
