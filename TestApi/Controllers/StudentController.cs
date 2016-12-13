using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TestApi.Models;

namespace TestApi.Controllers
{
    [RoutePrefix("students")]
    public class StudentController : ApiController
    {
        private readonly IStudent _repository;

        public StudentController(IStudent repo)
        {
            _repository = repo;
        }
        // GET: Student
        public IHttpActionResult Get()
        {
            return Ok(_repository.Get());
        }

        public IHttpActionResult Get(int id)
        {
            return Ok(_repository.Get(id));
        }
    }
}