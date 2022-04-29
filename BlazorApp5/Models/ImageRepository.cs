namespace BlazorApp5.Models
{
    public interface IImageRepository
    {
        Task<Image> Get(int id);
        Task<List<Image>> GetAll();
    }

    public class ImageRepository : IImageRepository
    {
        private DBContext _dbContext;
        public ImageRepository(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<Image> Get(int id)
        {
            return await _dbContext.images.FindAsync(id);
        }
        public async Task<List<Image>> GetAll()
        {
            return _dbContext.images.ToList();
        }
    }
}
