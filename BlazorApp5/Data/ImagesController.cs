using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp5.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly DBContext dbContext;

        public ImagesController(DBContext dB)
        {
            dbContext = dB;
        }

        [HttpGet]
        public async Task<ActionResult<List<Image>>> GetImages()
        {
            return (await dbContext.images.ToListAsync()).ToList();

        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Image>> GetImages(int id)
        {
            return await dbContext.images.FirstOrDefaultAsync(i => i.ProblemId == id);

        }
        [HttpPost]
        public async void PostImage(Image image)
        {
            if (image == null) { return; }
            dbContext.images.Add(image);
            await dbContext.SaveChangesAsync();
        }
    }
}
