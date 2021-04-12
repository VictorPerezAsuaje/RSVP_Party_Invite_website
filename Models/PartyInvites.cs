using System.ComponentModel.DataAnnotations;

namespace RSVP_Party_Invite_website.Models
{
    public class PartyInvites
    {
        [Required(ErrorMessage = "Please enter your full name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please indicate if you will attend.")]
        public bool? Confirmation { get; set; }

    }
}
