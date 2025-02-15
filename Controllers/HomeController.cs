using Microsoft.AspNetCore.Mvc;
using mydiv.Models;
using System.Diagnostics;

namespace DivCard.Controllers
{
    public class HomeController : Controller
    {
       

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
	        return View();

        }
        [HttpPost]
        public  IActionResult Contact(Contact form)
        {

	        if (ModelState.IsValid==false)
	        {
		        ViewData["error"] = "«ÿ·«·⁄«  Ê«—∆ ‘œÂ ’Õ?Õ ‰?” ";
		        return View(form);
	        }

	        ViewData["succedd"] = "Å?€«„ ‘„« »« „Ê›ﬁ?  —”?œ";
				return View();
					
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
