using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAL.DataModel
{
    public class CampusReservation
    {

            public int CampusReservationId { get; set; }
            public int SlotId { get; set; }
            public string? UserId { get; set; }
            public string Campus { get; set; }
            public string ContactNo { get; set; }
            public string PlateNo { get; set; }
        public bool Paid { get; set; }
        public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
      


    }
}
