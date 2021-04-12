using Microsoft.AspNetCore.Mvc;
using RSVP_Party_Invite_website.Models;
using System.Linq;

namespace RSVP_Party_Invite_website.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Invitation()
        {
            // Creates a blank form
            return View();
        }

        [HttpPost]
        public IActionResult Invitation(PartyInvites willAttend)
        {
            // Stores the answer
            if (ModelState.IsValid)
            {
                AttendeeResponses.AddResponse(willAttend);
                return View("ThankYou", willAttend);
            }
            else {
                return View();
            }
        }

        public IActionResult Attendants()
        {
            return View(AttendeeResponses.Responses.Where(r => r.Confirmation == true));
        }

    }
}
