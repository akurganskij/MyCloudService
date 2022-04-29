namespace BlazorApp5.Models
{
    public interface ITaskRepository
    {
        Task<List<Tasks>> GetAll(int imageId);
    }

    public class TaskRepository : ITaskRepository
    {
        private DBContext _dbContext;
        public TaskRepository(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<List<Tasks>> GetAll(int imageId)
        {
            return _dbContext.tasks.ToList();
        }
    }
}
