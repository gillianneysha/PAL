using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace PAL.app.Models
{
    public class AKICSlotVM
    {
        public int AKICSlotId { get; set; }
        public string AKICCampus { get; set; }

       
        public string? UserId { get; set; }

       
        public int? AKICReservationId { get; set; }

       
        public string Status { get; set; }
    }
}
