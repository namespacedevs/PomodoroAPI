using PomodoroDomain;

namespace PomodoroCommom.Commands
{
    public class TimeAmountUpdateCmd
    {
        public int Id { get; set; }
        public int Lenght { get; set; }
        public ETimeType Type { get; set; }
    }
}