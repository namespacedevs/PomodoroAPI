using Microsoft.AspNetCore.Mvc;
using PomodoroCommom;

namespace PomodoroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly ScheduleRepository _scheduleRepository;

        public ScheduleController()
        {
            _scheduleRepository = new ScheduleRepository();
        }

        [HttpGet]
        public ActionResult<string> WhereWeAre()
        {
            var placeInTime = _scheduleRepository.GetNow(1);
            return new ActionResult<string>("Stub");
        }
    }
}