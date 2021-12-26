using Microsoft.AspNetCore.Mvc;

namespace FiorellaAllProcesses.Areas.Admin.ViewComponents
{
    public class NavvarViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
