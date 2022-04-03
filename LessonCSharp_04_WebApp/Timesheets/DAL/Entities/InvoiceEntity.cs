using System;

namespace Timesheets.DAL.Entities
{
    public class InvoiceEntity : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}
