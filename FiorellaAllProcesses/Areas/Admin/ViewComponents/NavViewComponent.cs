using Microsoft.AspNetCore.Mvc;

namespace FiorellaAllProcesses.Areas.Admin.ViewComponents
{
    public class NavViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
