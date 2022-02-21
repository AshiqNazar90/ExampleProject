using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebpage.Models;
using SampleWebpage.Services;
using SampleWebpage.Services.Interface;

namespace SampleWebpage.Controllers
{
    public class CollectController : Controller
    {
        ICollectServices CollectServices;

        public CollectController(ICollectServices CollectServices)
        {
            this.CollectServices = CollectServices;
        }
        // GET: CollectController
        public ActionResult Index()
        {
            return View();
        }


        // POST: CollectController/Create
        [HttpPost]
        public ActionResult AddCollect(Collect collect)
        {
            CollectServices.Add(collect);
            return View();
        }
    }
}