
using Microsoft.AspNetCore.Mvc;

namespace RazorFun.Controllers
{
    public class PortfolioController : Controller
    {

        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public IActionResult Index()
        {
            return View();
        }
        //for each route this controller is to handle:
        [HttpGet("projects")]       //type of request
        public IActionResult Projects()
        {
            return View();

        }
        [HttpGet("contact")]       //type of request
        public IActionResult Contact()
        {
            return View();

        }
        [Route("method")]
        public IActionResult Method(string name, string email, string message)
        {
            return RedirectToAction("Index");
        }
    }
}

