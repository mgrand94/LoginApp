using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegisterAndLoginApp.Models
{
    public class ScheduleModel
    {
        [Required] // All fields required
        [DisplayName("Client's Full Name:")]
        public string ClientName { get; set; }
        [DisplayName("Client's Insurance:")]
        public string ClientInsurance { get; set; }
        [DisplayName("Client's Total hours:")]
        public int TotalHours { get; set; }
        [DisplayName("Client's Hours Left:")]

        public int HoursUsed { get; set; }

        [DisplayName("Appointment Date:")]

        [DataType(DataType.Date)] //Appointment date
        public DateTime AppointmentDate { get; set; }
        [DisplayName("Therapist Assigned:")]
        public string TherapistName { get; set; }
    }
}
