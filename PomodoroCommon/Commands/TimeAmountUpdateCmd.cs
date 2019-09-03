using PomodoroDomain;

namespace PomodoroCommon.Commands
{
    public class TimeAmountUpdateCmd : ICommand
    {
        public int Id { get; set; }
        public int Lenght { get; set; }
        public ETimeType Type { get; set; }
    }
}