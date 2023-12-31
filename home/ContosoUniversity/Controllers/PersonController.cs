using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private PersonRepository _repository;
        public PersonController()
        {
            _repository = new PersonRepository();
        }

        [HttpGet]
        [Route("findBy")]
        public IActionResult Get([FromQuery] Person person)
        {
            return Ok(_repository.Get(person));
        }

                [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.Get());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.Get(id));
        }

    }
}