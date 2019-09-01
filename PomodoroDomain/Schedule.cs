using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PomodoroDomain
{
    [Table("Schedules")]
    public class Schedule
    {
        [Key] public int Id { get; set; }
        [Required] public virtual ICollection<ScheduleItem> Items { get; set; }
    }
}