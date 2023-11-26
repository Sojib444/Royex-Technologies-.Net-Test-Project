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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllEmployeeUnderRoootManager(int id)
        {
            mediator.Send(new GetAllEmployeeUnderManagerQuery(id,trackChange:false,cancellationToken:default));

            return View();
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
