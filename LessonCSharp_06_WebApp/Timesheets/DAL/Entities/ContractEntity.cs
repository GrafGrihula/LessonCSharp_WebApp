using System;

namespace Timesheets.DAL.Entities
{
    public class ContractEntity : BaseEntity
    {
        public string Name { get; set; }

        public int CustomerId { get; set; }
        public CustomerEntity Customer { get; set; }

        public int InvoiceId { get; set; }
        public InvoiceEntity Invoice { get; init; }


    }
}