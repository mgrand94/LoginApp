using Bogus;
using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Services;

namespace RegisterAndLoginApp.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            HardCodedSampleRepo hardCodedSampleRepo = new HardCodedSampleRepo();
                   
            return View(hardCodedSampleRepo.GetAllClients());
        }
    }
}
