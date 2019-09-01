using System.Collections.Generic;

namespace PomodoroCommom.Commands
{
    public class ScheduleAddCmd
    {
        public ICollection<ScheduleItemCmd> ItemCmds { get; set; }
    }
}