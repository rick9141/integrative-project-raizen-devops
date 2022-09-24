using System;

namespace RaizenDevops.Models.InputModels
{
    public class AddFuelInputModel
    {
        public string FuelName { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }
}
