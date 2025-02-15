using Microsoft.AspNetCore.Mvc;
using mydiv.Models;

namespace mydiv.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                
                new Project( id:1,  name:"تاکسی", description:"درحواست انلاین تاکسی ",client:"snap" ),
                new Project( id:2,  name:"اسنپ فود", description:"درحواست انلاین غذا ",client:"snap" ),
                new Project( id:3,  name:"یه چیز کش", description:"درحواست انلاین ک*س ",client:"ئشئشد غث ذشزا اش" ),
                new Project( id:4,  name:"ساقی", description:"درحواست انلاین رق ",client:"snap" ),
              
            };
            return View("_Projects");

        }

    }
}
