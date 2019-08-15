using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerInquiry.Services;
using CustomerInquiry.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CustomerInquiry.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private TransactionServices _transactionServices;

        public CustomerController(CustomerContext customerContext)
        {
            _transactionServices = new TransactionServices(customerContext);
        }

        [HttpPost("GetCustomer")]
        public JsonResult GetCustomer(CustomerParams customerParams)
        {
            var customers = _transactionServices.GetCustomers(customerParams.CustomerId, customerParams.Email);
            return Json(customers);
        }
    }

    public class CustomerParams
    {
        public int CustomerId { get; set; }

        public string Email { get; set; }
    }
}
