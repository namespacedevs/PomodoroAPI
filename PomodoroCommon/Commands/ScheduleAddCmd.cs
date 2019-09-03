using System.Collections.Generic;

namespace PomodoroCommon.Commands
{
    public class ScheduleAddCmd
    {
        public ICollection<ScheduleItemCmd> ItemCmds { get; set; }
    }
}