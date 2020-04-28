using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunTODODataAccess
{
    public class FuntodoDataBase : SqlUtil, IDataBase
    {
        public FuntodoDataBase(IConfiguration configuration) : base(configuration)
        {
        }

        public object TodoListByUserID(string iD)
        {
            throw new NotImplementedException();
        }
    }
}
