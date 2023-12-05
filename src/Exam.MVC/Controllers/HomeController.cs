using Exam.Business.Services.Interfaces;
using Exam.Core.Models;
using Exam.Core.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Exam.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        public HomeController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IActionResult> IndexAsync()
        {

            List<Slider> sliders = await _sliderService.GetAllAsync();
            return View(sliders);
          
        }

     
    
    }
}
