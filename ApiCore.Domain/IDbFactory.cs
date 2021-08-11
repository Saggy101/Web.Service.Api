using ApiCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCore.Domain
{
    public interface IDbFactory
    {
        DBCustomerContext Init();
    }
}
