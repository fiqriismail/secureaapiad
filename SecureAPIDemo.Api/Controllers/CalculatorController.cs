using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SecureAPIDemo.Api.Models;


namespace SecureAPIDemo.Api.Controllers
{
    public class CalculatorController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Add(CalcInput input)
        {
            int answer = input.Number1 + input.Number2;
            return Ok<int>(answer);
        }

        [HttpPost]
        public IHttpActionResult Substract(CalcInput input)
        {
            int answer = input.Number1 - input.Number2;
            return Ok<int>(answer);
        }
    }
}
