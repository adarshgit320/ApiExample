﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiExample.Controllers
{
    public class ValuesController : ApiController
    {


        PoliclinicPatnaEntities web = new PoliclinicPatnaEntities();
        // GET api/values
        //[Route("api/adarsh/{id}")]
        public HttpResponseMessage Get()
        {

            var result = new
            {
               
                data = web.Doctors.Select(x => new { x.Title, x.Mobile, x.Gender, x.Fee })
            };
            return Request.CreateResponse(HttpStatusCode.OK,result);


        }

      
        [Route("api/adarsh/{id}")]
        //public HttpResponseMessage GetDoctorbranch()
        //{
        //    //return Request.CreateResponse(HttpStatusCode.OK,web..Select(x=> new {x. }));
        //}

        // POST api/values

        [HttpPost]
        public HttpResponseMessage Post(Doctor value)
        {


            return Request.CreateResponse(HttpStatusCode.OK,value);

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
