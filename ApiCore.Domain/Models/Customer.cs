using System;
using System.Collections.Generic;

namespace ApiCore.Domain.Models
{
    public partial class Customer
    {
        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
    }
}
