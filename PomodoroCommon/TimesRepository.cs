using System.Collections.Generic;
using System.Linq;
using PomodoroCommom.Commands;
using PomodoroDomain;
using PomodoroInfra;

namespace PomodoroCommom
{
    public class TimesRepository
    {
        private readonly TimeAmountHandler _commandHandler;
        private readonly PomodoroContext _context;

        public TimesRepository()
        {
            _context = new PomodoroContext();
            _commandHandler = new TimeAmountHandler();
        }

        public ICollection<TimeAmountDto> GetAll()
        {
            return _context.Times
                .Select(amount => new TimeAmountDto(amount)).ToList();
        }

        public TimeAmount GetById(int id)
        {
            return _context.Times.FirstOrDefault(amount => amount.Id == id);
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

        public void Update(TimeAmount amount)
        {
            _context.Times.Update(amount);
            _context.SaveChanges();
        }

        public void Update(TimeAmountUpdateCmd amountUpdate)
        {
            var newAmount = _commandHandler.Handle(amountUpdate);
            Update(newAmount);
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
    }
}