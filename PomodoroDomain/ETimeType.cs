using System;

namespace PomodoroDomain
{
    [Flags]
    public enum ETimeType
    {
        ShortBreak = 1,
        LongBreak = 2,
        WorkTime = 3
    }
}