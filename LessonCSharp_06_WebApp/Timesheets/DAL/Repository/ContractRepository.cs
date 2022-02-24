using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.DAL.Entities;
using Timesheets.DAL.Repository.DataBase;
using Timesheets.DAL.Repository.Interfaces;

namespace Timesheets.DAL.Repository
{
    public class ContractRepository : IContractRepository
    {
        private readonly Context _context;

        public ContractRepository(Context context)
        {
            _context = context;
        }

        public async Task Add(ContractEntity item)
        {
            await _context.Contracts.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(ContractEntity item)
        {
            await Update(item);
        }

        public async Task<ContractEntity> Get(int id)
        {
            var contract = await _context.Contracts.FindAsync(id);
            if (contract == null || contract.IsDeleted)
            {
                throw new ArgumentException("Контракт не найден!");
            }
            return contract;
        }

        public async Task<IEnumerable<ContractEntity>> GetAll()
        {
            return await _context
                .Contracts
                .Where(x => x.IsDeleted == false)
                .ToListAsync();
        }

        public async Task Update(ContractEntity item)
        {
            _context.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}