using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PomodoroCommon.Commands;
using PomodoroDomain;
using PomodoroInfra;

namespace PomodoroCommon
{
    public class TimesRepository : ITimeAmountRepository
    {
        private readonly TimeAmountHandler _commandHandler;
        private readonly PomodoroContext _context;
        private readonly IMapper _mapper;

        public TimesRepository(IMapper mapper)
        {
            _context = new PomodoroContext();
            _commandHandler = new TimeAmountHandler();
            _mapper = mapper;
        }

        public TimeAmount GetById(int id)
        {
            return _context.Times.FirstOrDefault(amount => amount.Id == id);
        }

        public ICollection<TimeAmount> GetAll()
        {
            return _context.Times.ToList();
        }

        public void Remove(int id)
        {
            if (_context.Times.Any(amount => amount.Id == id))
            {
                var time = _context.Times.FirstOrDefault(amount => amount.Id == id);
                _context.Times.Remove(time);
                _context.SaveChanges();
            }
        }

        public ICollection<TimeAmountDto> GetAllDtos()
        {
            return _context.Times
                .Select(amount => _mapper.Map<TimeAmountDto>(amount)).ToList();
        }

        public TimeAmountDto GetDtoById(int id)
        {
            return _context.Times
                .Where(amount => amount.Id == id)
                .Select(amount => new TimeAmountDto(amount))
                .FirstOrDefault();
        }

        public void Add(TimeAmount amount)
        {
            _context.Times.Add(amount);
            _context.SaveChanges();
        }

        public void Add(TimeAmountAddCmd amountAdd)
        {
            var newAmount = _commandHandler.Handle(amountAdd);
            Add(newAmount);
        }

        public void Update(TimeAmount newEntity)
        {
            _context.Times.Update(newEntity);
            _context.SaveChanges();
        }

        public void Update(TimeAmountUpdateCmd amountUpdate)
        {
            var newAmount = _commandHandler.Handle(amountUpdate);
            Update(newAmount);
        }
    }
}