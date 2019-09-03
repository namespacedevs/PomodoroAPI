using System.Collections.Generic;
using PomodoroCommon.Commands;
using PomodoroDomain;

namespace PomodoroCommon
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        ICollection<ScheduleDto> GetAllDtos();
        ScheduleDto GetDtoById(int id);
        void Update(ScheduleUpdateCmd updateCommand);
        void Add(ScheduleAddCmd updateCommand);
        bool Pause(int id);
    }
}