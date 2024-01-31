using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace PAL.app.Models
{
    public class CampusReservationVM
    {

        public int CampusReservationId { get; set; }
        public int SlotId { get; set; }
        
        public string? UserId { get; set; }
        public string Campus { get; set; }
        [Required(ErrorMessage = "Contact No. is required.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Contact No. should have 11 characters")]
        public string ContactNo { get; set; }
        [Required(ErrorMessage = "Plate No. is required.")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Plate No. should be between 6 and 10 characters.")]
        public string PlateNo { get; set; }
        [Required(ErrorMessage = "Start time is required.")]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }
        [Required(ErrorMessage = "End time is required.")]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }
        public bool Paid { get; set; }
    }
}
