using Kbb.DevTools.Domain.Contracts;
using Kbb.DevTools.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kbb.ReturnManger.Web.Controllers
{
    [Route("api/[controller]")]
    public class ReturnController : Controller
    {
        private readonly IReturnService _returnService;

        public ReturnController(IReturnService returnSevice)
        {
            _returnService = returnSevice ?? throw new ArgumentNullException("returnService");
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Return> Get()
        {
            var testData = new List<Return>();
            testData.Add(new Return
            {
                ReturnId = 1,
                OrderNumber = "AAAAAA-01",
                DateCreated = DateTime.Now
            });
            testData.Add(new Return
            {
                ReturnId = 2,
                OrderNumber = "AAAAAA-02",
                DateCreated = DateTime.Now
            });
            testData.Add(new Return
            {
                ReturnId = 3,
                OrderNumber = "AAAAAA-03",
                DateCreated = DateTime.Now
            });
            testData.Add(new Return
            {
                ReturnId = 4,
                OrderNumber = "AAAAAA-04",
                DateCreated = DateTime.Now
            });

            return testData;
            //return _returnService.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
