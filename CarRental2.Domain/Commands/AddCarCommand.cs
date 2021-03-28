using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental2.Domain.Model;
using MediatR;

namespace CarRental2.Domain.Commands
{
    public class AddCarCommand : IRequest<AddCarResponseDto>
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
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
