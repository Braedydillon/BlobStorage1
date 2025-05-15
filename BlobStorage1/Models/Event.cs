using System.ComponentModel.DataAnnotations;

namespace BlobStorage1.Models
{
    public class Event
    {


        [Key] public int EventID { get; set; }
        [Required, StringLength(30)]

        public string? EventName { get; set; }
        [Required, StringLength(1000)]

        public string? Description { get; set; }
        [Display(Name = "Event Specific Data ")]

        [Required, StringLength(100)]

        public String? EventSpecificInfo { get; set; }

        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; } // Stores the event date

        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; } // Stores the event start time

        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; } // Stores the event end time

        // Increased length to handle long URLs
        [StringLength(500)]
        public string? EventImage { get; set; }



    }
}
