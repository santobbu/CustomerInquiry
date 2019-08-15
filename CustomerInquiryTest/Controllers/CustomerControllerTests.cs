using NUnit.Framework;
using CustomerInquiry;
using CustomerInquiry.Controllers;

namespace CustomerInquiry
{
    public class CustomerInquiryTests
    {
        private CustomerController customerController;

        [SetUp]
        public void Setup()
        {
            customerController = new CustomerController(null);
        }

        [Test]
        public void CustomerController_GetCustomer_ReturnResultCorrectly()
        {
            Assert.Pass();
        }
    }
}