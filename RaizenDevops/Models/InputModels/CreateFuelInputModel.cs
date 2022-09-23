using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaizenDevops.Models.InputModels
{
    public class CreateFuelInputModel
    {
        public string Description { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }
}
