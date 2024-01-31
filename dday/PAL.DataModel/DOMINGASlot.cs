using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAL.DataModel
{
    public class DOMINGASlot
    {
        public int DOMINGASlotId { get; set; }
        public string DOMINGACampus { get; set; }
        public string? UserId { get; set; } //foreign key
        public int? DOMINGAReservationId { get; set; } //foreign key
        public string Status { get; set; }
    }
}
