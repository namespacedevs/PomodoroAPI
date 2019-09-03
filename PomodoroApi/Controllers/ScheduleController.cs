using Microsoft.AspNetCore.Mvc;
using PomodoroCommon;
using PomodoroCommon.Commands;

namespace PomodoroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly ScheduleHandler _scheduleHandler;
        private readonly IScheduleRepository _scheduleRepository;

        public ScheduleController(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
            _scheduleHandler = new ScheduleHandler();
        }

        [HttpPost]
        public void Create([FromBody] ScheduleAddCmd command)
        {
            var newSchedule = _scheduleHandler.Handle(command);
            _scheduleRepository.Add(newSchedule);
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult<bool> Pause([FromRoute] int id)
        {
            return _scheduleRepository.Pause(id);
        }
    }
}