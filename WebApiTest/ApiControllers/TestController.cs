using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.ApiControllers
{
    public class TestController : ApiController
    {
        // GET: api/apitest
        public IEnumerable<Test> Get()
        {
            var person1 = new Test() { Name = "山田　一郎", Age = 20 };
            var person2 = new Test() { Name = "田中　太郎", Age = 24 };
            return new Test[] { person1, person2 };
        }

        // GET: api/apitest/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/apitest
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/apitest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/apitest/5
        public void Delete(int id)
        {
        }
    }
}
