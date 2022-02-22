using Microsoft.AspNetCore.Mvc;
using SampleWebpage.Models;
using SampleWebpage.Services;
using SampleWebpage.Services.Interface;

namespace SampleWebpage.Controllers
{
    public class AdminController : Controller

    {
        ICollectServices CollectServices;
        public AdminController(ICollectServices CollectService)
        {
            this.CollectServices=CollectService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult indexPage()
        {
            var result=CollectServices.GetAll();
            return View(result);
        }
        
        public IActionResult Create(Collect collect)
        {
            try
            {
                var result = CollectServices.Add(collect);
                return View(collect);

            }
            catch (Exception ex)
            {

                throw;
            }
            return View();
        }
        public IActionResult Delete()
        {

            return View();
        }

    }
}
