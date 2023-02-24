using TeamLeadHelp.Models;

namespace TeamLeadHelp.Data.Repositories
{
    public interface IDevTaskRepository
    {
        Task<IEnumerable<DevTask>> GetAll();
        Task<IEnumerable<DevTask>> GetAllOnHold();
        Task<IEnumerable<DevTask>> GetTasksInProgress();
        Task<DevTask> GetById(int id);
        Task<DevTask> Add(DevTask product);
        Task<DevTask> Update(DevTask product);
        Task<DevTask> Delete(int id);
    }
}
