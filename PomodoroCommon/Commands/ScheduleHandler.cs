using PomodoroApi.Commands;
using PomodoroDomain;
using PomodoroInfra;

namespace PomodoroCommom.Commands
{
    public class ScheduleHandler
    {
        private TimesRepository _timeRepository;

        public ScheduleHandler()
        {
            _timeRepository = new TimesRepository();
        }
        public Schedule Handle(ScheduleAddCmd command)
        {
            return new Schedule
            {
//                TimeAmounts = _timeRepository.GetRange(command.TimeAmounts);
            };
        }
        
        public Schedule Handle(ScheduleUpdateCmd command)
        {
            return new Schedule();
        }
    }
}