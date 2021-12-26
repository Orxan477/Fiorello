using Microsoft.AspNetCore.Mvc;

namespace FiorellaAllProcesses.Areas.Admin.ViewComponents
{
    public class AdminFooterViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
