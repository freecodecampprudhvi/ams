using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Calci.Controllers
{

    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpPost]
       [Route("api/values/Sum")]
        public int Sum([FromBody]Object model)
        {
            var result = model.ToString();
            var a = Convert.ToInt32(JObject.Parse(result)["a"]);
            var b = Convert.ToInt32(JObject.Parse(result)["b"]);
            return a+b;
        }
        // GET api/values/5
        public int Get([FromBody]int a,int b)
        {
            return 0;
        }
        
        
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
