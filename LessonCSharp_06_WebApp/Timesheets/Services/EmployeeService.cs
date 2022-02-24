using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using Timesheets.DAL.Entities;
using Timesheets.DAL.Repository.Interfaces;

namespace Timesheets.Services
{
    public class EmployeeService : IService<EmployeeDto>
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Create(EmployeeDto item)
        {
            await _repository.Add(_mapper.Map<EmployeeEntity>(item));
        }

        public async Task Delete(int id)
        {
            var employee = await _repository.Get(id);
            employee.Delete();
            await _repository.Delete(employee);
        }

        public async Task<EmployeeDto> Get(int id)
        {
            var employee = await _repository.Get(id);
            return _mapper.Map<EmployeeDto>(employee);
        }

        public async Task<IList<EmployeeDto>> GetAll()
        {
            var employees = await _repository.GetAll();
            return _mapper.Map<List<EmployeeDto>>(employees.Select(x => x.IsDeleted == false));
        }

        public async Task Update(EmployeeDto item)
        {
            var employee = await _repository.Get(item.Id);
            employee.Name = item.Name;
            await _repository.Update(employee);
        }
    }
}
