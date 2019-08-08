using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerInquiry.Common.Enumerable;

namespace CustomerInquiry.DataModel
{
    public class Transaction
    {
        public string TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public Decimal Amount { get; set; }
        public CurrencyCode CurrencyCode { get; set; }
        public Status Status { get; set; }
    }
}
