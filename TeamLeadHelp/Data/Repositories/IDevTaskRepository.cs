using TeamLeadHelp.Models;

namespace TeamLeadHelp.Data.Repositories
{
    public interface IDevTaskRepository
    {
        Task<List<DevTask>> GetAll();
        Task<List<DevTask>> GetAllOnHold();
        Task<List<DevTask>> GetTasksInProgress();
        Task<DevTask> GetById(int id);
        Task<DevTask> Add(DevTask devTask);
        Task<DevTask> Update(DevTask devTask, int id);
        Task<DevTask> Delete(int id);
    }
}
