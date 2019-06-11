using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            var message = new Message
            {
                Token = "dgY8UMXhEZ4:APA91bFnrZTGJKkCCBJHzbghvsvEaq-w-ee1XBAVqAaS-rsmR3Ald23rHGgpfdgVb09r97jDQBVSc6GtDHWtLHWAnn4Lm3EM_j-sh7cu-RaRSrfnk3X124v4co3Q9ID6TxFdGgv7OXWt",
                Data = new Dictionary<string, string>
                {
                    {"title", "test" }
                }
            };
            try
            {
                var fcmResult = await FirebaseMessaging.DefaultInstance.SendAsync(message);
            } catch (FirebaseException ex)
            {

            }
           

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
