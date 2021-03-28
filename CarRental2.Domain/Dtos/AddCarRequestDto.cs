using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental2.Domain.Dtos
{
    public class AddCarRequestDto
    {
        public string Manufacture { get; set; }
        public string Model { get; set; }
        public short Year { get; set; }
        public string Vin { get; set; }
        public string Description { get; set; }
        public string Observation { get; set; }
        public int CarGroupId { get; set; }
        public decimal? StandardPrice { get; set; }
        public bool? IsAvailable { get; set; }
    }
}
