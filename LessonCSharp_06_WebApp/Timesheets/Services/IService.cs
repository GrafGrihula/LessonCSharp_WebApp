using System.Collections.Generic;
using System.Threading.Tasks;

namespace Timesheets.Services
{
    public interface IService<T> where T : class
    {
        Task Create(T item);
        Task Update(T item);
        Task Delete(int id);
        Task<T> Get(int id);
        Task<IList<T>> GetAll();
    }
}
