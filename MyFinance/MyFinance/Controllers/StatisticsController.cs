using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFinance.DB;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class StatisticsController : Controller
    {
        private MyFinanceDbContext _dbContext;

        public StatisticsController(MyFinanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            SetDates();
            var statistics = new Statistics(DateTime.Now.Month, DateTime.Now.Year);

            return View(statistics);
        }

        [HttpPost]
        public IActionResult Index(Statistics statistics)
        {
            ModelState.Clear();
            SetDates();

            statistics.Spendings = _dbContext.Spendings
                .Include(s => s.Category)
                .Where(s => s.DateTime.Month == statistics.Month && s.DateTime.Year == statistics.Year)
                .Select(s => s)
                .OrderBy(s => s.DateTime)
                .Reverse()
                .ToList();

            return View(statistics);
        }

        private void SetDates()
        {
            SetMonths();
            SetYears();
        }
        private void SetMonths()
        {
            List<SelectListItem> months = Enumerable.Range(1, 12)
                .Select(m => new SelectListItem
                {
                    Value = m.ToString(),
                    Text = m.ToString()
                }).ToList();

            ViewData["Months"] = months;
        }
        private void SetYears()
        {
            var date = DateTime.Now.Year - 10;

            List<SelectListItem> years = Enumerable.Range(date, DateTime.Now.Year - date + 1)
                .Select(y => new SelectListItem
                {
                    Value = y.ToString(),
                    Text = y.ToString()
                }).ToList();

            ViewData["Years"] = years;
        }
    }
}
