using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Token_Based_Authentication.App_Start;

namespace Token_Based_Authentication.Controllers
{
    public class NeedAuthController : ApiController
    {
        [HttpGet]
        public APIResult Get()
        {
            return new APIResult()
            {
                Success = true,
                Message = "需要提供存取權杖 Access Token 才能使用的 API",
                Payload = new string[] { "有提供存取權杖1", "有提供存取權杖2" }
            };
        }
    }
}
