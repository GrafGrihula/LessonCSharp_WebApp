using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using Timesheets.DAL.Entities;
using Timesheets.DAL.Repository.Interfaces;

namespace Timesheets.Services
{
    public class CustomerService : IService<CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IContractRepository _contractRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository,
                               IContractRepository contractRepository,
                               IMapper mapper)
        {
            _customerRepository = customerRepository;
            _contractRepository = contractRepository;
            _mapper = mapper;
        }

        public async Task Create(CustomerDto item)
        {
            await _customerRepository.Add(_mapper.Map<CustomerEntity>(item));
        }

        public async Task Delete(int id)
        {
            var customer = await _customerRepository.Get(id);
            ClearingCustomer(customer).Wait();
            customer.Delete();
            await _customerRepository.Delete(customer);
        }

        public async Task<CustomerDto> Get(int id)
        {
            var customer = await _customerRepository.Get(id);
            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task<IList<CustomerDto>> GetAll()
        {
            var customers = await _customerRepository.GetAll();
            return _mapper.Map<List<CustomerDto>>(customers.Select(x => x.IsDeleted == false));
        }

        public async Task Update(CustomerDto item)
        {
            var customer = await _customerRepository.Get(item.Id);
            customer.Name = item.Name;
            await _customerRepository.Update(customer);
        }

        private async Task ClearingCustomer(CustomerEntity customer)
        {
            foreach (var contract in customer.Contracts)
            {
                contract.Delete();
                await _contractRepository.Delete(contract);
            }
        }
    }
}
