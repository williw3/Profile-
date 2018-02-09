using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace netCore_start.Controllers
{
    public class ProjectController : Controller
    {
        [HttpGet]  
        [Route("index")]  //Can also put params in routes: Route("template/{Name}")
        public IActionResult index()
        {
            return View("index");
        }

        [HttpGet]  
        [Route("contact")]  //Can also put params in routes: Route("template/{Name}")
        public IActionResult contact()
        {
            return View("contact");
        }

        [HttpGet]  
        [Route("projects")]  //Can also put params in routes: Route("template/{Name}")
        public IActionResult projects()
        {
            return View("projects");
        }
    }
}
