using Bookings.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bookings.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientController: ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly ApplicationDbContext _context;

        public ClientController(ILogger<ClientController> logger,
            ApplicationDbContext context)
        {
            this._logger = logger;
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Client>>> Get()
        {
            return await _context.Clients.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Client client) 
        {
            _context.Add(client);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        public void Delete()
        {

        }

    }
}
