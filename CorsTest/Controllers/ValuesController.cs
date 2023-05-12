using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace CorsTest.Controllers {

    public class ValuesController : ApiController {
        // GET api/values
        //[EnableCors("http://192.168.4.179:8080","*","*")]// 单独api 设置cors，特性标记和全局都设置会有冲突， 只设置一种
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id) {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value) {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/values/5
        public void Delete(int id) {
        }
    }
}
