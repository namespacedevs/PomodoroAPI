using Microsoft.AspNetCore.Mvc;

namespace PomodoroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> WhereWeAre()
        {
            
            return new ActionResult<string>("sdfs");
        }
    }
}