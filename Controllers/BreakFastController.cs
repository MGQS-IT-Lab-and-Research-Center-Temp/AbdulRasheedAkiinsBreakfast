using AkiinsBreakfast.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace AkiinsBreakfast.Controllers
{
    public class BreakfastController : Controller
    {
        private readonly IBreakfastService _breakfastservice;
        public BreakFastController(IBreakfastService breakFastService)
        {
            _breakfastservice = breakFastService;
        }
        // GET: BreakFastController
        public IActionResult Index()
        {
            var breakfast = _breakfastservice.PrintAllBreakFast();
            return View(breakfast.Data);
        }

        // GET: BreakFastController/Details/5
        public IActionResult Details(int id)
        {
            var breakfast = _breakfastservice.GetBreakFast(id);
            if (breakfast.Status == false)
            {
                ViewBag.Message = breakfast.Message;
                return View();
            }
            return View(breakfast.Data);
        }

        // GET: BreakFastController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BreakFastController/Create
        [HttpPost]
        public IActionResult Create(BreakFastDto breakFast)
        {
            var breakfast = _breakfastservice.CreateBreakFast(breakFast);
            if (breakfast.Status == false)
            {
                ViewBag.Message = breakfast.Message;
                return View();
            }
            return RedirectToAction("Index");

        }

        // GET: BreakFastController/Edit/5
        public IActionResult Update()
        {
            return View();
        }

        // POST: BreakFastController/Edit/5
        [HttpPost]
        public IActionResult Update(int id, UpdateBreakfastDTO updateBreakfastDTO)
        {
            var breakfast = _breakfastservice.UpdateBreakFast(id, updateBreakfastDTO);
            if (breakfast.Status == false)
            {
                ViewBag.Message = breakfast.Message;
                return View();

            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBreakfast(int id)
        {
            var breakfast = _breakfastservice.GetBreakFast(id);
            return View(breakfast);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var breakFast = _breakfastservice.DeleteBreakFast(id);
            if (breakFast.Status == false)
            {
                ViewBag.Message = breakFast.Message;
                return View();

            }
            return RedirectToAction("Index");
        }
    }
}
