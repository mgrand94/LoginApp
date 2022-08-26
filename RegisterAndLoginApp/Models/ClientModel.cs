using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegisterAndLoginApp.Models
{
    public class ClientModel
    {
        [Required]
        [DisplayName("Client Name:")]
        public string ClientName { get; set; }

        [DisplayName("Client Age:")]
        public int ClientAge { get; set; }

        [DisplayName("Client Insurance:")]
        public string ClientInsurance { get; set; }

        [DisplayName("Allowed Insurance Hours:")]
        public decimal ClientAllowedHours { get; set; }

        [DisplayName("BCBA Name:")]
        public string ClientBcba { get; set; }

        [DisplayName("Client Main Contact:")]
        public string MainContact { get; set; }

        [DisplayName("Main Contact Phone Number:")]
        public string MainContactNumber { get; set; }

    }
}
