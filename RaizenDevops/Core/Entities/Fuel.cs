using System;

namespace RaizenDevops.Core.Entities
{
    public class Fuel : BaseEntity
    {
        protected Fuel()
        {

        }

        public Fuel(string fuelName, string description, int value, DateTime date) : base()
        {
            FuelName = fuelName;
            Description = description;
            Value = value;
            Date = date;
        }

        public string FuelName { get; private set; }
        public string Description { get; private set; }
        public int Value { get; private set; }
        public DateTime Date { get; private set; }

        public void Update(string description, int value)
        {
            Description = description;
            Value = value;
        }
    }
}
