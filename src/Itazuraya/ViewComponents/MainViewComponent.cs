using Microsoft.AspNet.Mvc;

namespace Itazuraya.ViewComponents
{
    public class MainViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title)
        {
            return View(title);
        }
    }
}