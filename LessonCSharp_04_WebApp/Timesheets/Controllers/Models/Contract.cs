using System;
using System.Collections.Generic;

namespace Timesheets.Controllers.Models
{
    public class Contract
    {
        public int ContractId { get; set; }
        public string ContractName { get; set; }
        public string ContractDescription { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
