using Microsoft.AspNetCore.Mvc;

namespace FiorellaAllProcesses.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
