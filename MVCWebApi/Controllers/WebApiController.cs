using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PerformanceClass;

namespace MVCWebApi.Controllers
{
    public class WebApiController : ApiController
    {
        // GET api/WebApi
        public HttpResponseMessage Get()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new ObjectContent<Person>(new Person(),
                            GlobalConfiguration.Configuration.Formatters.JsonFormatter);
            return response;
        }
    }
}
