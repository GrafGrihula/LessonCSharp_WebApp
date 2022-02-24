using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.DAL.Entities
{
    public class ContractEntity : BaseEntity
    {
        public string Name { get; set; }
        public List<EmployeeEntity> EmployeeEntities { get; set; }
    }
}
