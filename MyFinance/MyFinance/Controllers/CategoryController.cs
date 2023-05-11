using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFinance.DB;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class CategoryController : Controller
    {
        private MyFinanceDbContext _dbContext;

        public CategoryController(MyFinanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var categories = _dbContext.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            ModelState.Clear();
            if (!category.Validate(ModelState))
            {
                TempData["error"] = "Invalid input";
                return View(category);
            }
            else
            {
                _dbContext.Add(category);
                _dbContext.SaveChanges();

                TempData["success"] = "Successfully added";
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var category = _dbContext.Categories.FirstOrDefault(c => c.Id == id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Update(Category category)
        {
            ModelState.Clear();
            if (!category.Validate(ModelState))
            {
                TempData["error"] = "Invalid input";
                return View(category);
            }
            else
            {
                _dbContext.Update(category);
                _dbContext.SaveChanges();

                TempData["success"] = "Successfully updated";
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = _dbContext.Categories.FirstOrDefault(c => c.Id == id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            _dbContext.Remove(category);
            _dbContext.SaveChanges();

            TempData["success"] = "Successfully deleted";
            return RedirectToAction("Index");
        }
    }
}
