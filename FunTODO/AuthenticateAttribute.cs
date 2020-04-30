using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FunTODO.Controllers
{
    public class AuthenticateAttribute : TypeFilterAttribute
    {
        //public AuthenticateAttribute(string permission)
        //    : base(typeof(AuthorizeActionFilter))
        //{
        //    Arguments = new object[] { permission };
        //}
        public AuthenticateAttribute()
           : base(typeof(AuthorizeActionFilter))
        {
            //Arguments = new object[] {  };
        }
    }
}