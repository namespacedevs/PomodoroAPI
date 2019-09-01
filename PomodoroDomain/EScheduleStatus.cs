using System;

namespace PomodoroDomain
{
    [Flags]
    public enum EScheduleStatus
    {
        Running,
        Paused,
        Stopped
    }
}