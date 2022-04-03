using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using Timesheets.DAL.Repository.Interfaces;

namespace Timesheets.Services
{
    public class InvoiceService : IService<InvoiceDto>
    {
        private readonly IInvoiceRepository _repository;
        private readonly IMapper _mapper;

        public InvoiceService(IInvoiceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task Create(InvoiceDto item)
        {
            throw new Exception("Счет создается автоматически!");
        }

        public async Task Delete(int id)
        {
            var invoice = await _repository.Get(id);
            invoice.Delete();
            await _repository.Delete(invoice);
        }

        public async Task<InvoiceDto> Get(int id)
        {
            var invoice = await _repository.Get(id);
            return _mapper.Map<InvoiceDto>(invoice);
        }

        public async Task<IList<InvoiceDto>> GetAll()
        {
            var invoices = await _repository.GetAll();
            return _mapper.Map<List<InvoiceDto>>(invoices.Select(x => x.IsDeleted == false));
        }

        public async Task Update(InvoiceDto item)
        {
            var invoice = await _repository.Get(item.Id);
            invoice.Pay();
            await _repository.Update(invoice);
        }
    }
}