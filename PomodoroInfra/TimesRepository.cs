using System;
using System.Collections.Generic;
using System.Linq;
using PomodoroDomain;

namespace PomodoroInfra
{
    public class TimesRepository
    {
        private readonly PomodoroContext _context;

        public TimesRepository()
        {
            _context = new PomodoroContext();
        }

        public ICollection<TimeAmount> GetAll()
        {
            return _context.Times.ToList();
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

        public void Add(TimeAmountCmd amount)
        {
            var newAmount = new TimeAmount
            {
                Lenght = new TimeSpan(0, amount.Lenght, 0),
                Type = (ETimeType) amount.Type
            };

            Add(newAmount);
        }

        public void Update(TimeAmount amount)
        {
            _context.Times.Update(amount);
            _context.SaveChanges();
        }

        public void Update(TimeAmountCmd amount)
        {
            var newAmount = new TimeAmount
            {
                Lenght = new TimeSpan(0, amount.Lenght, 0),
                Type = (ETimeType) amount.Type
            };

            Update(newAmount);
        }

        public void Remove(int id)
        {
            if (_context.Times.Any(amount => amount.Id == id))
            {
                var time = _context.Times.FirstOrDefault(amount => amount.Id == id);
                _context.Times.Remove(time);
            }
        }
    }
}