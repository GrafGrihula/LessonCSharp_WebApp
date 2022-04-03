using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using Timesheets.DAL.Entities;
using Timesheets.DAL.Repository.Interfaces;

namespace Timesheets.Services
{
    public class TaskService : IService<TaskDto>
    {
        private readonly ITaskRepository _repository;
        private readonly IMapper _mapper;

        public TaskService(ITaskRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Create(TaskDto item)
        {
            await _repository.Add(_mapper.Map<TaskEntity>(item));
        }

        public async Task Delete(int id)
        {
            var task = await _repository.Get(id);
            task.Delete();
            await _repository.Delete(task);
        }

        public async Task<TaskDto> Get(int id)
        {
            var task = await _repository.Get(id);
            return _mapper.Map<TaskDto>(task);
        }

        public async Task<IList<TaskDto>> GetAll()
        {
            var tasks = await _repository.GetAll();
            return _mapper.Map<List<TaskDto>>(tasks.Select(x => x.IsDeleted == false));
        }

        public async Task Update(TaskDto item)
        {
            var task = await _repository.Get(item.Id);
            task = _mapper.Map<TaskEntity>(item);
            await _repository.Update(task);
        }
    }
}
