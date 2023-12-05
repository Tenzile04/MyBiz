using Exam.Business.CustomExceptions.SliderExceptions;
using Exam.Business.Services.Interfaces;
using Exam.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization;

namespace Exam.MVC.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;
        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _sliderService.GetAllAsync();
            return View(sliders);
        }
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();

              

            try { await _sliderService.CreatAsync(slider);}

            catch (InvalidContentTypeException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch (InvalidImageSizeException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch (InvalidImageFileException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }

            return RedirectToAction("index");
        }
        public async Task<IActionResult> Update(int id)
        {
            if (id == null) return View();
            Slider existSlider = await _sliderService.GetAsync(id);

            if (existSlider == null) return NotFound();

            return View(existSlider);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Slider slider)
        {
            if (!ModelState.IsValid) return View();
            try
            {
                await _sliderService.UpdateAsync(slider);
            }
            catch (InvalidContentTypeException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch (InvalidImageSizeException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch (InvalidImageFileException ex)
            {
                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch (InvalidNullReferanceException) { }



            return RedirectToAction("index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _sliderService.DeleteAsync(id);
            }
            catch (Exception) { }

            return RedirectToAction("index");
        }
    }
}
