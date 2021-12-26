using Microsoft.AspNetCore.Mvc;

namespace FiorellaAllProcesses.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
