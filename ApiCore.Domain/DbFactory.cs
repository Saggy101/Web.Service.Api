using ApiCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCore.Domain
{
    public class DbFactory : IDbFactory
    {
        DBCustomerContext _dbContext;

        public DBCustomerContext Init()
        {
            return _dbContext ?? (_dbContext = new DBCustomerContext());
        }
    }
}
