using System;
using System.Collections.Generic;
using System.Linq;
using PomodoroApi.Commands;
using PomodoroCommom.Commands;
using PomodoroDomain;

namespace PomodoroInfra
{
    public class ScheduleRepository
    {
        private readonly ScheduleHandler _commandHandler;
        private readonly PomodoroContext _context;

        public ScheduleRepository()
        {
            _context = new PomodoroContext();
            _commandHandler = new ScheduleHandler();
        }

        public ICollection<Schedule> GetAll()
        {
            return _context.Schedules.ToList();
        }

        public Schedule GetById(int id)
        {
            return _context.Schedules.FirstOrDefault(schedule =>  schedule.Id == id);
        }

        public void Add(Schedule schedule)
        {
            _context.Schedules.Add(schedule);
            _context.SaveChanges();
        }

        public void Add(ScheduleAddCmd command)
        {
            var newAmount = _commandHandler.Handle(command);
            Add(newAmount);
        }

        public void Update(Schedule schedule)
        {
            _context.Schedules.Update(schedule);
            _context.SaveChanges();
        }

        public void Update(ScheduleUpdateCmd command)
        {
            var newAmount = _commandHandler.Handle(command);
            Update(newAmount);
        }

        public void Remove(int id)
        {
            if (_context.Schedules.Any(schedule => schedule.Id == id))
            {
                var sched = _context.Schedules.FirstOrDefault(schedule => schedule.Id == id);
                _context.Schedules.Remove(sched ?? throw new Exception("Item does not exists"));
                _context.SaveChanges();
            }
        }
    }
}