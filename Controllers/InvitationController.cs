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
    public class InvitationsController: CoreApiBase {
        private ILogger<UserController> _logger;

        public InvitationsController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<InvitationView> Getlist([FromQuery] Guid userId, [FromQuery]Guid tenantId)
        {
            return new List<InvitationView>();
        }

        [HttpGet("{id}")]
        public InvitationView GetInvitation(Guid id) {
            return new InvitationView();
        }

        [HttpPost]
        public IActionResult CreateInvitation(InvitationRequest req)
        {
            return CreatedAtAction(nameof(GetInvitation), new {id = Guid.NewGuid()});
        }
        [HttpPost("{id}/accept")]
        public IActionResult Accept(Guid id )
        {
            return Ok();
        }
        [HttpPost("{id}/reissue")]
        public IActionResult Reissue(Guid id )
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Cancel(Guid id )
        {
            return Ok();
        }


    }
}
