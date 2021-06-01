using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company_API.Controllers
{
    [Route("Controller")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyServices _companyServices;
        public CompanyController(CompanyServices companyServices)
        {
            _companyServices = companyServices;
        }
    [HttpGet]
        public ActionResult<List<Company>> Get() =>
            _companyServices.Get();
        public ActionResult<Company> Get(string id)
    }
}
