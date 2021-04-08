using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace tenantapi.Controllers
{
    [Route("[controller]")]
    public class UserController : CoreApiBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<UserInfo> Get()
        {
            return new List<UserInfo>();
        }

        [HttpGet("{id}")]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetUser(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }
            return Ok(new UserInfo());
        }

        [HttpGet("{id}/roles")]
        public IEnumerable<ResourceRolesByUserDenormalized> GetRoles(Guid id)
        {
            return new List<ResourceRolesByUserDenormalized>();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateUser()
        {
            return CreatedAtAction(nameof(GetUser), new { id = Guid.NewGuid() });
        }

        [HttpPost("{id}/roles")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AssignRoles()
        {
            return CreatedAtAction(nameof(GetUser), new { id = Guid.NewGuid() });
        }
    }
}
