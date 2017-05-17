using NextGen.Domain.Abstract;
using NextGen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NextGen.WebUI.Controllers.api
{
    public class ValuesController : ApiController
    {
        private IEntityRepository<ch_submission> _chSubmissions;

        public ValuesController(IEntityRepository<ch_submission> chSubmissions)
        {
            _chSubmissions = chSubmissions;
        }

        // GET api/<controller>
        [HttpGet]
        [Route("api/values")]
        public IHttpActionResult Get()
        {
            var listOfSubmissions = _chSubmissions.GetAll().Take(5).ToList();
            return Ok(listOfSubmissions);
        }
    }
}
