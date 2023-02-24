using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamLeadHelp.Data;
using TeamLeadHelp.Data.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeamLeadHelp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevTasksController : ControllerBase
    {
        private readonly DevTaskContext _devTaskContext;

        public DevTasksController(DevTaskContext devTaskContext)
        {
            _devTaskContext = devTaskContext;
        }
        // GET: api/<DevTasksController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DevTask>>> GetProducts()
        {
            return await _devTaskContext.Tasks.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<DevTask>> CreateProduct(DevTask devTask)
        {
            _devTaskContext.Tasks.Add(devTask);
            await _devTaskContext.SaveChangesAsync();

            return Ok(devTask);
        }

    }
}
