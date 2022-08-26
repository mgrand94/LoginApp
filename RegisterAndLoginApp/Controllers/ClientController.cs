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
            ClientsDAO clients = new ClientsDAO();
                   
            return View(clients.GetAllClients());
        }
    }
}
