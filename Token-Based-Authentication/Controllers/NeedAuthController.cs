using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Token_Based_Authentication.App_Start;
using Token_Based_Authentication.Filters;

namespace Token_Based_Authentication.Controllers
{
    [JwtAuth]
    public class NeedAuthController : ApiController
    {
        [HttpGet]
        [AuthorizeAttribute(Roles= "Admin,Manager,Member")]
        public APIResult Get()
        {
            var fooUser = Request.Properties["user"] as string;

            return new APIResult()
            {
                Success = true,
                Message = $"授權使用者為 {fooUser}",
                Payload = new string[] { "有提供存取權杖1", "有提供存取權杖2" }
            };
        }
    }
}
