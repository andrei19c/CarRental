using System;
using System.Collections.Generic;

#nullable disable

namespace CarRental2.Domain.Model
{
    public partial class CarGroup
    {
        public CarGroup()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
