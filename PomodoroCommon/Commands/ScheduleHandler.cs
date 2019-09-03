using System.Linq;
using PomodoroDomain;

namespace PomodoroCommon.Commands
{
    public class ScheduleHandler
    {
        private readonly ScheduleRepository _scheduleRepository;

        public ScheduleHandler()
        {
            _scheduleRepository = new ScheduleRepository();
        }

        public Schedule Handle(ScheduleAddCmd command)
        {
            return new Schedule
            {
                Items = command.ItemCmds.Select(cmd => new ScheduleItem
                {
                    OrderNumber = cmd.OrderNumber,
                    TimeAmountId = cmd.TimeAmountId
                }).ToList()
            };
        }

        public Schedule Handle(ScheduleUpdateCmd command)
        {
            var schedule = _scheduleRepository.GetById(command.Id);

            schedule.Items = command.ItemCmds.Select(cmd => new ScheduleItem
            {
                OrderNumber = cmd.OrderNumber,
                TimeAmountId = cmd.TimeAmountId
            }).ToList();

            return schedule;
        }
    }
}