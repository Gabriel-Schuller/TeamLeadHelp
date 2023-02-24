using TeamLeadHelp.Models;

namespace TeamLeadHelp.Data.Repositories
{
    public class DevTaskRepository : IDevTaskRepository
    {
        private readonly DevTaskContext _context;

        public DevTaskRepository(DevTaskContext context)
        {
            _context = context;
        }
        public async Task<DevTask> Add(DevTask devTask)
        {
            _context.Tasks.AddAsync(devTask);
            await _context.SaveChangesAsync();
            return devTask;
        }

        public async Task<DevTask> Delete(int id)
        {
            var devTask = await _context.Tasks.FindAsync(id);
            if (devTask == null) return null;
            _context.Tasks.Remove(devTask);
            await _context.SaveChangesAsync();
            return devTask;
        }

        public Task<IEnumerable<DevTask>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DevTask>> GetAllOnHold()
        {
            throw new NotImplementedException();
        }

        public Task<DevTask> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DevTask>> GetTasksInProgress()
        {
            throw new NotImplementedException();
        }

        public Task<DevTask> Update(DevTask devTask)
        {
            throw new NotImplementedException();
        }
    }
}
