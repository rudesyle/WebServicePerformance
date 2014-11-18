using PerformanceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace WebApi
{
    public class PerformanceController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage() { Content = new StringContent("Hello World. Time is: " + DateTime.Now.ToString(), Encoding.UTF8, "text/plain") };
        }

        [HttpGet]
        public Person HelloWorldJson()
        {
            return new Person();
        }

        [HttpGet]
        public HttpResponseMessage HelloWorldJson2()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new ObjectContent<Person>(new Person(),
                            GlobalConfiguration.Configuration.Formatters.JsonFormatter);
            return response;
        }
    }
}