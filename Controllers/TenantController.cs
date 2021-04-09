using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace tenantapi.Controllers
{
    [Route("[controller]")]
    public class TenantsController : CoreApiBase
    {
        private readonly ILogger<TenantsController> _logger;

        public TenantsController(ILogger<TenantsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TenantInfo> Get()
        {
            return new List<TenantInfo>();
        }

        [HttpGet("{id}")]
        public IActionResult GetTenant(Guid id)
        {
            return Ok(new TenantInfo());
        }

        [HttpPost]
        public IActionResult CreateTenant(string name)
        {
            return CreatedAtAction(nameof(GetTenant), new { id = Guid.NewGuid() });
        }
    }
}
