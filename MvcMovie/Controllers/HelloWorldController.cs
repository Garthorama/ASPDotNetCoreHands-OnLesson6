using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        // http://localhost:XXXX/HelloWorld/Identification?name=Marshall&numtimes=28&ID=0
        public string Identification(string name, int? numTimes = null, int? ID = null)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}, ID: {ID}");
        }
    }
}