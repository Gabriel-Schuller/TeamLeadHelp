using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamLeadHelp.Data;
using TeamLeadHelp.Data.Repositories;
using TeamLeadHelp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeamLeadHelp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevTasksController : ControllerBase
    {
        private readonly IDevTaskRepository _devTaskrepository;

        public DevTasksController(IDevTaskRepository devTaskrepository)
        {
            _devTaskrepository = devTaskrepository;
        }
        // GET: api/<DevTasksController>
        [HttpGet]
        public async Task<ActionResult<List<DevTask>>> GetAllTasks()
        {
            var devTasks = await _devTaskrepository.GetAll();
            if (devTasks.Count == 0) return NoContent();
            return Ok(devTasks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DevTask>> GetTask(int id)
        {
            var product = await _devTaskrepository.GetById(id);

            if (product == null) return NotFound();
           
            return product;
        }

        [HttpPost]
        public async Task<ActionResult<DevTask>> CreateTask(DevTask devTask)
        {
            await _devTaskrepository.Add(devTask);
            return CreatedAtAction(nameof(GetTask), new { id = devTask.ID }, devTask);
        }

    }
}
