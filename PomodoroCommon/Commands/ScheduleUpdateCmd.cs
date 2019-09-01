using System.Collections.Generic;

namespace PomodoroCommom.Commands
{
    public class ScheduleUpdateCmd
    {
        public int Id { get; set; }
        public ICollection<ScheduleItemCmd> ItemCmds { get; set; }
    }
}