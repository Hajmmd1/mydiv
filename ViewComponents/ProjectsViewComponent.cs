using Microsoft.AspNetCore.Mvc;

namespace mydiv.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View("_Projects");

        }

    }
}
