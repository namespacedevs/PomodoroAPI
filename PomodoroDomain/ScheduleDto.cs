using System.Collections.Generic;

namespace PomodoroDomain
{
    public class ScheduleDto
    {
        public int Id { get; set; }
        public EScheduleStatus Status { get; set; }
        public virtual ICollection<ScheduleItemDto> Items { get; set; }
    }
}