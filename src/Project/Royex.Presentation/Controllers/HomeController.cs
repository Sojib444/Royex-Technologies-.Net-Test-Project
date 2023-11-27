using MediatR;
using Microsoft.AspNetCore.Mvc;
using Royex.Application.Feature.Queries.User;
using Royex.Presentation.Models;
using System.Diagnostics;

namespace Royex.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            this.mediator = mediator;
        }

        public  IActionResult Index()
        {
            if(TempData.ContainsKey("Message"))
            {
                ViewBag.Message = TempData["Message"];
            }

            return View();
        }

        public async Task<IActionResult> GetAll(int id)
        {
            //call the Mediator request Sender
            var result = await mediator.Send(new GetAllEmployeeUnderManagerQuery(id,trackChange:false,cancellationToken:default));

            if(result != null)
            {
                return View(result);
            }

            TempData["Message"] = "Please provide valid employee id.";

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
