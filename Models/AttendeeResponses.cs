using System.Collections.Generic;

namespace RSVP_Party_Invite_website.Models
{
    public class AttendeeResponses
    {
        private static List<PartyInvites> responses = new List<PartyInvites>();

        public static IEnumerable<PartyInvites> Responses => responses;

        public static void AddResponse(PartyInvites response) => responses.Add(response);

    }
}
