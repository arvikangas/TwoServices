using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoServices.First.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InternalController : ControllerBase
    {
        private readonly ILogger<InternalController> _logger;

        public InternalController(ILogger<InternalController> logger)
        {
            _logger = logger;
        }
    }
}
