using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAL.DataModel
{
    public class PETERSlot
    {
        public int PETERSlotId { get; set; }
        public string PETERCampus { get; set; }
        public string? UserId { get; set; } //foreign key
        public int? PETERReservationId { get; set; } //foreign key
        public string Status { get; set; }
    }
}
