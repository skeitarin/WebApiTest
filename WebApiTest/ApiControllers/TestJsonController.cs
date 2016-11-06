using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Models;
using WebApiTest.Util;

namespace WebApiTest.ApiControllers
{
    public class TestJsonController : ApiController
    {
        // GET: api/TestJson
        public HttpResponseMessage Get()
        {
            var person1 = new Test() { Name = "山田　一郎", Age = 20 };
            var person2 = new Test() { Name = "田中　太郎", Age = 24 };
            return new JsonUtil().ReturnJson(new Test[] { person1, person2 });
        }

        // GET: api/TestJson/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
