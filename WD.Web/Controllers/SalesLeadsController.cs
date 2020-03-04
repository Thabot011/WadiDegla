using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WD.Service.SalesLeadsFormService;

namespace WD.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesLeadsController : ControllerBase
    {
        private readonly ISalesLeadsFormService _salesLeadsFormService;

        public SalesLeadsController(ISalesLeadsFormService salesLeadsFormService)
        {
            _salesLeadsFormService = salesLeadsFormService;
        }
    }
}