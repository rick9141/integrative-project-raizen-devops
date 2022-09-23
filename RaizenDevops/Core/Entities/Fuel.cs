using System;

namespace RaizenDevops.Core.Entities
{
    public class Fuel
    {
        protected Fuel()
        {

        }

        public Fuel(string description, int value, DateTime date) : base()
        {
            Description = description;
            Value = value;
            Date = date;
        }

        public string Description { get; private set; }
        public int Value { get; private set; }
        public DateTime Date { get; private set; }

        public void Update(string description, int value, DateTime date)
        {
            Description = description;
            Value = value;
            Date = date;
        }
    }
}
