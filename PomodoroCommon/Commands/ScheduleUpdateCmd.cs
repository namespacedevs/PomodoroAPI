namespace PomodoroApi.Commands
{
    public class ScheduleUpdateCmd
    {
        public int Id { get; set; }
        public int[] TimeAmounts { get; set; }
    }
}