using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace PomodoroDomain
{
    public class ScheduleItem
    {
        [Key] public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int TimeAmountId { get; set; }
        [Required][ForeignKey("TimeAmountId")] public virtual TimeAmount TimeAmount { get; set; }
    }
}