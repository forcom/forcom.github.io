using Microsoft.AspNet.Mvc;

namespace Itazuraya.ViewComponents
{
    public class MainViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int maxPriority)
        {
            return View();
        }
    }
}