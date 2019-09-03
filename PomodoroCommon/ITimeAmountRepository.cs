using System.Collections.Generic;
using PomodoroCommon.Commands;
using PomodoroDomain;

namespace PomodoroCommon
{
    public interface ITimeAmountRepository : IRepository<TimeAmount>
    {
        ICollection<TimeAmountDto> GetAllDtos();
        TimeAmountDto GetDtoById(int id);
        void Update(TimeAmountUpdateCmd updateCommand);
        void Add(TimeAmountAddCmd updateCommand);
    }
}