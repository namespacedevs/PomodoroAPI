using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PomodoroCommon;
using PomodoroCommon.Commands;
using PomodoroDomain;

namespace PomodoroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITimeAmountRepository _timesRepository;

        public TimesController(IMapper mapper, ITimeAmountRepository timeAmountRepository)
        {
            _timesRepository = timeAmountRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<TimeAmountDto>> Get()
        {
            var data = _timesRepository.GetAllDtos();
            return new ActionResult<ICollection<TimeAmountDto>>(data);
        }

        [HttpGet("{id}")]
        public ActionResult<TimeAmountDto> Get(int id)
        {
            return _mapper.Map<TimeAmountDto>(_timesRepository.GetById(id));
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