using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PomodoroDomain;
using PomodoroDomain.Commands;
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
        public ActionResult<ICollection<TimeAmountDto>> Get()
        {
            var data = _timesRepository.GetAll();
            return new ActionResult<ICollection<TimeAmountDto>>(data);
        }

        [HttpGet("{id}")]
        public ActionResult<TimeAmount> Get(int id)
        {
            return _timesRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] TimeAmountAddCmd amountAdd)
        {
            _timesRepository.Add(amountAdd);
        }

        [HttpPut("{id}")]
        public void Put([FromBody] TimeAmountUpdateCmd amountAdd)
        {
            _timesRepository.Update(amountAdd);
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
            _timesRepository.Remove(id);
        }
    }
}