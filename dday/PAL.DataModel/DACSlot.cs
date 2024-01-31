using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAL.DataModel
{
    public class DACSlot
    {
        public int DACSlotId { get; set; }
        public string DACCampus { get; set; }
        public string? UserId { get; set; } //foreign key
        public int? DACReservationId { get; set; } //foreign key
        public string Status { get; set; }


    }
}
