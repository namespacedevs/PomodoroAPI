using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PomodoroDomain;
using PomodoroInfra;

namespace PomodoroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesController : ControllerBase
    {
        private readonly TimesRepository _timesRepository;

        public TimesController()
        {
            _timesRepository = new TimesRepository();
        }

        [HttpGet]
        public ActionResult<ICollection<TimeAmount>> Get()
        {
            var data = _timesRepository.GetAll();
            return new ActionResult<ICollection<TimeAmount>>(data);
        }

        [HttpGet("{id}")]
        public ActionResult<TimeAmount> Get(int id)
        {
            return _timesRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] TimeAmount amount)
        {
            _timesRepository.Add(amount);
        }

        [HttpPut("{id}")]
        public void Put([FromBody] TimeAmount amount)
        {
            _timesRepository.Update(amount);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _timesRepository.Remove(id);
        }
    }
}