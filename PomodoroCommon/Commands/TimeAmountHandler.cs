using System;
using System.Linq;
using PomodoroApi.Commands;
using PomodoroDomain;

namespace PomodoroCommom.Commands
{
    public class TimeAmountHandler
    {
        private static readonly ETimeType[] _AlowedTypes =
            {ETimeType.LongBreak, ETimeType.ShortBreak, ETimeType.WorkTime};

        public TimeAmount Handle(TimeAmountAddCmd command)
        {
            if (command.Lenght <= 0 || _AlowedTypes.All(allowed => allowed != command.Type))
                throw new Exception("Invalid amount of time");

            return new TimeAmount
            {
                Lenght = new TimeSpan(0, command.Lenght, 0),
                Type = command.Type
            };
        }

        public TimeAmount Handle(TimeAmountUpdateCmd command)
        {
            if (command.Id <= 0 || command.Lenght <= 0 || _AlowedTypes.All(allowed => allowed != command.Type))
                throw new Exception("Invalid amount of time");

            return new TimeAmount
            {
                Id = command.Id,
                Lenght = new TimeSpan(0, command.Lenght, 0),
                Type = command.Type
            };
        }
    }
}