using Microsoft.AspNetCore.Mvc;
using WebApplication1.Filters;
using WebApplication1.Models;
using WebApplication1.Database;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class ExchangesController : Controller
    {
        private readonly ExchangesDbContext _dbContext;
        public ExchangesController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [ServiceFilter(typeof(MyCustomActionFilter))]
        public IActionResult Show(string id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ItemModel item)
        {
            var entity = new ItemEntity
            {
                Name = item.Name,
              Description = item.Description,
                IsVisible = item.IsVisible,

            };
            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();
            var viewModel = new AddNewItemConfirmationViewModel
            {
                Id = 1,
                Name = item.Name,
            };

            return View("AddConfirmation", viewModel);
        }
    }
}