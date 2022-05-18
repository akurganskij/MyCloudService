using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp5.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly DBContext dbContext;

        public TasksController(DBContext dB)
        {
            dbContext = dB;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<Tasks>>> GetTasks(int id)
        {
            return (await dbContext.tasks.ToListAsync()).Where(t => t.ImageId == id).ToList();

        }
        [HttpPost]
        public async void PostTasks(List<Tasks> tasks)
        {
            if(tasks == null) { return; }
            dbContext.tasks.AddRange(tasks);
            await dbContext.SaveChangesAsync();
        }
    }
}
