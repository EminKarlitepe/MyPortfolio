using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _StatisticComponentParital : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
