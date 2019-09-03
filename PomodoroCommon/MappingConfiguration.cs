using AutoMapper;
using PomodoroDomain;

namespace PomodoroCommon
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<Schedule, ScheduleDto>();
            CreateMap<TimeAmount, TimeAmountDto>();
        }
    }
}