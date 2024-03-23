using Microsoft.AspNetCore.Mvc;
using Mission11_Garner.Models;
using Mission11_Garner.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Garner.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;
        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var things = new ItemListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip(10 * (pageNum - 1))
                .Take(10),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };

            return View(things);
        }

    }
}
