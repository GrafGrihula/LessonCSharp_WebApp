using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.DAL.Repository.Interfaces
{
    interface IRepository<T>
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T item);
        Task<T> Update(T item);
        Task<T> Delete(int id);
    }
}
