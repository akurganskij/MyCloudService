using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp5.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProblemsController : ControllerBase
    {
        private readonly DBContext dbContext;

        public ProblemsController(DBContext dB)
        {
            dbContext = dB;
        }

        [HttpGet]
        public async Task<ActionResult<List<Problems>>> GetProblems()
        {
            return (await dbContext.problems.ToListAsync()).ToList();

        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Problems>> GetProblem(int id)
        {
            return await dbContext.problems.FirstOrDefaultAsync(p => p.Id == id);

        }
        [HttpPost]
        public async void PostProblem(Problems problems)
        {
            if (problems == null) { return; }
            Console.WriteLine("Done");
            dbContext.problems.Add(problems);
            await dbContext.SaveChangesAsync();
        }
    }
}
