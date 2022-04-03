using System;

namespace Timesheets.DAL.Entities
{
    public class TimeSheetEntity : BaseEntity
    {
        public string Name { get; set; }
        public DateTimeOffset SpentTime { get; set; }
    }
}
