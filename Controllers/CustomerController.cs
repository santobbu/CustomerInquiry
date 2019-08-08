using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChangePassword.Services;
using CustomerInquiry.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ChangePassword.Controllers
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
        public JsonResult GetCustomer(int customerId, string email)
        {
            var customers = _transactionServices.GetCustomers(customerId, email);
            return Json(customers);
        }
    }
}
