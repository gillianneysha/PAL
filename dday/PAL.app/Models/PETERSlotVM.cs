using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace PAL.app.Models
{
    public class PETERSlotVM
    {
        public int PETERSlotId { get; set; }
     
        public string PETERCampus { get; set; }
        
        public string? UserId { get; set; }
        
        public int? PETERReservationId { get; set; }
       
        public string Status { get; set; }
    }
}
