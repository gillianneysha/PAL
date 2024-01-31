using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace PAL.app.Models
{
    public class DOMINGASlotVM
    {
        public int DOMINGASlotId { get; set; }

        public string DOMINGACampus { get; set; }
       
        public string? UserId { get; set; }
        
        public int? DOMINGAReservationId { get; set; }
        
        public string Status { get; set; }
    }
}
