using System;

namespace Timesheets.DAL.Entities
{
    public class TaskEntity : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public bool IsTaken { get; private set; }
        public DateTime IsTakenDate { get; private set; }
        public bool IsDone { get; private set; }
        public DateTime IsDoneDate { get; private set; }

        public int EmployeeId { get; set; }
        public EmployeeEntity Employee { get; set; }

        public int InvoiceId { get; set; }
        public InvoiceEntity Invoice { get; set; }

        public void Take()
        {
            if (!IsTaken)
            {
                IsTaken = true;
                IsTakenDate = DateTime.Now;
            }
        }

        public void Done()
        {
            if (!IsDone)
            {
                IsDone = true;
                IsDoneDate = DateTime.Now;
            }
        }
    }
}