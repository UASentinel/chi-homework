using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFinance.DB;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class SpendingController : Controller
    {
        private MyFinanceDbContext _dbContext;

        public SpendingController(MyFinanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var spendings = _dbContext.Spendings.Include(s => s.Category).OrderBy(s => s.DateTime).ToList();
            return View(spendings);
        }

        [HttpGet]
        public IActionResult Add()
        {
            SetCategories();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Spending spending)
        {
            ModelState.Clear();
            if (!spending.Validate(ModelState))
            {
                SetCategories();
                TempData["error"] = "Invalid input";
                return View(spending);
            }
            else
            {
                _dbContext.Add(spending);
                _dbContext.SaveChanges();

                TempData["success"] = "Successfully added";
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            SetCategories();
            var spending = _dbContext.Spendings.Include(s => s.Category).FirstOrDefault(s => s.Id == id);
            return View(spending);
        }

        [HttpPost]
        public IActionResult Update(Spending spending)
        {
            ModelState.Clear();
            if (!spending.Validate(ModelState))
            {
                SetCategories();
                TempData["error"] = "Invalid input";
                return View(spending);
            }
            else
            {
                _dbContext.Update(spending);
                _dbContext.SaveChanges();

                TempData["success"] = "Successfully updated";
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var spending = _dbContext.Spendings.Include(s => s.Category).FirstOrDefault(s => s.Id == id);
            return View(spending);
        }

        [HttpPost]
        public IActionResult Delete(Spending spending)
        {
            _dbContext.Spendings.Remove(spending);
            _dbContext.SaveChanges();

            TempData["success"] = "Successfully deleted";
            return RedirectToAction("Index");
        }

        private void SetCategories()
        {
            var categories = _dbContext.Categories.ToList();
            List<SelectListItem> cat = categories
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList();
            ViewData["Categories"] = cat;
        }
    }
}
