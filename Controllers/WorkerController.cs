using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebAndWork.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkerController : ControllerBase
    {
        private readonly ILogger<WorkerController> _logger;

        public WorkerController(ILogger<WorkerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return Worker.backgroundResult;
        }
    }
}
