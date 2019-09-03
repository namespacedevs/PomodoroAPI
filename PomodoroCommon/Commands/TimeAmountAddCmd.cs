using PomodoroDomain;

namespace PomodoroCommon.Commands
{
    public class TimeAmountAddCmd : ICommand
    {
        public int Lenght { get; set; }
        public ETimeType Type { get; set; }
    }
}