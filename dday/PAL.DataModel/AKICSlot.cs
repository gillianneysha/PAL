
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAL.DataModel
{
    public class AKICSlot
    {   
        public int AKICSlotId { get; set; }
        public string AKICCampus { get; set; }
        public string? UserId { get; set; } //foreign key
        public int? AKICReservationId { get; set; } //foreign key
        public string Status { get; set; }
    }
}
