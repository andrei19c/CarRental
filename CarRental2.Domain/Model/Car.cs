using System;
using System.Collections.Generic;

#nullable disable

namespace CarRental2.Domain.Model
{
    public partial class Car
    {
        public int Id { get; set; }
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

        public virtual CarGroup CarGroup { get; set; }
    }
}
