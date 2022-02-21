using Microsoft.AspNetCore.Mvc;
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

    
    }
}
