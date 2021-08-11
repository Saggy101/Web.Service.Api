using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCore.Domain;
using ApiCore.Domain.Models;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http;
//using System.Web.Http;

namespace Web.Service.Api.Controllers
{
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        private readonly IGenericRepository<Customer> _customerRepository;

        public CustomerController(IGenericRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [System.Web.Http.Route("api/Customer/GetCustomerList")]
        public IQueryable<Customer> GetCustomerList()
        {
            return _customerRepository.GetAll();
        }
    }
}
