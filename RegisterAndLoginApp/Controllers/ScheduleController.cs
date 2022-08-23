using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Controllers
{
    public class ScheduleController : Controller
    {
        // list of appoinments
        static List<ScheduleModel> appoinments = new List<ScheduleModel>();
        public IActionResult Index()
        {
            return View(appoinments);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(ScheduleModel appointment)
        {
            //adds to the appointments list
            appoinments.Add(appointment);
            return View("Details", appointment); 
        }
    }
}
