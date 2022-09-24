using System;

namespace RaizenDevops.Models
{
    public class FuelViewModel
    {
        public FuelViewModel(int id, string fuelName, string description, int value, DateTime date)
        {
            Id = id;
            FuelName = fuelName;
            Description = description;
            Value = value;
            Date = date;
        }

        public int Id { get; set; }
        public string FuelName { get; set; }
        public string Description { get; private set; }
        public int Value { get; private set; }
        public DateTime Date { get; set; }
    }
}
