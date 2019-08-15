using System.Collections.Generic;
using CustomerInquiry.DataModel;

namespace CustomerInquiry.Services
{
    public interface ITransactionServices
    {
        List<Customer> GetCustomers(int customerId, string email);
    }
}
