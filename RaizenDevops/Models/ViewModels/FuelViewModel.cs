using System;

namespace RaizenDevops.Models
{
    public class FuelViewModel
    {
        public FuelViewModel(int id, string description, int value, DateTime date)
        {
            Id = id;
            Description = description;
            Value = value;
            Date = date;
        }

        public int Id { get; private set; }
        public string Description { get; private set; }
        public int Value { get; private set; }
        public DateTime Date { get; set; }
    }
}
}
