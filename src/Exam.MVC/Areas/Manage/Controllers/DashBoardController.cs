using Microsoft.AspNetCore.Mvc;

namespace Exam.MVC.Areas.Manage.Controllers
{
    public class DashBoardController : Controller
    {
        [Area("manage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
