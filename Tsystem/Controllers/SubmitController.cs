using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tsystem.Models;

namespace Tsystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubmitController : ControllerBase
    {
        private readonly ILogger<SubmitController> _logger;

        static readonly Models.SubmitRepository repository = new Models.SubmitRepository();

        public SubmitController(ILogger<SubmitController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("get/ptorecords")]
        public IEnumerable<Models.Submit> GetAllUsers_pto()
        {
            return repository.GetAll_pto();
        }

        [HttpGet]
        [Route("get/sickrecords")]
        public IEnumerable<Models.Submit> GetAllUsers_sick()
        {
            return repository.GetAll_sick();
        }


        [HttpGet]
        [Route("get/records")]
        public IEnumerable<Models.Submit> GetAllUsers()
        {
            return repository.GetAll();
        }

        [HttpGet]
        [Route("get/employee")]
        public IEnumerable<Models.Employee> GetAllEmployee()
        {
            return repository.GetAll_employee();
        }

        [HttpPost]
        [Route("add/records")]
        [Consumes("application/json")]
        public Models.Submit Insert(Models.Submit submit)
        {
            return repository.Add(submit);
        }

        [HttpPost]
        [Route("add/employee")]
        [Consumes("application/json")]
        public Models.Employee Insert_user(Models.Employee employee)
        {
            return repository.Add_employee(employee);
        }

    }
}
