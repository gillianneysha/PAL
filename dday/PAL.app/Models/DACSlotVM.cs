using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace PAL.app.Models
{
    public class DACSlotVM
    { 
        public int DACSlotId { get; set; }
       
        public string DACCampus { get; set; }

        
        public string? UserId { get; set; }

       
       
        public int? DACReservationId { get; set; }

 
       
        public string Status { get; set; }
    }
}
