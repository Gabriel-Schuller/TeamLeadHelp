using Microsoft.EntityFrameworkCore;
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
            await _context.Tasks.AddAsync(devTask);
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

        public async Task<List<DevTask>> GetAll()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<List<DevTask>> GetAllOnHold()
        {
            return await _context.Tasks.Where(d => d.OnHold).ToListAsync();
        }

        public async Task<DevTask> GetById(int id)
        {
            return await _context.Tasks.FindAsync(id);

        }

        public async Task<List<DevTask>> GetTasksInProgress()
        {
            return await _context.Tasks.Where(d => !d.IsFinished).ToListAsync();

        }

        public async Task<DevTask> Update(DevTask devTask, int id)
        {
            var oldTask = await _context.Tasks.FindAsync(id);
            if (oldTask == null) return null;
            _context.Tasks.Remove(oldTask);
            devTask.ID = id;
            await _context.Tasks.AddAsync(devTask);
            await _context.SaveChangesAsync();
            return devTask;
        }
    }
}
