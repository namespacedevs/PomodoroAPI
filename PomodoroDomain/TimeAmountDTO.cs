using System;

namespace PomodoroDomain
{
    public class TimeAmountDto
    {
        public TimeAmountDto(TimeAmount amount)
        {
            Id = amount.Id;
            Length = amount.Lenght;
            Type = amount.Type.ToString();
        }

        public int Id { get; set; }
        public TimeSpan Length { get; set; }
        public string Type { get; set; }
    }
}